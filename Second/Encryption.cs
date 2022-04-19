using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Encryption
    {
        public static byte[] EncryptString(string toEncrypt, CipherMode mode, string keyText)
        {
            var key = CreateHash(keyText);

            using (var aes = Aes.Create())
            using (var encryptor = aes.CreateEncryptor(key, key))
            {
                aes.Mode = mode;
                var plainText = Encoding.UTF8.GetBytes(toEncrypt);
                return encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
            }
        }

        public static string DecryptToString(byte[] encryptedData, CipherMode mode, string keyText)
        {
            var key = CreateHash(keyText);
      
            using (var aes = Aes.Create())
            using (var encryptor = aes.CreateDecryptor(key, key))
            {
                aes.Mode = mode;
                var decryptedBytes = encryptor
                    .TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        private static byte[] CreateHash(string password)
        {
            var keyBytes = Encoding.UTF8.GetBytes(password);
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(keyBytes);
            }
        }
    }
}
