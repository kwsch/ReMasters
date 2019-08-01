using System.Runtime.InteropServices;

namespace ReMastersLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ASDBHeader
    {
        public const int SIZE = 0x10;

        public uint Magic;
        public uint Version;
        public int ExtHeaderOffset;
        public int ExtHeaderSize;
    }
}