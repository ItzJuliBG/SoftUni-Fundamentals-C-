using System;

namespace _09.__Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        //-26 on every day
        {
            double startingYield = double.Parse(Console.ReadLine());
            double currentYield = startingYield;
            double totalYieldCollected= 0;
            int days = 0;
            while (currentYield >= 100)
            {
                days++;
              
                totalYieldCollected += currentYield-26;

                currentYield -= 10;
            }
            totalYieldCollected -= 26;
            if (totalYieldCollected <0)
            {
                totalYieldCollected = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalYieldCollected);
        }
        //-26 from the result
    }
}
// 57/100