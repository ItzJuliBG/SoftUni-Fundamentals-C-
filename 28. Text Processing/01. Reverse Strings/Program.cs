using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n;

            while ((n = Console.ReadLine()) != "end") 
            {
                char[] reversing = n.ToCharArray();
                Array.Reverse(reversing);
                string reversed = string.Join("", reversing);
                string result = n + " = " + reversed;
                
                Console.WriteLine(result);
            }
        }
    }
}
