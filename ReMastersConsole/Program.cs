using System;
using ReMastersLib;

namespace ReMastersConsole
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Not a console app, really. Don't do that!");
                Console.ReadLine();
            }

            var paths = new GameDataPaths
            {
                UnpackedAPKPath = @"E:\masters-inv\2.9.0\apk",
                DownloadPath = @"E:\masters-inv\2.9.0\downloaded-resource-dir",
                ShardPath = @"E:\masters-inv\2.9.0\downloaded-resource-dir\assetdb_shard",

                OutputPath = @"E:\masters-inv\2.9.0\dump",
            };

            var settings = new DumpSettings(paths)
            {
                DumpStringsDL = true,
                DumpStringsAPK = true,

                DumpResources = true,
                DumpSound = true,
                DumpProto = false,
            };

            settings.DumpGameData();
        }
    }
}
