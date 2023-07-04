using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeRating(grade);
        }
        static void GradeRating (double rating) 
        {
            if(rating <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (rating >= 3 && rating <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (rating >= 3.5 && rating <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (rating >= 4.5 && rating <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
