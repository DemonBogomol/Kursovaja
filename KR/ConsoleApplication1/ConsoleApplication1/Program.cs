using System;
using System.IO;
using System.Text;

namespace EncryptionDecryptionUsingSymmetricKey
{
    class Program
    {
        static void Main(string[] args)
        {

            var key = "b14ca5898a4e4133bbce2ea2315a1916";


            Console.Write("Текст = ");
            Console.WriteLine(File.ReadAllText("Sample.txt", Encoding.UTF8));
            var encryptedString = AesOperation.EncryptString(key, File.ReadAllText("Sample.txt", Encoding.UTF8));
            Console.WriteLine($"Зашифрованный текст = {encryptedString}");

            var decryptedString = AesOperation.DecryptString(key, encryptedString);
            Console.WriteLine($"Дешифрованный текст = {decryptedString}");

            Console.ReadKey();
        }
    }
}