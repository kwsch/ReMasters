namespace ReMastersLib
{
    public class DumpSettings
    {
        public bool DumpStringsAPK { get; set; } = true;
        public bool DumpStringsDL { get; set; } = true;
        public bool DumpResources { get; set; } = true;
        public bool DumpSound { get; set; } = true;
        public bool DumpVideo { get; set; } = true;
        public bool DumpProto { get; set; } = true;

        public readonly GameDataPaths Paths;

        public DumpSettings(GameDataPaths p) => Paths = p;

        public void DumpGameData()
        {
            var dumper = new GameDumper(Paths.UnpackedAPKPath, Paths.DownloadPath);
            dumper.LoadShard(Paths.ShardPath);
            dumper.InitializeShardData(Paths.OutputPath);

            if (DumpStringsAPK)
                dumper.DumpMessagesAPK(Paths.OutputPath);
            if (DumpResources)
                dumper.DumpResources(Paths.OutputPath);
            if (DumpStringsDL)
                dumper.DumpMessagesDownload(Paths.OutputPath);
            if (DumpSound)
                dumper.DumpSound(Paths.OutputPath);
            if (DumpVideo)
                dumper.DumpVideo(Paths.OutputPath);
            if (DumpProto)
                dumper.DumpProto(Paths.OutputPath);
        }
    }
}