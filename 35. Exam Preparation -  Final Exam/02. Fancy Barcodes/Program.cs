using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        /*
6
@###Val1d1teM@###
        */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^@#+(?<token>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            string numPattern = @"[0-9]";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex rg = new Regex(input);
                Match mc = Regex.Match(input, pattern);
                if(mc.Success)
                {
                    var match2 = mc.Groups[1].Value;
                    StringBuilder savedBarcode = new StringBuilder();
                    Regex rg2 = new Regex(numPattern);
                    MatchCollection mc2Barcode = rg2.Matches(match2);
                    if (mc2Barcode.Count > 0)
                    {
                        foreach (Match m in mc2Barcode)
                        {
                            savedBarcode.Append(m);
                        }
                        Console.WriteLine($"Product group: {savedBarcode}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
               
            }
        }
    }
}
