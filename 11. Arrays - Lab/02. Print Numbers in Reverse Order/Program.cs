using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());

            int[] numbers = new int[numsCount];

            for (int i = 0; i < numsCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                numbers[i] = currentNum;
            }

            for (int i = 0; i < numsCount; i++)
            {
                Console.Write($"{numbers[numsCount-1-i]} ");
            }
        }
    }
}
