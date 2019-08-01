namespace ReMastersLib
{
    public class GameDataPaths
    {
        public string UnpackedAPKPath { get; set; }
        public string ShardPath { get; set; }
        public string OutputPath { get; set; }
        public string DownloadPath { get; set; }

        public void DumpGameData()
        {
            var dumper = new GameDumper(UnpackedAPKPath, DownloadPath);
            dumper.LoadShard(ShardPath);
            dumper.DumpAll(OutputPath);
        }
    }
}