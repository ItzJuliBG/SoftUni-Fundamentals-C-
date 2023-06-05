using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());

            string[] people = new string[wagonCount];
            int sum = 0;
            for (int i = 0; i < wagonCount; i++)
            {
                people[i] = Console.ReadLine();
              //  sum += people[i];
            }
            foreach (var item in people)
            {
                Console.Write($"{item.ToString()} ");
            }
            Console.WriteLine();
           // Console.WriteLine(sum);
            //Console.WriteLine(string.Join(" ", people));
        }
    }
}
