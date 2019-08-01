using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ReMastersLib
{
    /// <summary>
    /// Android Binary Name Dictionary (not real name)
    /// </summary>
    public class ABND
    {
        public uint MAGIC = 0x646E6261; // abnd

        private readonly byte[] Data;
        private readonly ABNDHeader Header;
        public readonly ABNDExtHeader ExtHeader;

        private readonly byte[] FileNameTable;

        public ABND(byte[] data)
        {
            Data = data;
            Header = Util.GetSlice(data, 0, ABNDHeader.SIZE).ByteArrayToStructure<ABNDHeader>();
            Debug.Assert(Header.Magic == MAGIC);
            Debug.Assert(Header.ExtHeaderOffset == ABNDHeader.SIZE);
            Debug.Assert(Header.ExtHeaderSize == ABNDExtHeader.SIZE);
            ExtHeader = Util.GetSlice(data, Header.ExtHeaderOffset, Header.ExtHeaderSize).ByteArrayToStructure<ABNDExtHeader>();

            Debug.Assert(ExtHeader.EncryptionType == EncryptionType.ChaCha);
            var payload = Util.GetSlice(data, ExtHeader.EStringTableOffset, ExtHeader.EStringTableLength);
            FileNameTable = ChaCha.Decrypt(payload, ExtHeader.IV, ExtHeader.MAC);
        }

        public ABNDFileEntry GetFileInfo(int index)
        {
            if (index > ExtHeader.FileCount)
                throw new ArgumentOutOfRangeException(nameof(index));

            var metaTable = ExtHeader.MetaTableOffset;
            var entryOffset = (index * ABNDFileEntry.SIZE) + metaTable;

            var entryBytes = Util.GetSlice(Data, entryOffset, ABNDFileEntry.SIZE);
            var entry = entryBytes.ByteArrayToStructure<ABNDFileEntry>();
            return entry;
        }

        public byte[] GetFileData(int index)
        {
            var entry = GetFileInfo(index);
            return GetFileData(entry);
        }

        public byte[] GetFileData(ABNDFileEntry entry)
        {
            var chunks = GetChunkData(entry);

            if ((entry.Flags & ABNDFileEntryFlag.Encrypted) != 0)
                TryDecrypt(entry, chunks);

            var file_data = GetFileData(entry, chunks);
            Debug.Assert(file_data != null);

            return file_data;
        }

        private static void TryDecrypt(ABNDFileEntry entry, List<ABNDChunk> chunks)
        {
            Debug.Assert(entry.EncryptionType == EncryptionType.ChaCha);

            uint totalLen = 0;
            foreach (var chunk in chunks)
                totalLen += chunk.Length;

            var encrypted = GetConcatenatedEncryptedChunks(totalLen, chunks);

            var IV = entry.IV;
            var xor = IV.Xor(12);
            var decrypted = ChaCha.Decrypt(encrypted, xor, entry.MAC);
            if (decrypted == null)
                throw new Exception();

            // rechunk data
            GetDecryptedChunks(chunks, decrypted);
        }

        private static byte[] GetConcatenatedEncryptedChunks(uint totalLen, List<ABNDChunk> chunks)
        {
            byte[] encrypted = new byte[totalLen];

            uint offset = 0;
            foreach (var chunk in chunks)
            {
                chunk.Data.CopyTo(encrypted, offset);
                offset += chunk.Length;
            }

            return encrypted;
        }

        private static void GetDecryptedChunks(List<ABNDChunk> chunks, byte[] decrypted)
        {
            int offset = 0;
            foreach (var chunk in chunks)
            {
                chunk.Data = Util.GetSlice(decrypted, offset, (int) chunk.Length);
                offset += (int) chunk.Length;
            }
        }

        private byte[] GetFileData(ABNDFileEntry entry, List<ABNDChunk> chunks)
        {
            if ((entry.Flags & ABNDFileEntryFlag.Compressed) == 0)
                return GetDecompressedFileData(entry, chunks);

            var result = LZ4.DecodeChunks(chunks, ExtHeader.BlockSizeSectors << 9, entry.DecompressedLength);
            Debug.Assert(result.Length == entry.DecompressedLength);
            return result;
        }

        private static byte[] GetDecompressedFileData(ABNDFileEntry entry, List<ABNDChunk> chunks)
        {
            Debug.Assert(entry.CompressedLength == entry.DecompressedLength);
            var result = new byte[entry.DecompressedLength];

            uint offset = 0;
            foreach (var chunk in chunks)
            {
                chunk.Data.CopyTo(result, offset);
                offset += chunk.Length;
            }

            return result;
        }

        public string GetFileName(int index)
        {
            var entry = GetFileInfo(index);
            return GetFileName(entry);
        }

        public string GetFileName(ABNDFileEntry entry)
        {
            var encoding = Encoding.UTF8;
            return encoding.GetString(FileNameTable, entry.FileNameOffset, entry.FileNameLength);
        }

        public List<ABNDChunk> GetChunkData(ABNDFileEntry entry)
        {
            var result = new List<ABNDChunk>();
            var ofs = entry.CompressedOffset;

            if ((entry.Flags & ABNDFileEntryFlag.Compressed) == 0)
            {
                var blob = new ABNDChunk
                {
                    Data = Data,
                    Length = (uint) entry.CompressedLength,
                };
                result.Add(blob);
                return result;
            }

            do
            {
                var len = BitConverter.ToInt32(Data, ofs);

                // copy chunk data to final array at current position
                byte[] chunk = Util.GetSlice(Data, ofs + 4, len);
                var blob = new ABNDChunk
                {
                    Data = chunk,
                    Length = (uint) len,
                };
                result.Add(blob);

                // advance to next chunk
                ofs += 4 + len;
            } while (ofs < entry.CompressedOffset + entry.CompressedLength);

            return result;
        }
    }
}
