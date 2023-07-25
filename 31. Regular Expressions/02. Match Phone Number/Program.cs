using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359 2 [0-9]{3} [0-9]{4}|\+359-2-[0-9]{3}-[0-9]{4}";
            
            Regex rg = new Regex(pattern);
            MatchCollection matches = rg.Matches(input);

            //foreach (Match match in matches)
            //{
            //    Console.Write(match.Value+);
            //}
            string[] result = matches.Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
