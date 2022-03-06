using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ReMastersLib
{
    public static class LSDDumper
    {
        public static void Dump(string lsdPath, string jsonPath, string txtPath)
        {
            Directory.CreateDirectory(jsonPath);
            var files = Directory.EnumerateFiles(lsdPath, "*.lsd", SearchOption.AllDirectories);

            using (StreamWriter sw = File.CreateText(txtPath))
            {
                foreach (var f in files)
                {
                    var data = File.ReadAllBytes(f);
                    var lsd = new LSD(data);
                    var entries = lsd.GetEntries();
                    AddStrings(f, entries, sw);
                    DumpJSON(f, entries, lsdPath, jsonPath);
                }
            }
        }

        private static void AddStrings(string file, KeyValuePair<string,string>[] entries, StreamWriter sw)
        {
            var fn = Path.GetFileName(file);
            sw.WriteLine("===========");
            sw.WriteLine(fn);
            sw.WriteLine("===========");

            foreach (var entry in entries)
                sw.WriteLine($"[{entry.Key}] {entry.Value}");

            sw.WriteLine("");
        }

        private static void DumpJSON(string file, KeyValuePair<string,string>[] entries, string lsdPath, string jsonPath)
        {
            var relPath = file.Replace(lsdPath + Path.DirectorySeparatorChar, "");
            var path = Path.Combine(jsonPath, relPath);
            path = Path.ChangeExtension(path, "json");

            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using (StreamWriter sw = File.CreateText(path))
            {
                var size = entries.Length;

                sw.WriteLine("{");
                for (int i = 0; i < size; i++)
                {
                    var entry = entries[i];
                    var key = JsonConvert.ToString(entry.Key);
                    var val = JsonConvert.ToString(entry.Value);
                    sw.WriteLine($"    {key}: {val}" + (i == size - 1 ? "" : ","));
                }
                sw.WriteLine("}");
            }
        }
    }
}