using System.Collections.Generic;
using System.IO;

namespace ReMastersLib
{
    public static class LSDDumper
    {
        public static void Dump(string path, string outPath)
        {
            var result = Dump(path);
            File.WriteAllLines(outPath, result);
        }

        private static IEnumerable<string> Dump(string path)
        {
            var files = Directory.EnumerateFiles(path, "*.lsd", SearchOption.AllDirectories);

            var result = new List<string>();
            foreach (var f in files)
                AddStrings(f, result);

            return result;
        }

        private static void AddStrings(string file, List<string> result)
        {
            var fn = Path.GetFileName(file);
            result.Add("===========");
            result.Add(fn);
            result.Add("===========");

            var data = File.ReadAllBytes(file);
            var f = new LSD(data);
            var lines = f.GetLines();
            result.AddRange(lines);
            result.Add("");
        }
    }
}