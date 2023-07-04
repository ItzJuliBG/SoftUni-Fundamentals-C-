using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    internal class Program
    {

        /*
John Smith 15 Sofia
Peter Johnson 14 Plovdiv
Peter Johnson 25 Plovdiv
Linda Bridge 16 Sofia
Linda Bridge 27 Sofia
Simon Stone 12 Varna
end
Sofia

         */
        static void Main(string[] args)
        {
            string input;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> inputt = input.Split().ToList();

                int foundIndexOfRepeated = students.FindIndex(students => inputt[0] == students.FirstName && inputt[1] == students.LastName);

                Console.WriteLine(foundIndexOfRepeated);

                students.Add(new Student(inputt[0], inputt[1], int.Parse(inputt[2]), inputt[3]));

            }
            string city = Console.ReadLine();

            foreach (Student s in students)
            {
                if (s.HomeTown == city)
                {
                    Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old.");
                }

            }

        }

        public class Student
        {
            public Student(string firstName, string lastName, int age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string HomeTown { get; set; }
        }
    }
}