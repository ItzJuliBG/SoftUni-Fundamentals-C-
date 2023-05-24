using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        //      • First – model – string
        //• Second –radius – floating-point number
        //• Third – height – integer number
        {
            int n = int.Parse(Console.ReadLine());

            string biggestKegName = string.Empty;
            double biggestKegVolume = Double.MinValue;

            for (int i = 0; i < n; i++)
            {
                string enterName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double heigth = double.Parse(Console.ReadLine());

                double currentKegVolume = Math.PI * Math.Pow(radius, 2) * heigth;
                if (currentKegVolume > biggestKegVolume)
                {
                    biggestKegVolume = currentKegVolume;
                    biggestKegName = enterName;
                }


            }
            Console.WriteLine(biggestKegName);
        }
        // π * r^2 * h
        

    }
}
