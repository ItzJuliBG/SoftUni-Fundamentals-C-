using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;  

            while (a != 24)
            {
                a += 2;
                

                Console.WriteLine($"  - {a:d2}-00");
            }
        }
    }
}
