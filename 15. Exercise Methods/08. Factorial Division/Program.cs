using System;
using System.Linq;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Factorial(first) / Factorial(second):f2}");
            int[] test = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(test.Sum());
        }
        static double Factorial(long number)
        {
            for (long i = number-1; i >= 1; i--) 
            {
                number *= i; 
            }
            return number;
            //return secondFactorial;
        }
    }
}
