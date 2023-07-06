using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lockedList = Console.ReadLine().Split().ToList();
            List<string> list = lockedList.ToList();

            foreach (string s in lockedList)
            {
                if (s.Length % 2 != 0)
                {
                    list.Remove(s);
                }
            }
            Console.WriteLine(string.Join("\r\n", list));
        }
    }
}
