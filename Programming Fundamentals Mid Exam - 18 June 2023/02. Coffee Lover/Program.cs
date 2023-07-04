using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    internal class Program
    {
        /*
Arabica Liberica Charrieriana Magnistipula Robusta BulkCoffee StrongCoffee
Include TurkishCoffee
Remove first 2
Remove last 1
Prefer 3 1
Reverse
         */
        static void Main(string[] args)
        {
            List<string> coffeeShelf = Console.ReadLine().Split().ToList();
  
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                List<string> input = Console.ReadLine().Split().ToList();
                switch (input[0])
                {
                    case "Include":
                        coffeeShelf.Add(input[1]);
                        break;
                    case "Remove":
                        if (int.Parse(input[2]) > coffeeShelf.Count) // check
                        {
                            continue;
                        }
                        else
                        {
                            switch (input[1])
                            {
                                case "first":
                                    for (int j = 0; j < int.Parse(input[2]); j++) //check 
                                    {
                                        coffeeShelf.RemoveAt(0);
                                    }
                                    break;
                                case "last":
                                    for (int j = 0; j < int.Parse(input[2]); j++) //check 
                                    {
                                        coffeeShelf.RemoveAt(coffeeShelf.Count - 1);
                                    }
                                    break;
                            }
                        }

                        break;
                    case "Prefer":
                        int index1 = int.Parse(input[1]);
                        int index2 = int.Parse(input[2]);
                        if (index1 <= coffeeShelf.Count-1 && index2 <= coffeeShelf.Count-1)//check
                        {
                            string temp = coffeeShelf[index1];
                            coffeeShelf[index1] = coffeeShelf[index2];
                            coffeeShelf[index2] = temp;
                        }
                        
                        break;
                    case "Reverse":
                        coffeeShelf.Reverse();
                        break;
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeeShelf));
        }
        // 100/100
    }
}
