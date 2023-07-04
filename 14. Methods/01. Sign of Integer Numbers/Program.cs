using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            NumType(num);

        }
        static void NumType(int num)
        {
            if (num>0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if ( num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}
