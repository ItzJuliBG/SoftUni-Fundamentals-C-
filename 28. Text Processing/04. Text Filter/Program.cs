using System;
using System.Linq;
using System.Text;

namespace _04._Text_Filter
{
    internal class Program
    {
        /*
Linux, Windows
It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client
         */
        static void Main(string[] args)
        {
            //char[] splitOptions = { ' ', '-', '/', '!', '.', ',' };
            //string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine(Console.ReadLine());

            //foreach (var s in sb.ToString().Split(splitOptions))
            //{

            //    foreach (var bannedWord in bannedWords)
            //    {
            //        if(sb)
            //            {

            //        }

            //        if(bannedWord == s)
            //        {
            //            string ban = string.Empty;
            //            sb.Replace(bannedWord, new string ('*', bannedWord.Length));
            //        }
            //    }
            //}
            //Console.WriteLine(sb);

            string[] banWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
