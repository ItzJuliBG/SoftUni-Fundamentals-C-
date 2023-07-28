using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] possibleRacers = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, double> racers = new Dictionary<string, double>();
            foreach (var item in possibleRacers)
            {
                racers.Add(item, 0);
            }
            string input;
            string pattern = @"[A-Za-z0-9]";
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder sb = new StringBuilder();
                double km = 0;
                Regex rg = new Regex(pattern);
                MatchCollection mc = rg.Matches(input);
                foreach (Match m in mc)
                {
                    var t = char.Parse(m.Value);
                    var isDigit = char.IsDigit(t);
                    var s = t.ToString();
                    if (isDigit)
                    {
                        km += double.Parse(s);/////////////
                    }
                    else
                    {
                        sb.Append(t);
                    }
                }
                if (racers.ContainsKey(sb.ToString()))
                {
                    racers[sb.ToString()] += km;
                }
            }
            racers = racers
               .OrderByDescending(x => x.Value)
               .ToDictionary(x => x.Key, y => y.Value);
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                counter++;
                switch (counter)
                {
                    case 1:
                        Console.WriteLine($"1st place: {racers.ElementAt(i).Key}");
                        break;
                    case 2:
                        Console.WriteLine($"2nd place: {racers.ElementAt(i).Key}");
                        break;
                        case 3:
                        Console.WriteLine($"3rd place: {racers.ElementAt(i).Key}");
                        break;
                }
            }
        }
    }
}
