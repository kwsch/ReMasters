using System.Runtime.InteropServices;

namespace ReMastersLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FileLocationEntry : IFileName
    {
        public const int SIZE = 0x10;

        /// <summary>
        /// u64 file hash name?
        /// </summary>
        public ulong ResourceID;

        /// <summary>
        /// Container Name the asset is in
        /// </summary>
        public ulong FileID;

        public string FileName => ResourceID.ToString();
    }
}