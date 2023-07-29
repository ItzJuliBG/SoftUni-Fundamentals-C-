using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            string word = inp;
            string inpt;

            while ((inpt = Console.ReadLine()) != "Done")
            {
                List<string> input = inpt.Split().ToList();
                string argm = input[0];
                switch (argm)
                {
                    case "TakeOdd":
                        word = TakeOdd(word);
                        Console.WriteLine(word);
                        break;
                    case "Cut":
                        word = Cut(word, int.Parse(input[1]), int.Parse(input[2]));
                        Console.WriteLine(word);
                        break;
                    case "Substitute":
                        var cuttedWord = Substitute(word, input[1], input[2]);
                        if (cuttedWord == "Nothing to replace!")
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        else
                        {
                            word = cuttedWord;
                            Console.WriteLine(word);
                        }
                        break;
                }
            }
            Console.WriteLine($"Your password is: {word}");
        }
        private static string Substitute(string word, string substring, string substitute)
        {
            string newWord = word;
            if(!newWord.Contains(substring)) 
            {
                return "Nothing to replace!";
            }
            else
            {
                newWord = newWord.Replace(substring, substitute);
            }
            return newWord;
        }
        static string Cut(string word, int index, int length)
        {
            string newWord = word;
            newWord = newWord.Remove(index, length);
            return newWord;
        }
        static string TakeOdd(string word)
        {

            string new_string = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                    continue;
                new_string += word[i];
            }
            return new_string;
        }
    }
}
