using System;

namespace _06._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //still no success :/

            int number = int.Parse(Console.ReadLine());

            int CurrNumber = number;

            int sum = 1;

            int totalSum = 0;

            while (CurrNumber > 0)
            {
                int lastDigit = CurrNumber % 10;
                CurrNumber /= 10;

                sum = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    sum *= i;
                }
                totalSum += sum;

            }
            if (totalSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            //i just stole the code from github.com/koskata  :/
        }
    }
}
