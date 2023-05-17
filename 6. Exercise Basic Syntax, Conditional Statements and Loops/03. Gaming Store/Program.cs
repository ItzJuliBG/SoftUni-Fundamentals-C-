using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            bool check = false;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game Time")
                {
                    break;
                }
                switch (input)
                {
 

                    case "OutFall 4":
                        balance -= 39.99;
                        totalSpent += 39.99;
                        if (balance < 0)
                        {
                            Console.WriteLine("Too Expensive");
                            balance += 39.99;
                            totalSpent -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                        }

                        break;
                    case "CS: OG":
                        balance -= 15.99;
                        totalSpent += 15.99;
                        if (balance < 0)
                        {
                            Console.WriteLine("Too Expensive");
                            balance += 15.99;
                            totalSpent -= 15.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                        }

                        break;
                    case "Zplinter Zell":
                        balance -= 19.99;
                        totalSpent += 19.99;
                        if (balance < 0)
                        {
                            Console.WriteLine("Too Expensive");
                            balance += 19.99;
                            totalSpent -= 19.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                        }

                        break;
                    case "Honored 2":
                        balance -= 59.99;
                        totalSpent += 59.99;
                        if (balance < 0)
                        {
                            Console.WriteLine("Too Expensive");
                            balance += 59.99;
                            totalSpent -= 59.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                        }

                        break;
                    case "RoverWatch":
                        balance -= 29.99;
                        totalSpent += 29.99;
                        if (balance < 0)
                        {
                            Console.WriteLine("Too Expensive");
                            balance += 29.99;
                            totalSpent -= 29.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                        }

                        break;
                    case "RoverWatch Origins Edition":
                        balance -= 39.99;
                        totalSpent += 39.99;
                        if (balance < 0)
                        {
                            Console.WriteLine("Too Expensive");
                            balance += 39.99;
                            totalSpent -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                        }

                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;

                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    check = true;
                    break;
                }

                //OutFall 4 $39.99
                //CS: OG $15.99
                //Zplinter Zell $19.99
                //Honored 2 $59.99
                //RoverWatch $29.99

                //RoverWatch Origins Edition $39.99

                //Until you receive the command "Game Time", you have to keep buying games.When a game is bought, the user's
                //balance decreases by the price of the game.
                //    Additionally, the program should obey the following conditions:
                //• If a game the user is trying to buy is not present in the table above, print "Not Found" and read the next
                //line.
                //• If at any point, the user has $0 left, print "Out of money!" and end the program.
                //• Alternatively, if the user is trying to buy a game that they can't afford, print "Too Expensive" and read
                //the next line.
                //• If the game exists and the player has the money for it, print "Bought {nameOfGame}".
            }

            if (check == false)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
            }
            


        }
    }
}











