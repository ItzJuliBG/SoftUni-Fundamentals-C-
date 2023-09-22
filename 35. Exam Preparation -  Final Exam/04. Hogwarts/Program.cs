using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hogwarts
{
    internal class Program
    {
        /*
        A7ci0
        Illusion 1 c
        Illusion 4 o
        Abjuration
        Abracadabra
        */
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();
            string line;

            // Read the input until an empty line or "Abracadabra" is entered
            while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                if (line.Trim().ToLower() == "abracadabra")
                    break;

                inputs.Add(line);
            }

            string spell = inputs[0];

            for (int i = 1; i < inputs.Count; i++)
            {
                string inpt = inputs[i];
                List<string> arg = inpt.Split().ToList();

                switch (arg[0])
                {
                    case "Abjuration":
                        spell = spell.ToUpper();
                        break;
                    case "Necromancy":
                        spell = spell.ToLower();
                        Console.WriteLine(spell);
                        break;
                    case "Illusion":
                        int index = int.Parse(arg[1]);
                        char letter = char.Parse(arg[2]);
                        if (index > spell.Length - 1)
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        else
                        {
                            char[] charArray = spell.ToCharArray();
                            charArray[index] = letter;
                            spell = new string(charArray);
                            Console.WriteLine("Done!");
                        }
                        break;
                    case "Divination":
                        string firstSubstring = arg[1];
                        string secondSubstring = arg[2];

                        if (spell.Contains(firstSubstring))
                        {
                            spell = spell.Replace(firstSubstring, secondSubstring);
                            Console.WriteLine("Done!");
                        }
                        break;
                    case "Alteration":
                        string substring = arg[1];
                        if (spell.Contains(substring))
                        {
                            spell = spell.Replace(substring, "");
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("The spell did not work!");
                        }
                        break;
                }

            }
        }
    }
}
