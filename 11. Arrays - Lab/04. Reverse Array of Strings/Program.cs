using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write((input[input.Length - 1 - i]) + " ");
            }
        }
    }
}
