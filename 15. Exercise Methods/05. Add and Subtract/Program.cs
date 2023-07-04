using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = FirstMethod(num1, num2);
            int result = SecondMethod(num3, sum);
            Console.WriteLine(result);
        }
        static int FirstMethod(int num1, int num2)
        {
            return num1 + num2;
        }
        static int SecondMethod(int num3, int sum) 
        {
            return sum - num3;
        }
    }
}
