using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using K4os.Hash.xxHash;
using ReMastersLib.Sound;

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
            var jsonPath = Path.Combine(outRoot, "lsddump", "apk");
            var txtPath = Path.Combine(outRoot, "lsddump", "lsd_apk.txt");
            LSDDumper.Dump(messages, jsonPath, txtPath);
        }

        public void DumpMessagesDownload(string outRoot)
        {
            var messages = Path.Combine(outRoot, "Messages");
            var jsonPath = Path.Combine(outRoot, "lsddump", "dl");
            var txtPath = Path.Combine(outRoot, "lsddump", "lsd_dl.txt");
            LSDDumper.Dump(messages, jsonPath, txtPath);
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

        public void DumpSound(string outRoot)
        {
            foreach (var audioType in new[] {"BGM", "SE", "Voice_en", "Voice_ja"})
            {
                var jsonPath = Path.Combine(outRoot, "sound", $"{audioType}.json");
                if (!File.Exists(jsonPath))
                    continue;

                var audioJson = JObject.Parse(File.ReadAllText(jsonPath));
                foreach (var audioBank in audioJson["audioBanks"])
                {
                    foreach (var audioResource in audioBank["audioResources"])
                    {
                        var name = audioResource["name"].ToString();
                        var format = audioResource["format"].ToString();
                        if (format != "ogg") throw new ArgumentException($"Unknown format for {name}: {format}");

                        var fileID = XXH64.DigestOf(Encoding.ASCII.GetBytes($"{name}.{format}"));
                        var folder = fileID;
                        while (folder >= 10)
                            folder /= 10;

                        var resourcePath = Path.Combine(DownloadPath, $"{folder}", $"{fileID}");

                        if (!File.Exists(resourcePath))
                        {
                            if (!name.StartsWith("sound/Bundle"))
                            {
                                Console.WriteLine($"Failed to find {name} ({resourcePath})");
                            }
                            continue;
                        }

                        var sf = new SoundFile(File.ReadAllBytes(resourcePath));

                        var outPath = $"{Path.Combine(outRoot, name.Replace("/", $"{Path.DirectorySeparatorChar}"))}.{format}";
                        Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                        File.WriteAllBytes(outPath, sf.Data);
                    }
                }
            }
        }

        private void DumpSyncPairPreviewVideo(string outRoot)
        {
            var pbPath = Path.Combine(outRoot, @"db\master\pb\ScoutPickup.pb");

            if (!File.Exists(pbPath))
                pbPath = Path.Combine(outRoot, @"db\master\pb\LotteryPickup.pb"); // different name in v1.0.0

            if (!File.Exists(pbPath))
            {
                Console.WriteLine($"Failed to find ScoutPickup.pb or LotteryPickup.pb: skip Sync Pair Preview videos");
                return;
            }

            var table = ScoutPickupTable.Parser.ParseFrom(File.ReadAllBytes(pbPath));
            foreach (var message in table.Entries)
            {
                var path = $"Movie/Scout/Pickup/{message.ScoutId}/{message.ScoutPickupId}.mp4";
                var fileIDString = $"{XXH64.DigestOf(Encoding.ASCII.GetBytes(path))}";
                var resourcePath = Path.Combine(DownloadPath, $"{fileIDString[0]}", fileIDString);
                if (!File.Exists(resourcePath))
                {
                    Console.WriteLine($"Failed to find {path} ({resourcePath})");
                    continue;
                }

                var outPath = $"{Path.Combine(outRoot, path.Replace("/", $"{Path.DirectorySeparatorChar}"))}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                System.IO.File.Copy(resourcePath, outPath, true);
            }
        }

        private void DumpVideoWithUnknownName(string outRoot, Dictionary<string, string> unkNameVideos)
        {
            foreach (var entry in FileDB.Values)
            {
                var fileIDString = $"{entry.FileID}";
                if (!unkNameVideos.ContainsKey(fileIDString))
                    continue;

                var resourcePath = Path.Combine(DownloadPath, $"{entry.FileName[0]}", entry.FileName);
                if (!File.Exists(resourcePath))
                {
                    Console.WriteLine($"Failed to find video {resourcePath}");
                    continue;
                }

                // we don't know the actual video names, but can still place them in the correct(ish?) folder
                var relPath = Path.GetDirectoryName(unkNameVideos[fileIDString]).Replace("/", $"{Path.DirectorySeparatorChar}");
                var outPath = $"{Path.Combine(outRoot, relPath, $"{entry.FileName}.mp4")}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                System.IO.File.Copy(resourcePath, outPath, true);
            }
        }

        public void DumpMiscVideo(string outRoot)
        {
            var jsonPath = Path.Combine(outRoot, @"db\asset\bundles_archives.json");
            if (!File.Exists(jsonPath))
                return;

            var unkNameVideos = new Dictionary<string, string>();
            var json = JObject.Parse(File.ReadAllText(jsonPath));
            foreach (var archive in json["archives"])
            {
                var archiveName = archive["name"].ToString();
                if (!archiveName.StartsWith("archive_Movie_"))
                    continue;

                foreach (var p in archive["include"])
                {
                    var path = p.ToString();
                    if (path.EndsWith(".mp4"))
                    {
                        var fileIDString = $"{XXH64.DigestOf(Encoding.ASCII.GetBytes(path))}";
                        var resourcePath = Path.Combine(DownloadPath, $"{fileIDString[0]}", fileIDString);

                        if (!File.Exists(resourcePath))
                        {
                            Console.WriteLine($"Failed to find {path} ({resourcePath})");
                            continue;
                        }

                        var outPath = $"{Path.Combine(outRoot, path.Replace("/", $"{Path.DirectorySeparatorChar}"))}";
                        Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                        System.IO.File.Copy(resourcePath, outPath, true);
                    }
                    else if (!path.StartsWith("Movie/Scout/Pickup/"))
                    {
                        var archiveNameHashString = $"{XXH64.DigestOf(Encoding.ASCII.GetBytes(archiveName))}";
                        if (unkNameVideos.ContainsKey(archiveNameHashString))
                            Console.WriteLine($"Multiple paths given for {archiveName}: fallback to {path}");
                        unkNameVideos[archiveNameHashString] = path;
                    }
                }
            }
            DumpVideoWithUnknownName(outRoot, unkNameVideos);
        }

        public void DumpVideo(string outRoot)
        {
            DumpSyncPairPreviewVideo(outRoot);
            DumpMiscVideo(outRoot);
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