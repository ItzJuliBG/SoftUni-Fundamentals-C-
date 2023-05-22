using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            int course = 0;

            //if(limit > people)
            //{
            //    Console.WriteLine("All the persons fit inside in the elevator.");
            //    Console.WriteLine("Only one course is needed.");

            //}
            //else
            //{

            //    }
            while (people > 0)
            {
                people -= limit;
                course++;


            }
            Console.WriteLine(course);
        }
    }
}
