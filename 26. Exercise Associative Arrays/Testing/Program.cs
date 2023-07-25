using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;

namespace Testing
{
    /*
owyouh
Move|2
Move|3
Insert|3|are
Insert|9|?
Decode

owyouh
youhow
howyou
howareyou
howareyou?


     */
    internal class Program
    {
        static void Main(string[] args)
        {
          string message = Console.ReadLine();
            List<char> mes =new List<char>();
            foreach (char c in message)
            {
                mes.Add(c);
            }
            string inpt = string.Empty;
            while((inpt=Console.ReadLine())!= "Decode")
            {
                List<string> input = inpt.Split('|').ToList();
                string cmd = input[0];
                
                switch (cmd)
                {
                    case"Move":
                        int n = int.Parse(input[1]);
                        for (int i = 0; i < n; i++)
                        {
                            char first = mes.First();
                            char last = mes.Last();
                            mes.RemoveAt(0);
                            mes.Add(first);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(input[1]);
                        string value = input[2];
                        foreach (char c in value)
                        {
                            mes.Insert(index, c);
                            index++;
                        }
                        break;
                    case "ChangeAll":
                        char substring = char.Parse(input[1]);
                        char replacement = char.Parse(input[2]);
                        //while (mes.Contains(substring))
                        //{

                        //}
                        mes = mes.ConvertAll(c => c == substring ? replacement : c);
                        break;
                }
               
            }
            StringBuilder output = new StringBuilder();
            mes.ForEach(t => { output.Append(t); });
            Console.WriteLine($"The decrypted message is: {output}");
        }
    }
}
