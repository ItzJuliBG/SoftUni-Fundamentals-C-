using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {

        /*
truck Man red 200
truck Mercedes blue 300
car Ford green 120
car Ferrari red 550
car Lamborghini orange 570
End
Ferrari
Ford
Man
Close the Catalogue

         */

        class Car
        {
            public Car(string type, string model, string color, decimal horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public decimal HorsePower { get; set; }
        }
        static void Main(string[] args)
        {
            string n;
            List<Car> cars = new List<Car>();
            while ((n = Console.ReadLine()) != "End") 
            {
                List<string> input = n.Split().ToList();
                string type = input[0];
                string model = input[1];
                string color = input[2];
                decimal horsePower = decimal.Parse(input[3]);
                cars.Add(new Car(type, model, color, horsePower));
            }
            decimal averageCarHP = 0;
            int truckCount = 0;
            decimal averageTruckHp = 0;
            int carCount = 0;
            while ((n = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Car car in cars)
                {
                    if (car.Type == "truck")
                    {
                        averageTruckHp += car.HorsePower;
                        truckCount++;
                    }
                    else
                    {
                        averageCarHP += car.HorsePower;
                        carCount++;
                    }
                    if (n == car.Model)
                    {
                        if (car.Type == "truck")
                        { 
                            Console.WriteLine($"Type: Truck");
                        }
                        else
                        {
                            Console.WriteLine($"Type: Car");
                        }

                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }

            }
            if (carCount != 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarHP / carCount:f2}.");
            }
            else { Console.WriteLine($"Cars have average horsepower of: 0."); }
            if(truckCount !=  0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp / truckCount:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.");
            }
            
            
        }
    }
}
