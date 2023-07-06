using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().ToLower().Split().ToList();
            Dictionary<string, int> input = new Dictionary<string, int>();
           List<string> test = new List<string>();
            foreach (string s in list)
            {
                if (input.ContainsKey(s))
                {
                    input[s] = input[s] + 1;
                }
                else
                {
                    input.Add(s, 1);
                }
            }
            
            foreach (var s in input)
            {
                if(s.Value % 2 != 0)
                {
                    test.Add(s.Key);
                }
            }
            Console.WriteLine(string.Join(" ", test));
        }
    }
}
