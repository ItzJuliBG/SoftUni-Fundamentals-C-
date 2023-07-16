using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            List<string> validUsers = new List<string>();

            foreach (string name in input)
            {
                if (name.Count() >= 3 && name.Count() <= 16)
                {
                    bool m = true;
                    foreach (char c in name)
                    {
                        if (!(char.IsLetterOrDigit(c) || c == '-' || c == '_'))
                        {
                            m = false;
                        }
                    }
                    if (m)
                    {
                        validUsers.Add(name);
                    }
                }
            }
            foreach (string t in validUsers)
            {
                Console.WriteLine(t);
            }
        }
    }
}
