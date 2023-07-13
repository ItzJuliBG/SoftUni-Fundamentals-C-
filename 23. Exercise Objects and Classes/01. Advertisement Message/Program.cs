using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        class Info 
        {
            public Info(string phrases, string events, string authors, string cities)
            {
                Phrases = phrases;
                Events = events;
                Authors = authors;
                Cities = cities;
            }

            string Phrases { get; set; }
            
            string Events { get;set; }

            string Authors { get; set; }

            string Cities { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Info> info = new List<Info>();

            Info t = new Info("Excellent product.", "Now I feel good.", "Diana",);
        }
    }
}
