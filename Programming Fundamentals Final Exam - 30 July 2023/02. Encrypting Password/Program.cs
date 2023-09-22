using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string inpt;
            string pattern = @"(.+)>(?<numbers>[0-9]{3})\|(?<lowercase>[a-z]{3})\|(?<uppercase>[A-Z]{3})\|(?<symbols>[^<>]{3})<\1";

            for (int i = 0; i < n; i++)
            {
                inpt = Console.ReadLine();

                Regex rg = new Regex(pattern);
                Match mc = rg.Match(inpt);
                
                if(mc.Success)
                {
                    Console.Write($"Password: {mc.Groups["numbers"].Value}{mc.Groups["lowercase"].Value}{mc.Groups["uppercase"].Value}{mc.Groups["symbols"].Value}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
                //if(mc.Count == 0) 
                //{
                //    Console.WriteLine("Try another password!");
                //}
                //else
                //{
                //    foreach (Match item in mc)
                //    {
                //        Console.Write(); 
                //    }
                //}
            }
        }
    }
}
//([\W|_]*)>[0-9]+\|[a-z]+\|[A-Z]+\|([\W|_]*)<
