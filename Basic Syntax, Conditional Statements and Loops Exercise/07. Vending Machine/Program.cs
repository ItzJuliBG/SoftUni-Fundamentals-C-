using System;
using System.Diagnostics;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            while (true) //• 0.1, 0.2, 0.5, 1 and 2
                         //"Cannot accept {money}"
            {
                string coinInput = Console.ReadLine();

                if (coinInput == "Start")
                {
                    break;
                }
                else if (coinInput == "0.1" || coinInput == "0.2" || coinInput == "0.5" || coinInput == "1" || coinInput == "2")
                {
                    sum += Double.Parse(coinInput);

                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinInput}");
                }

            }
            string productInput = string.Empty;
            while (true)
            {

                productInput = Console.ReadLine();
                if (productInput == "End")
                {
                    break;
                }
                switch (productInput)
                {
                    case "Nuts":
                        if (sum - 2 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        else
                        {
                            Console.WriteLine($"Purchased nuts");
                            sum -= 2;
                        }
                        break;
                    case "Water":
                        if (sum - 0.7 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        else
                        {
                            Console.WriteLine($"Purchased water");
                            sum -= 0.7;
                        }
                        break;
                    case "Crisps":
                        if (sum - 1.5 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        else
                        {
                            Console.WriteLine($"Purchased crisps");
                            sum -= 1.5;
                        }
                        break;
                    case "Soda":
                        if (sum - 0.8 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        else
                        {
                            Console.WriteLine($"Purchased soda");
                            sum -= 0.8;
                        }
                        break;
                    case "Coke":
                        if (sum - 1 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        else
                        {
                            Console.WriteLine($"Purchased coke");
                            sum -= 1;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                //• "Nuts" with a price of 2.0
                //• "Water" with a price of 0.7
                //• "Crisps" with a price of 1.5
                //• "Soda" with a price of 0.8
                //• "Coke" with a price of 1.0


            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}

