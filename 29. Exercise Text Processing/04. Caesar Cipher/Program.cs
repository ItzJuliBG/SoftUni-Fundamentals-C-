using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            char[] chars = inp.ToCharArray();
            List<char> encrypted = new List<char>();
            foreach (var letter in chars)
            {
                int t = letter + 3;
                char c = (char)t;
                encrypted.Add(c);
            }
            Console.WriteLine(string.Join("", encrypted));
        }
    }
}
