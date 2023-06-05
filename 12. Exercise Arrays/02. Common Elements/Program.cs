using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");

            foreach (string a in secondArray)
            {
                foreach (string b in firstArray)
                {
                    if (a == b)
                    {
                        Console.Write($"{b} ");
                    }
                }
            }

        }
    }
}
