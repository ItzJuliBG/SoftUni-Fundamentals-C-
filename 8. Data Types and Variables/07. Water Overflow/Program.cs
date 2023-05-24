using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterNeed = 255;
            int entered;
            int filledWater = 0;

            for (int i = 0; i < n; i++)
            {
                entered = int.Parse(Console.ReadLine());

                if (entered > waterNeed)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterNeed -= entered;
                    filledWater += entered;

                }
            }

            Console.WriteLine(filledWater);
        }
    }
}
