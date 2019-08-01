using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ReMastersLib
{
    public class ASDB
    {
        public uint MAGIC = 0x62646261; // abdb

        private readonly byte[] Data;
        private readonly ASDBHeader Header;
        public readonly ASDBExtHeader ExtHeader;

        public ASDB(byte[] data)
        {
            Data = data;
            Header = Util.GetSlice(data, 0, ASDBHeader.SIZE).ByteArrayToStructure<ASDBHeader>();
            Debug.Assert(Header.Magic == MAGIC);
            Debug.Assert(Header.ExtHeaderOffset == ASDBHeader.SIZE);
            Debug.Assert(Header.ExtHeaderSize == ASDBExtHeader.SIZE);
            ExtHeader = Util.GetSlice(data, Header.ExtHeaderOffset, Header.ExtHeaderSize).ByteArrayToStructure<ASDBExtHeader>();

            Debug.Assert(ExtHeader.EncryptionType == EncryptionType.None);
        }

        public byte[] GetEntry(int index)
        {
            if ((uint)index >= ExtHeader.EntryCount)
                throw new ArgumentException(nameof(index));

            var len = ExtHeader.EntrySize;
            var ofs = ExtHeader.EntryStart + (len * index);

            return Util.GetSlice(Data, ofs, len);
        }

        public Dictionary<string, T> GetEntryDictionary<T>() where T : struct, IFileName
        {
            var result = new Dictionary<string, T>(ExtHeader.EntryCount);
            for (int i = 0; i < ExtHeader.EntryCount; i++)
            {
                var entry = GetEntry(i);
                var obj = entry.ByteArrayToStructure<T>();
                result.Add(obj.FileName, obj);
            }
            return result;
        }

        public T[] GetEntryArray<T>(ASDB asdb) where T : struct
        {
            var result = new T[asdb.ExtHeader.EntryCount];
            for (int i = 0; i < asdb.ExtHeader.EntryCount; i++)
            {
                var entry = asdb.GetEntry(i);
                result[i] = entry.ByteArrayToStructure<T>();
            }

            return result;
        }
    }
}
