using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n;
            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();
            while ((n = Console.ReadLine()) != "End")
            {
                List<string> input = n.Split(" -> ").ToList();
                string company = input[0];
                string serialNumber = input[1];
                if (collection.ContainsKey(company))
                {
                    bool temp = true;
                    foreach(var item in collection[company])
                    {
                        if (item==serialNumber)
                        {
                            temp = false;
                        }
                    }
                    if (collection.ContainsKey(company))
                    {
                        if(temp == true)
                        {
                            collection[company].Add(serialNumber);
                        }
                    }
                }
                else
                {
                    collection.Add(input[0], new List<string>() { input[1] });
                }
            }
            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ", item.Value));
            }
        }
    }
}
