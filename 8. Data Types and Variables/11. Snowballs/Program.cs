using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());
            BigInteger highestValueBall = 0;
            int snowSaved = 0;
            int timeSaved = 0;
            int qualitySaved = 0;
            for (int i = 0; i < snowballCount; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger tempNum = snow / time;

                BigInteger value = BigInteger.Pow(tempNum, quality);
                if (value > highestValueBall)
                {
                    highestValueBall = value;
                    snowSaved = snow;
                    timeSaved = time;
                    qualitySaved = quality;
                }
               
            }
            Console.WriteLine($"{snowSaved} : {timeSaved} = {highestValueBall} ({qualitySaved})");
        }
    }
}
