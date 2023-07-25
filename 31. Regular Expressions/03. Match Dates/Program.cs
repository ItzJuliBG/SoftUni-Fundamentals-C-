using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?<day>\d{2})([-|.|\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            Regex rg = new Regex(pattern);
            MatchCollection matches = rg.Matches(input);

            foreach (Match match in matches) 
            {
                var day = match.Groups["day"];
                var month = match.Groups["month"];
                var year = match.Groups["year"];
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
