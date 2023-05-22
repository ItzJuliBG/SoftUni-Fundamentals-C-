using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            char[] stringArray = t.ToCharArray();
            Array.Reverse(stringArray);
            string realpass = new string(stringArray);
            bool block = false;
            int blocked = 0;
            for (int i = 0; i < 4; i++)
            {

                string enter = Console.ReadLine();
                char[] stringArrayy = enter.ToCharArray();
                Array.Reverse(stringArrayy);
                string pass = new string(stringArrayy);
                if (enter == realpass)
                {

                    Console.WriteLine($"User {t} logged in.");
                    block = true;

                    break;
                }
                else if (blocked != 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    blocked++;
                }

            }
            if (block == false)
            {
                Console.WriteLine($"User {t} blocked!");
                //  break;
            }
        }
    }
}
