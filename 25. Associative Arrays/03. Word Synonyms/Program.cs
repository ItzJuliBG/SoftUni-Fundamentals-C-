using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();
            string firstInput;
            string secondInput;

            for (int i = 0; i < n; i++)
            {
                firstInput = Console.ReadLine();
                secondInput = Console.ReadLine();
                if (collection.ContainsKey(firstInput))
                {
                    collection[firstInput].Add(secondInput);
                }
                else
                {
                    List<string> temp = secondInput.Split().ToList();
                    collection.Add(firstInput, temp);
                }
            }

            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

            //    foreach (string s.Key in collection)
            //    {
            //        if (s == firstInput)
            //        {
            //            collection[s].Add(secondInput);
            //        }
            //        else
            //        {
            //            List<string> temp = secondInput.Split().ToList();
            //            collection.Add(firstInput, temp);
            //        }
            //    }
            //}
            //foreach (var s in collection.Keys) 
            //{
            //    Console.WriteLine($"{s} - ");
            //}
        }
    }
}
