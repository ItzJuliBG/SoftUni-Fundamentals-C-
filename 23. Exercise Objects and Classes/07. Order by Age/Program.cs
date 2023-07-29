using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inpt;
            List<Database> list = new List<Database>();
            while ((inpt = Console.ReadLine()) != "End")
            {
                string[] input = inpt.Split(' ').ToArray();
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Database existingEntry = list.FirstOrDefault(item => item.Id == id);
                if (IsIdExisting(list, id))
                {
                    existingEntry.Name = name;
                    existingEntry.Age = age;
                }

                list.Add(new Database(name, id, age));
            }
            List<Database> sortedList = list.OrderBy(o => o.Age).ToList();

            // Print the sorted list
            sortedList.ForEach(entry => { Console.WriteLine($"{entry.Name} with ID: {entry.Id} is {entry.Age} years old."); });


        }
        /*
George 123456 20
wda 123456 20
Peter 78911 15
Stephen 524244 10
End
         */

        public class Database
        {
            public Database(string name, string id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }

            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
        }

        public static bool IsIdExisting(List<Database> list, string ID)
        {
            return list.Any(item => item.Id == ID);
        }
    }
}
