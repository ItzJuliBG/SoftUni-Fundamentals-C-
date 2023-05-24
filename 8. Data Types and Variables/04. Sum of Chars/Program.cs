using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //char t = 'A';
            //int f = t;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char t = char.Parse(Console.ReadLine());
                int f = t;
                sum += f;
            }
            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
