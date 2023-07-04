using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Student> students = new List<Student>();
            while((input = Console.ReadLine()) != "end") 
            {
                List<string> inputt = input.Split().ToList();
                

                students.Add(new Student(inputt[0], inputt[1], int.Parse(inputt[2]), inputt[3]));

            }
            string city = Console.ReadLine();

            foreach (Student s in students) 
            { 
                if(s.HomeTown == city)
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
