using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Ad_Astra
{
    internal class Program
    {
        /*
#Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|
*/
        static void Main(string[] args)
        {
            string[] split = { "#", "|" };
            List<string> input = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(input[0]);
        }
    }
}
