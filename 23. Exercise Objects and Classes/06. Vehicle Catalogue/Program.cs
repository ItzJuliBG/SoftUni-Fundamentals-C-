using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {

        /*
truck Man red 200
truck Mercedes blue 300
car Ford green 120
car Ferrari red 550
car Lamborghini orange 570
End
Ferrari
Ford
Man
Close the Catalogue

         */
        
        static void Main(string[] args)
        {
            string n;

            while ((n = Console.ReadLine()) != "end")
            {
                List<string> input = n.Split().ToList();
                double firstNum = double.Parse(input[0]);
                char action = char.Parse(input[1]);
                double secondNum = double.Parse(input[2]);

                double firstActionSecond = 0;

                if (action == '-')
                {
                    firstActionSecond = firstNum - secondNum;
                }
                else if (action =='+')
                {
                    firstActionSecond = firstNum+ secondNum;
                }
                else if (action ==  '*') 
                {
                    firstActionSecond = firstNum*secondNum;
                }
                else if (action ==  '/')
                {
                    firstActionSecond= firstNum/secondNum;

                }
                else if (action == '%')
                {
                    firstActionSecond = (secondNum * firstNum) / 100;
                }
                else if (action == '^')
                {
                    firstActionSecond = Math.Pow(firstNum, secondNum);
                }

                Console.WriteLine($"{firstNum} {action} {secondNum} = {firstActionSecond} ");
            }
        }
    }
}
