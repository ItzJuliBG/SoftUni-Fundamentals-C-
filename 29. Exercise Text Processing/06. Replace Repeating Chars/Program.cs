using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        /*
aabbbbbcdddeeeedssaa
abcdedsa
         */
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                string current = input[i].ToString();
                string previous = input[i-1].ToString();
                if (!(current == previous))
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
