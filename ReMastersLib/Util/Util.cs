using System;

namespace ReMastersLib
{
    public static class Util
    {
        public static byte[] GetSlice(byte[] src, int offset, int length)
        {
            byte[] data = new byte[length];
            Buffer.BlockCopy(src, offset, data, 0, data.Length);
            return data;
        }
    }
}