using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
           
          CharInRange(firstLetter, secondLetter);

           // Console.WriteLine(firstLetterIndex);
        }
        static void CharInRange(char firstLetter, char secondLetter)
        {
            int firstLetterIndex = (int)firstLetter;
            int secondLetterIndex = (int)secondLetter;

            if (firstLetterIndex > secondLetterIndex)
            {
                for (int i = secondLetterIndex+1; i < firstLetterIndex; i++)
                {
                    Console.Write(Convert.ToChar(i)+" ");
                }
            }
            else
            {
                for (int i = firstLetterIndex+1; i < secondLetterIndex; i++)
                {
                    Console.Write(Convert.ToChar(i)+" ");
                }

            }
            
        }
       
    }
}
