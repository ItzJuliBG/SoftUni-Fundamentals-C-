using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int odd = 0;
            int even = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even += nums[i];
                }
                else { odd += nums[i]; }
            }
            
            Console.WriteLine(even-odd);

            

        }
    }
}
