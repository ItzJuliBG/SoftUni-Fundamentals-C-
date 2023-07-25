using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string inp = Console.ReadLine();
            //char[] chars = inp.ToCharArray();
            //List<char> encrypted = new List<char>();
            //foreach (var letter in chars)
            //{
            //    int t = letter + 3;
            //    char c = (char)t;
            //    encrypted.Add(c);
            //}
            //Console.WriteLine(string.Join("", encrypted));

            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                char orr = c;
                sb.Append((char)(orr+3));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
