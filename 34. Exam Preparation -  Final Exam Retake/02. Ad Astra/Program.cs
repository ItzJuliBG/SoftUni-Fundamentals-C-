using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        /*
#Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|
*/
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"[\||\#](?<itemname>[\sA-Za-z]+)\1(?<expdate>[0-9]{2}/[0-9]{2}/[0-9]{2})\1(?<calories>[0-9]{0,10000})\1";
            double totalCalories = 0;

            Regex rg = new Regex(pattern);
            MatchCollection matches = rg.Matches(input);
            
            foreach (Match match in matches)
            {
                totalCalories += double.Parse(match.Groups["calories"].Value);
                
            }
            double totalDays = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {Math.Floor(totalDays)} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["itemname"].Value}, Best before: {match.Groups["expdate"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        } //\#(?<itemname>[\sA-Za-z]+)\#[0-9]{2}/[0-9]{2}/[0-9]{2}\#[0-9]{0,10000}\
          //\|(?<itemname>[\sA-Za-z]+)\|[0-9]{2}/[0-9]{2}/[0-9]{2}\|[0-9]{0,10000}\|

        //([\||\#])(?<itemname>[\sA-Za-z]+)\1(?<expdate>[0-9]{2}/[0-9]{2}/[0-9]{2})\1(?<calories>[0-9]{0,10000})\1
    } //87/100
}
