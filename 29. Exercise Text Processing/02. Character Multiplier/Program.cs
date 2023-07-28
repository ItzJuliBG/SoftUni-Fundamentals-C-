using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string firstString = input[0];
            string secondString = input[1];

            Console.WriteLine(CharMultiplier(firstString, secondString));
        }

        private static double CharMultiplier(string firstString, string secondString)
        {
            double totalSum = 0;
            char[] firstChars = firstString.ToCharArray();
            char[] secondChars = secondString.ToCharArray();

            int maxI = Math.Max(firstString.Length, secondString.Length);
            int minI = Math.Min(firstString.Length, secondString.Length);

            if (firstChars.Length == secondChars.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    totalSum += firstChars[i] * secondChars[i];
                }
            }
            else if (firstChars.Length == maxI)
            {
                for (int i = 0; i < minI; i++)
                {
                    totalSum += firstChars[i] * secondChars[i];
                }
                for (int i = minI; i < firstChars.Length; i++)
                {
                    totalSum += firstString[i];
                }
            }
            else
            {
                for (int i = 0; i < minI; i++)
                {
                    totalSum += firstChars[i] * secondChars[i];
                }
                for (int i = minI; i < secondChars.Length; i++)
                {
                    totalSum += secondString[i];
                }
            }
            return totalSum;


            /*
             P - 80
             e - 101
             t - 116
             e - 101
             r - 114

            G - 71 - P 5,680
            e - 101 - e 10201
            o - 111 - t 12,876
            r - 114 - e 11,514
            g - 71 - r 8,094
            e - 101
             */
        }
    }
}
