using System;
using Waher.Security.ChaChaPoly;

namespace ReMastersLib
{
    /// <summary>
    /// Wrapper for nuget package
    /// </summary>
    public static class ChaCha
    {
        private static readonly byte[] Key =
        {
            0xC7, 0x79, 0xCC, 0x30, 0x44, 0xC0, 0xE0, 0x4E,
            0xA3, 0x24, 0x0C, 0xAE, 0x80, 0xCF, 0xF6, 0xA9,
            0x8A, 0xF9, 0x53, 0x63, 0x68, 0xC3, 0x60, 0x2C,
            0xA4, 0xC2, 0x6D, 0xC7, 0xBC, 0xA2, 0x37, 0x51,
        };

        private static readonly byte[] XorKey = BitConverter.GetBytes(1234567891234567891ul);

        /// <summary>
        /// Decrypts the data.
        /// </summary>
        /// <returns>Null if the provided Mac doesn't match the calculated Mac</returns>
        public static byte[] Decrypt(byte[] data, byte[] nonce, byte[] mac)
        {
            var chacha = new AeadChaCha20Poly1305(Key, nonce);
            return chacha.Decrypt(data, Array.Empty<byte>(), mac);
        }

        public static byte[] Xor(this byte[] iv, int arrsize)
        {
            byte[] result = new byte[arrsize];
            iv.CopyTo(result, 0);

            for (int i = XorKey.Length - 1; i >= 0; i--)
                result[i] ^= XorKey[i];
            return result;
        }
    }
}
