using System;
using System.Diagnostics;
using System.Text;

namespace ReMastersLib
{
    /// <summary>
    /// Language [Statement] [Digraph] ??
    /// </summary>
    public class LSD
    {
        public const int MAGIC = 0x4C534446; // LSDF (LSD File)

        private readonly byte[] Data;

        public LSD(byte[] data)
        {
            Data = data;
            Debug.Assert(Magic == MAGIC);
        }

        private uint Magic => BitConverter.ToUInt32(Data, 0x00);
        public int Count => BitConverter.ToInt32(Data, 0x0C);

        public string[] GetLines()
        {
            int count = Count;
            string[] result = new string[Count];
            for (int i = 0; i < count; i++)
                result[i] = GetLine(i);
            return result;
        }

        private string GetLine(int i)
        {
            var eOfs = GetEntryInfoOffset(i);
            int ofs = BitConverter.ToInt32(Data, eOfs + 0);
            int codeLen = BitConverter.ToInt16(Data, eOfs + 4);
            int len = BitConverter.ToInt32(Data, eOfs + 6);

            var enc = Encoding.UTF8;
            var code = enc.GetString(Data, ofs, codeLen);
            var str = enc.GetString(Data, ofs + codeLen, len);

            return $"[{code}] {str}";
        }

        private static int GetEntryInfoOffset(int i)
        {
            // assumed struct:
            // u32 data start
            // u16 ID length
            // u32 string length

            const int start = 0x1E + 4;
            const int size = 0xA;
            return start + (size * i);
        }
    }
}
