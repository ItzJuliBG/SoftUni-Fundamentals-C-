using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n;
            Dictionary<string, int> collection = new Dictionary<string, int>();

            while((n = Console.ReadLine()) != "stop") 
            {
                string resource = n;
                int quantity = int.Parse(Console.ReadLine());
                if (collection.ContainsKey(resource))
                {
                    collection[resource] = collection[resource] + quantity;
                }
                else
                {
                    collection.Add(resource, quantity);
                }
            }

            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
