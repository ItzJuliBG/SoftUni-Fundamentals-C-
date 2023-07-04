using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            for (int i = 0; i < input.Count; i++)
            {
              Random randomWord = new Random(int.Parse(input[i]));
                Console.WriteLine(randomWord.Next(0, 5));
            }
        }
    }
}
