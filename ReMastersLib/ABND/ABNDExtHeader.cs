using System.Runtime.InteropServices;

namespace ReMastersLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ABNDExtHeader
    {
        public const int SIZE = 0x40;

        public int MetaTableOffset;
        public int MetaTableSize;
        public uint FileCount;
        public uint BlockSizeSectors;
        public int EStringTableOffset;
        public int EStringTableEnd;
        public EncryptionType EncryptionType; // 1
        public uint _0x1C; // 0

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0xC)]
        public byte[] IV;

        public uint _0x2C; // 0

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x10)]
        public byte[] MAC; // MAC

        public int EStringTableLength => EStringTableEnd - EStringTableOffset;
    }
}