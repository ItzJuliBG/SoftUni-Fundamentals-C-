using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            double pricePerPerson = 0;
            if (day == "Friday")
            {
                if (type == "Students")
                {
                    pricePerPerson = 8.45;
                    totalPrice = 8.45 * peopleCount;
                }
                else if (type == "Business")
                {
                    pricePerPerson = 10.9;
                    totalPrice = 10.9 * peopleCount;
                }
                else if (type == "Regular")
                {
                    pricePerPerson = 15;
                    totalPrice = 15 * peopleCount;
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    pricePerPerson = 9.8;
                    totalPrice = 9.8 * peopleCount;
                }
                else if (type == "Business")
                {
                    pricePerPerson = 15.6;
                    totalPrice = 15.6 * peopleCount;
                }
                else if (type == "Regular")
                {
                    pricePerPerson = 20;
                    totalPrice = 20 * peopleCount;
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    pricePerPerson = 10.46;
                    totalPrice = 10.46 * peopleCount;
                }
                else if (type == "Business")
                {
                    pricePerPerson = 16;
                    totalPrice = 16 * peopleCount;
                }
                else if (type == "Regular")
                {
                    pricePerPerson = 22.5;
                    totalPrice = 22.5 * peopleCount;
                }
            }
            if (type == "Students" && peopleCount >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (type == "Business" && peopleCount >= 100)
            {
                totalPrice -= 10 * pricePerPerson;
            }
            else if (type == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
        //Friday Saturday Sunday
        //Students 8.45 9.80 10.46
        //Business 10.90 15.60 16
        //Regular 15 20 22.50
    }
}
