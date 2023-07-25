using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        /*
Elvis Presley a a C C-Muhammad Ali EE PeterpeterJR-a a xi ban D D bb b b-B B-c c EE-Michael Jackson DD peter smith B B PETER BROWN IVAN DAVIES
        */
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<FullName>\b[A-Z][a-z]+ [A-Z][a-z]+)";

            Regex rg = new Regex(pattern);
            MatchCollection match = rg.Matches(input);

            foreach (Match m in match) 
            {
                Console.Write(m.Value+" ");
            }
        }
    }
}
