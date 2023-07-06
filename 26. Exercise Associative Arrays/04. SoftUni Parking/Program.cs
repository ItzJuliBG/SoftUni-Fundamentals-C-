using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> database = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string argument = input[0];
                string name = input[1];
                if (argument == "register")
                {
                    string plateNumber = input[2];
                    if (!database.ContainsKey(name))
                    {
                        database.Add(name, plateNumber);
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }

                else
                {
                    if (database.ContainsKey(name))
                    {
                        database.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }

            foreach (var t in database) 
            {
                Console.WriteLine($"{t.Key} => {t.Value}");
            }
        }
    }
}
