using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            int nowNum = first;
            int sum = 0;
            while (nowNum <= last)
            {
                Console.Write($"{nowNum} ");
                sum += nowNum;
                nowNum++;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
