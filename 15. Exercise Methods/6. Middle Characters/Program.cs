using System;
using System.Linq;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inpt = Console.ReadLine();
            char[] input = inpt.Split("") ;

            if (inpt.Length %2 == 0 )
            {
                Console.Write(input[0]);
               // Console.Write(input[((inpt.Length - 1) / 2)+1]);
            }
        }
    }
}
