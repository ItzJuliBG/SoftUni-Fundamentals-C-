using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args) //not working rn
        {
            double availableMoney = double.Parse(Console.ReadLine());
            double studends = double.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltprice = double.Parse(Console.ReadLine());

            double needingMoney = 1.1 * (studends * (beltprice + robePrice + saberPrice));

            if (needingMoney >= availableMoney)
            {
                double need = needingMoney - availableMoney;
                Console.WriteLine($"John will need {needingMoney:f2}lv more.");
            }

            //            The amount of money John has – floating - point number in the range[0.00…1000.00].
            //• The count of students – integer in the range[0…100].
            //• The price of lightsabers for a single saber – floating - point number in the range[0.00…100.00].
            //• The price of robes for a single robe – floating - point number in the range[0.00…100.00].
            //• The price of belts for a single belt – floating - point number in the range[0.00…100.00].
        }
        //  Lightsabres sometimes break, so John should buy 10% more(taken from the students' count), r
        //Every sixth belt is free.
    }
}

