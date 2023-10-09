using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caesar Cipher Encryption and Decryption");
            Console.Write("Enter a text: ");
            string txt = Console.ReadLine();

            int shift = 3;
           
            string encrypted = Encrypt(txt, shift);
            string decrypted = Decrypt(txt, shift);

            Console.WriteLine($"Encrypted message: {encrypted}");
            Console.WriteLine($"Decrypted message: {decrypted}");

            Console.ReadKey();
        }

        static string Encrypt(string txt, int shift)
        {
            char[] chars = txt.ToCharArray();

            for(int i =0; i < chars.Length; i++) 
            {
                if (char.IsLetter(chars[i]))
                {
                    char offset = char.IsUpper(chars[i]) ? 'A' : 'a';
                    chars[i] = (char)((chars[i] - offset + shift) % 26 + offset);
                }
            }

            return new string(chars);
        }
        static string Decrypt(string txt, int shift)
        {
            return Encrypt(txt, 26 - shift); 
        }
        
    }
}
