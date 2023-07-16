using System;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> ints = new List<char>();
            List<char> letters = new List<char>();
            List<char> others = new List<char>();
            foreach (char c in input)
            {
                if (true == char.IsDigit(c))
                {
                    ints.Add(c);
                }
                else if (true == char.IsLetter(c))
                {
                    letters.Add(c);
                }
                else
                {
                    others.Add(c);
                }
            }
            Console.WriteLine(string.Join("", ints));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", others));
        }
    }
}
