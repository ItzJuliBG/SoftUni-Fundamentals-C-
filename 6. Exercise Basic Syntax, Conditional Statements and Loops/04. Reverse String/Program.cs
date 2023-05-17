using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

         //   string reversedInput = Array.Reverse(input);
          //  Console.WriteLine(input);
            char[] reversedInput = input.ToCharArray();
            Array.Reverse(reversedInput);
            Console.WriteLine(reversedInput);
        }
    }
}
