using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n;
            Dictionary<string, List<double>> collection = new Dictionary<string, List<double>>();

            while((n = Console.ReadLine()) != "buy")
            {
                List<string> list = n.Split().ToList();

                string product = list[0];
                double price = double.Parse(list[1]);
                double quantity = double.Parse(list[2]);
              
                if(collection.ContainsKey(product))
                {
                    collection[product][0] = price;
                    collection[product][1] += quantity;
                }
                else
                {
                    collection.Add(product, new List<double>() { price, quantity });
                }
            }

            foreach (var item in collection)
            {
                double priceByQuantity = collection[item.Key][0] * collection[item.Key][1];
                Console.WriteLine($"{item.Key} -> {priceByQuantity:f2}");
            }
        }
    }
}
