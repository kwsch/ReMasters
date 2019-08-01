using System.Runtime.InteropServices;

namespace ReMastersLib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ABNDFileEntry
    {
        public const int SIZE = 0x40;

        public int CompressedOffset;
        public int CompressedLength;
        public int DecompressedLength;
        public int FileNameOffset;
        public int FileNameLength;
        public ABNDFileEntryFlag Flags; // Usually Compressed & Encrypted
        public uint _0x18; // 0
        public EncryptionType EncryptionType; // 1

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x10)]
        public byte[] MAC;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x8)]
        public byte[] IV;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x8)]
        public byte[] Unused;
    }
}