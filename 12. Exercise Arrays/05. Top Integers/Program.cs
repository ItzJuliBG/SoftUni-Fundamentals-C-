using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int j = 0;

            int[] topNums = new int[] { };
            for (int i = 0; i < input.Length; i++)
            {
                //if (i == j-1)
                //{
                //    break;
                //}
                j = i + 1;
                if (input[i] > input[j])
                {
                    // input[i] = topNums[i];
                }
            }
            Console.WriteLine(string.Join(" ", topNums));



        }
    }
}
