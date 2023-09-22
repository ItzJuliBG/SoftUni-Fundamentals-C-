using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

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
            int a = 5;
            int b = a++;
            int c = ++a;
            Console.WriteLine(c);

        }

       
    }
    //>>[A-Za-z]+<<[0.9]+.[0.9]+![0,9]+|
}
