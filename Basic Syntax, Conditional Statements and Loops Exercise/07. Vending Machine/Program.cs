using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            while (true)
            {
                string coinInput = Console.ReadLine();
                if (coinInput == "Start")
                {
                    break;
                }
                else
                {
                    sum += Double.Parse(coinInput);
                   
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
