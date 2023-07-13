using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string result = string.Empty;
            foreach (string s in list)
            {
                for (int i = 0; i < s.Count(); i++)
                {
                    result += s;
                }
            }
            Console.WriteLine(result);
        }
    }
}
