using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool done = false;
            for (int i = 0; i < input.Length - 1; i++)
            {

                int leftSum = 0;
                int rightSum = 0;
                for (int l = 0; l <= i - 1; l++)
                {
                    leftSum += input[l];
                }
                for (int r = input.Length - 1; r >= i + 1; r--)
                {
                    rightSum += input[r];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    done = true;
                    break;
                }
            }
            if (input.Length == 1) 
            {
                Console.WriteLine("0");
            }
            else if (done == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
