using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> collection = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (collection.ContainsKey(name))
                {
                    collection[name].Add(grade);
                }
                else
                {
                    collection.Add(name, new List<double>() { grade });
                }
            }
            foreach (var item in collection) 
            {
                double t = (item.Value.Sum())/item.Value.Count;
                if (t >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {t:f2}");
                }
            }
        }
    }
}
