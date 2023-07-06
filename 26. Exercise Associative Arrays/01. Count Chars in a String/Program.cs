using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = Console.ReadLine().Split().ToList();
            Dictionary<char, int> collection = new Dictionary<char, int>();
            string test = string.Join("", list1);
            char[] charr = test.ToCharArray();

            foreach (char c in charr)
            {
                if (collection.ContainsKey(c))
                {
                    collection[c] = collection[c] + 1;
                }
                else
                {
                    collection.Add(c, 1);
                }
            }

            foreach (var c in collection) 
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
