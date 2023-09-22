using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _01._Password_Validator
{
    internal class Program
    {
        /*
invalidpassword*
Add 2 p
Replace i -50
Replace * 10
Make Upper 2
Validation
Complete
         */
        static void Main(string[] args)
        {
            string inpt = Console.ReadLine();
            string password = inpt;

            while ((inpt = Console.ReadLine()) != "Complete") 
            {
                List<string> arg = inpt.Split().ToList();
                switch (arg[0])
                {
                    case "Make":
                        switch (arg[1])
                        {
                            case "Upper":
                                StringBuilder sb = new StringBuilder(password);
                                var t = sb[int.Parse(arg[2])];
                                sb[int.Parse(arg[2])] = char.ToUpper(t);
                                password = sb.ToString();
                                Console.WriteLine(password);
                                break;
                            case "Lower":
                                sb = new StringBuilder(password);
                                t = sb[int.Parse(arg[2])];
                                sb[int.Parse(arg[2])] = char.ToLower(t);
                                password = sb.ToString();
                                Console.WriteLine(password);
                                break;
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(arg[1]);
                        string charToInsert = arg[2];
                        if (password.Length > index) // may be > or without -1
                        {
                            password = password.Insert(index, charToInsert);
                            Console.WriteLine(password);
                        }
                        break;
                    case "Replace":
                        char currentCharValue = char.Parse(arg[1]); //
                        int addValue = int.Parse(arg[2]);
                        int temp = (int)Convert.ToChar(currentCharValue)+addValue;
                        char m = (char)temp;
                        password = password.Replace(currentCharValue, m);
                        Console.WriteLine(password);
                        break;
                    case "Validation":
                        if (password.Length < 8)
                        {
                            Console.WriteLine("Password must be at least 8 characters long!");
                        }
                        bool result = password.All(c => Char.IsLetterOrDigit(c) || c == '_'); //
                        if (!result)
                        {
                            Console.WriteLine("Password must consist only of letters, digits and _!");
                        }
                        result = password.Any(c => char.IsUpper(c));
                        if(!result)
                        {
                            Console.WriteLine("Password must consist at least one uppercase letter!");
                        }
                        result = password.Any(c => char.IsLower(c));
                        if(!result)
                        {
                            Console.WriteLine("Password must consist at least one lowercase letter!");
                        }
                        result = password.Any(c => char.IsDigit(c));
                        if (!result)
                        {
                            Console.WriteLine("Password must consist at least one digit!");
                        }
                        break;
                }
            }
        }
    }
}
