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

            int currentSeq = 1;
            int longestSeqCount = 0;
            int num = 0;


            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[1] == input[i + 1])
                {
                    currentSeq++;
                    if (currentSeq > longestSeqCount)
                    {
                        longestSeqCount = currentSeq;
                        num = input[i];
                    }

                }
                else
                {
                    currentSeq = 1;
                }
            }
            for (int  j= 0;  j<longestSeqCount-1; j++) 
            {
                Console.Write($"{num} ");
            }
        }

    }
}

