using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int firstОperation = first + second;
            int secondOperation = firstОperation / third;
            int thirdOperation = secondOperation * fourth;
            Console.WriteLine(thirdOperation);
        }
    }
}
