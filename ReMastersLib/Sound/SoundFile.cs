using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ReMastersLib.Sound
{
    public class SoundFile
    {

        public readonly byte[] EncryptedData;
        public readonly byte[] Data;

        public static readonly byte[] Key =
        {
            0x23, 0x7B, 0x9B, 0x77, 0xFE, 0x3C, 0x60, 0xD3, 0xC1, 0xF2, 0x19, 0xEC, 0xD9, 0xBD, 0x1C, 0x9C
        };
        private static byte[] Decrypt(byte[] iv, byte[] dat)
        {
            using (var ms = new MemoryStream(dat.Length))
            {
                ms.Write(dat, 0, dat.Length);
                ms.Position = 0;

                using (var aes = new AesManaged
                {
                    Key = Key,
                    IV = iv,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.None
                })
                using (var decryptor = aes.CreateDecryptor())
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                {
                    var decrypted = new byte[dat.Length];
                    cs.Read(decrypted, 0, decrypted.Length);
                    return decrypted;
                }
            }
        }

        public SoundFile(byte[] data)
        {
            EncryptedData = data;

            Data = new byte[BitConverter.ToUInt32(EncryptedData, 0)];
            Debug.Assert(Data.Length <= EncryptedData.Length);

            var ofs = 0;
            var encOfs = 4;
            while (ofs < Data.Length)
            {
                var chunkSize = BitConverter.ToInt32(EncryptedData, encOfs) ^ BitConverter.ToInt32(EncryptedData, encOfs + 4);
                var iv = Util.GetSlice(EncryptedData, encOfs + 0x4, 0x10);

                var dec = Decrypt(iv, Util.GetSlice(EncryptedData, encOfs + 0x14, (chunkSize + 0xF) & ~0xF));

                Buffer.BlockCopy(dec, 0, Data, ofs, chunkSize);
                ofs += chunkSize;
                encOfs += 0x814;
            }
        }
    }
}
