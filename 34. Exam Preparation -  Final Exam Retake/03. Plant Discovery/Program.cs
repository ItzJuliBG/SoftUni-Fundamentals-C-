using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        /*
3
Arnoldii<->4
Woodii<->7
Welwitschia<->2
Rate: Woodii - 10
Rate: Welwitschia - 7
Rate: Arnoldii - 3
Rate: Woodii - 5
Update: Woodii - 5
Reset: Arnoldii
Exhibition
*/
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          Dictionary<string, double> collectionRarity = new Dictionary<string,double>();
            Dictionary<string, double> collectionGrade = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split("<->").ToList();
                string plant = input[0];
                double rarity = double.Parse(input[1]);
                collectionRarity.Add(plant, rarity);


            }

            string t;
            while((t = Console.ReadLine()) != "Exhibition") 
            {
                string[] split = { ": ", " - " };
                List<string> rate = t.Split(split, StringSplitOptions.RemoveEmptyEntries).ToList();
                string arg = rate[0];
                switch (arg)
                {
                    case "Rate":

                        string plant = rate[1];
                        if(collectionRarity.ContainsKey(plant))
                        {
                            double grade = double.Parse(rate[2]);
                            if (collectionGrade.ContainsKey(plant))
                            {
                                collectionGrade[plant]+= grade;
                                collectionGrade[plant] /= 2;
                            }
                            else
                            {
                                collectionGrade.Add(plant, grade);
                            }
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                      
                        break;
                    case "Reset":
                        plant = rate[1];
                        if (collectionRarity.ContainsKey(plant))
                        {
                            collectionGrade[plant] = 0;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }


                        break;
                    case "Update":
                        plant = rate[1];
                        if (collectionRarity.ContainsKey(plant))
                        {
                            double newRarity = double.Parse(rate[2]);
                            collectionRarity[plant] = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        
                        
                        break;
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in collectionRarity)
            {
                //List<double> grades = collectionGrade.Values.SelectMany(x => x).ToList();
                //double rating = grades.Average();
                double rating = collectionGrade[item.Key];
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: {rating:f2}");
            }
        } //50/100
    }
}
