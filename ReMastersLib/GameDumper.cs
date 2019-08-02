using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ReMastersLib
{
    public class GameDumper
    {
        public readonly string BasePath;
        public readonly string DownloadPath;
        private Dictionary<string, ResourceLocationEntry> ResourceDB;
        private Dictionary<string, FileLocationEntry> FileDB;
        private ABND AssetShard;

        /// <summary>
        /// Initializes the asset unpacker
        /// </summary>
        /// <param name="root">Root folder where the unpacked apk data resides.</param>
        /// <param name="dlPath">Root folder where the download data resides.</param>
        public GameDumper(string root, string dlPath)
        {
            BasePath = root;
            DownloadPath = dlPath;
            // read in shards & file/folder maps
        }

        private void LoadResourceDB(string path)
        {
            var data = File.ReadAllBytes(path);
            var asdb = new ASDB(data);
            Debug.Assert(asdb.ExtHeader.EntrySize == 0x18);
            ResourceDB = asdb.GetEntryDictionary<ResourceLocationEntry>();
        }

        private void LoadFileDB(string path)
        {
            var data = File.ReadAllBytes(path);
            var asdb = new ASDB(data);
            Debug.Assert(asdb.ExtHeader.EntrySize == 0x10);
            FileDB = asdb.GetEntryDictionary<FileLocationEntry>();
        }

        public void LoadShard(string path)
        {
            var data = File.ReadAllBytes(path);
            AssetShard = new ABND(data);
        }

        public void InitializeShardData(string outRoot)
        {
            Directory.CreateDirectory(outRoot);
            // Process the asset database shard info, and load the unpacked files
            DumpABND(AssetShard, outRoot);
            LoadResourceDB(Path.Combine(outRoot, "resource_location.asdb"));
            LoadFileDB(Path.Combine(outRoot, "file_location.asdb"));
            // don't care about archive_info.asdb
            // don't care about bundle_header_hash.asdb
        }

        public void DumpMessagesAPK(string outRoot)
        {
            var messages = Path.Combine(BasePath, @"assets\resources\assets\Messages");
            var outPath = Path.Combine(outRoot, "lsd_apk.txt");
            LSDDumper.Dump(messages, outPath);
        }

        public void DumpMessagesDownload(string outRoot)
        {
            var messages = outRoot;
            var outPath = Path.Combine(outRoot, "lsd_dl.txt");
            LSDDumper.Dump(messages, outPath);
        }

        public void DumpResources(string outRoot)
        {
            // dump the abnd's, and track which ones we've already seen
            var processed = new HashSet<string>();

            foreach (var f in ResourceDB)
            {
                // Get the file's location on the disk
                var fn = f.Value.ContainerName;
                if (processed.Contains(fn))
                    continue;

                var folder = fn[0].ToString();
                var file = Path.Combine(DownloadPath, folder, fn);

                if (!File.Exists(file))
                {
                    Debug.WriteLine("Unable to find file (optional?): " + fn);
                    continue;
                }

                // Read ABND
                var data = File.ReadAllBytes(file);
                var abnd = new ABND(data);

                // Dump ABND to final location
                var outPath = outRoot; //  Path.Combine(outRoot, fn); -- don't bother using the ABND zip name; just get everything in one folder
                DumpABND(abnd, outPath);

                processed.Add(fn);
            }
        }

        public void DumpProto(string outRoot, bool tableLayout = true)
        {
            var pdf = Path.Combine(outRoot, "protodump");
            Directory.CreateDirectory(pdf);

            var types = ProtoTableDumper.GetProtoTypes();
            foreach (var t in types)
            {
                var name = t.Name.Replace("Table", string.Empty);
                var filename = $"{name}.pb";
                var path = Path.Combine(outRoot, @"db\master\pb\", filename);
                var outpath = Path.Combine(pdf, $"{name}.json");
                if (!File.Exists(path))
                {
                    Debug.WriteLine($"Couldn't find proto data file: {name}");
                    continue;
                }
                var data = File.ReadAllBytes(path);

                if (tableLayout)
                {
                    var result = ProtoTableDumper.GetProtoStrings(t, data);
                    if (result == null)
                    {
                        Debug.WriteLine($"Bad conversion for {name}, skipping.");
                        continue;
                    }
                    File.WriteAllLines(outpath, result);
                }
                else
                {
                    var result = ProtoTableDumper.GetProtoString(t, data);
                    if (result == null)
                    {
                        Debug.WriteLine($"Bad conversion for {name}, skipping.");
                        continue;
                    }
                    File.WriteAllText(outpath, result);
                }
            }
        }

        /// <summary>
        /// Spits out all contents of the <see cref="abnd"/> to the <see cref="outPath"/>
        /// </summary>
        /// <param name="abnd">Archive</param>
        /// <param name="outPath">Location to dump to</param>
        private static void DumpABND(ABND abnd, string outPath)
        {
            Directory.CreateDirectory(outPath);
            for (int i = 0; i < abnd.ExtHeader.FileCount; i++)
            {
                var fi = abnd.GetFileInfo(i);
                var fn = abnd.GetFileName(fi);
                var fd = abnd.GetFileData(fi);

                var path = Path.Combine(outPath, fn);
                var di = Path.GetDirectoryName(path);
                if (di != null)
                    Directory.CreateDirectory(di);

                File.WriteAllBytes(path, fd);
            }
        }
    }
}