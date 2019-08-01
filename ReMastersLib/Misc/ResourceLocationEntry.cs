using System.Runtime.InteropServices;

namespace ReMastersLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ResourceLocationEntry : IFileName
    {
        public const int SIZE = 0x18;

        /// <summary>
        /// u64 file hash name?
        /// </summary>
        public ulong ResourceID;

        /// <summary>
        /// Container Name the asset is in
        /// </summary>
        public ulong FileID;

        /// <summary>
        /// Index within the <see cref="FileID"/>
        /// </summary>
        public ulong AssetIndex;


        public string FileName => ResourceID.ToString();
        public string ContainerName => FileID.ToString();
    }
}
