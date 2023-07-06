using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n;
            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();
            while((n = Console.ReadLine()) != "end")
            {
                List<string> input = n.Split(" : ").ToList();
                string course = input[0];
                string name = input[1];
                if (collection.ContainsKey(course))
                {
                    collection[course].Add(name);
                }
                else
                {
                    collection.Add(course, new List<string>() { name });
                }
            }
            foreach (var course in collection)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ",course.Value));
            }
        }
    }
}
