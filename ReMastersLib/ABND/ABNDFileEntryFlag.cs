using System;

namespace ReMastersLib
{
    [Flags]
    public enum ABNDFileEntryFlag : uint
    {
        None,
        Encrypted = 1 << 0,
        Compressed = 1 << 1
    }
}