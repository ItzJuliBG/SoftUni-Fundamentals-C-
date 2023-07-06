using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            SortedDictionary<int, int> output = new SortedDictionary<int, int>();

            foreach (int i in input)
            {
                bool result = output.ContainsKey(i);
                if (result == true)
                {
                    output[i] = output[i] + 1; //may be output find value and then value +1
                }
                else
                {
                    output.Add(i, 1);
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
