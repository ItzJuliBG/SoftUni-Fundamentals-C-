using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> list = Console.ReadLine().Split(">").ToList();
            StringBuilder sb = new StringBuilder();
            sb.Append(list[0]);
            int explosion = 0;

            for (int i = 1; i < list.Count; i++)
            {
                char[] t = list[i].ToCharArray();
                explosion += int.Parse(t)-1;
                if (explosion > 0)
                {

                }
            }

        }
    }
}
