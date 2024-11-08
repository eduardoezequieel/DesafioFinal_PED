using System.Security.Cryptography;
using System.Text;

namespace ProyectoFinal_PED.Helpers
{
    internal static class EncryptionHelper
    {
        private static readonly string Key = "PED_h@shkwnxks_a";

        public static string Encrypt(string text)
        {
            try
            {
                using Aes aes = Aes.Create();
                aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.IV = new byte[16];

                using var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using var ms = new MemoryStream();
                {
                    var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                    var sw = new StreamWriter(cs);
                    sw.Write(text);
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }

        public static string Decrypt(string encryptedText)
        {
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(Key);
            aes.IV = new byte[16];

            var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            var ms = new MemoryStream(Convert.FromBase64String(encryptedText));
            var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
            var sr = new StreamReader(cs);

            return sr.ReadToEnd();
        }
    }
}
