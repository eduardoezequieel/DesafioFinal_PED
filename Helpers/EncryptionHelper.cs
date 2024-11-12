using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_PED.Helpers
{
    internal static class EncryptionHelper
    {
        private static readonly string Key = "PED_h@shkwnxks_a1234567890123456"; // 32 caracteres
        private static readonly string IV = "PED_h@sh_iv_1234"; // 16 caracteres

        public static string Encrypt(string text)
        {
            try
            {
                using Aes aes = Aes.Create();
                aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.IV = Encoding.UTF8.GetBytes(IV);

                using var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using var ms = new MemoryStream();
                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(text);
                    }
                }
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return string.Empty;
            }
        }

        public static string Decrypt(string encryptedText)
        {
            try
            {
                using Aes aes = Aes.Create();
                aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.IV = Encoding.UTF8.GetBytes(IV);

                using var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using var ms = new MemoryStream(Convert.FromBase64String(encryptedText));
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                {
                    using (var sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return string.Empty;
            }
        }
    }
}
