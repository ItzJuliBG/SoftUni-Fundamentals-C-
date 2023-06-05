using System;
using System.Linq;
using System.Security;
using System.Security.Cryptography;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currentNum = 0;
            int previousNum = input[0];
            int currentSeq = 0;
            int longestSeqCount = 0;


            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] == input[j])
                    {
                        currentSeq++;
                        if (currentSeq > longestSeqCount)
                        {
                            longestSeqCount = currentSeq;
                        }
                    }
                    else
                    {
                        currentSeq = 0;
                    }
                }
            }
            Console.WriteLine(longestSeqCount);
        }
    }
}
