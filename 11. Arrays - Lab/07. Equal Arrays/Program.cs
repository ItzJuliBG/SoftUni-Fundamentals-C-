using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int differences = 0;
            int sum = 0;

            for (int i = 0; i < firstInput.Length; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    sum += firstInput[i];
                }
                else
                {
                    differences++;
                }
            }
            if (differences ==0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differences} index");
            }
        } //  50/100
    }
}
