using System.Collections.Generic;
using System.Diagnostics;
using K4os.Compression.LZ4.Encoders;

namespace ReMastersLib
{
    /// <summary>
    /// Wrapper for nuget lib
    /// </summary>
    public static class LZ4
    {
        public static unsafe byte[] DecodeChunks(List<ABNDChunk> chunks, uint blockSize, int decLength)
        {
            var result = new byte[decLength];
            var decoder = LZ4Decoder.Create(true, (int)blockSize, chunks.Count - 1);
            int offset = 0;
            foreach (var chunk in chunks)
            {
                fixed (byte* chunkP = chunk.Data)
                {
                    int chunkLen = decoder.Decode(chunkP, (int)chunk.Length);
                    Debug.Assert(chunkLen > 0 || chunk.Length == 1);
                    offset -= chunkLen;
                }
            }
            fixed (byte *resultP = result)
            {
                decoder.Drain(resultP, offset, decLength);
            }
            return result;
        }
    }
}