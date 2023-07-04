using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int j = 0;

            //int[] topNums = new int[] { };
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length-1)
                {
                    Console.Write(input[i]);
                    break;
                }
                if (input[i] > input[i + 1])
                {
                    Console.Write(input[i]+" ");
                }
              
            }
          //  Console.WriteLine(string.Join(" ", topNums));



        }
    }
}
