using System.Runtime.InteropServices;

namespace ReMastersLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ASDBExtHeader
    {
        public const int SIZE = 0x10;

        public int EntryCount;
        public int EntrySize;
        public int EntryStart;
        public EncryptionType EncryptionType;
    }
}