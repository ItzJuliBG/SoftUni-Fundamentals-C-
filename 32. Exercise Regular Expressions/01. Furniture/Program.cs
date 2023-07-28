using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    /*
>>Chair<<412.23!3
>>Sofa<<500!5
>>Recliner<<<<!5
>>Bench<<230!10
>>>>>>Rocking chair<<!5
>>Bed<<700!5
Purchase
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string pattern = @">>\b(?<furniture>[A-Za-z]+)<<(?<price>[0-9]+.[0-9]+)!(?<quantity>[0-9]+)|>>[A-Za-z]+<<[0-9]+![0-9]+";
            double totalSpent = 0;
            Console.WriteLine("Bought furniture:");
            while ((input = Console.ReadLine()) != "Purchase") 
            {
                Regex rg = new Regex(pattern);
                MatchCollection matchCollection = rg.Matches(input);
                foreach (Match match in matchCollection)
                {
                    double price = double.Parse(match.Groups[2].Value);
                    double quantity = double.Parse(match.Groups[3].Value);
                    totalSpent += price*quantity;
                    Console.WriteLine(match.Groups[1].Value);
                }
            }
            Console.WriteLine($"Total money spend: {totalSpent:f2}");
        }
    }
    //>>[A-Za-z]+<<[0.9]+.[0.9]+![0,9]+|
}
