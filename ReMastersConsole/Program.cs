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
                UnpackedAPKPath = @"D:\Kurt\Desktop\masters",
                DownloadPath = @"D:\Kurt\Desktop\masters\dl\data\com.dena.a12026418\files\downloaded-resource-dir",
                ShardPath = @"D:\Kurt\Desktop\masters\dl\downloaded-resource-dir\downloaded-resource-dir\assetdb_shard",
                OutputPath = @"D:\masterdump",
            };

            var settings = new DumpSettings(paths)
            {
                DumpStringsDL = true,
                DumpStringsAPK = true,

                DumpResources = true,
                DumpProto = true,
            };

            settings.DumpGameData();
        }
    }
}
