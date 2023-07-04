using System;
using System.ComponentModel;
using System.Data;

namespace _04._Password_Validator
{
    internal class Program
    {

        //        • "Password must be between 6 and 10 characters"
        //• "Password must consist only of letters and digits"
        //• "Password must have at least 2 digits"

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();
            bool passwordLength = PasswordLength(input);
            bool lettersDigitsOnly = LettersDigitsOnly(input, inputArr);
            bool twoDigits = TwoDigits(input, inputArr);

            if (passwordLength == true && lettersDigitsOnly == true && twoDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (passwordLength == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (lettersDigitsOnly == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (twoDigits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        static bool LettersDigitsOnly(string input, char[] inputArr)
        {
            bool temp = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetterOrDigit(inputArr[i]) == false)
                {
                    temp = false;
                    break;
                }
            }
            return temp;

        }
        static bool PasswordLength(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool TwoDigits(string input, char[] inputArr)
        {
            int digits = 0;
            bool temp = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(inputArr[i]))
                {
                    digits++;
                    if (digits >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
