using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (IsPositive(list[i]) == false)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            if(IsEmpty(list) == true)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
        static bool IsPositive(int num)
        {
            if(num>0)
            {
                return true;
            }
            return false;
        }
        static bool IsEmpty(List<int> list)
        {
            if(list.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
