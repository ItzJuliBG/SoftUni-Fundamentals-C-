using System;

namespace _01._The_Biscuit_Factory
{
    internal class Program
    {
        /*
         * per day(per worker)
         * count of workers
         * number of biscuits produced for 30 days
         * every third day workers produce only 75%
         * for each day only whole biscuits (lower number format)
         */
        static void Main(string[] args)
        {

            double biscuitsPerDayPerWorker = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double compatitorsProducionPerMonth = double.Parse(Console.ReadLine());
            double dailyBiscuitProducion = biscuitsPerDayPerWorker * workers;
            double biscuitsPerMonth = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    biscuitsPerMonth += Math.Floor(dailyBiscuitProducion * 0.75);
                }
                else
                {
                    biscuitsPerMonth += (Math.Floor(dailyBiscuitProducion));
                }
            }
            Console.WriteLine($"You have produced {biscuitsPerMonth} biscuits for the past month.");
            if(compatitorsProducionPerMonth>biscuitsPerMonth)
            {
                double percent = (compatitorsProducionPerMonth - biscuitsPerMonth)/compatitorsProducionPerMonth*100;
                Console.WriteLine($"You produce {percent:f2} percent less biscuits.");
            }
            else
            {
                double percent = (biscuitsPerMonth - compatitorsProducionPerMonth) / compatitorsProducionPerMonth * 100;
                Console.WriteLine($"You produce {percent:f2} percent more biscuits.");
            }
        } //  100/100
    }
}
