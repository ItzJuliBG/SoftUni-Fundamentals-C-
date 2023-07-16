using System;

namespace _03._Substring
{
    /*
ice
kicegiciceeb

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();

            string word = Console.ReadLine();

            bool isContaining = true;

            while (isContaining)
            {
                isContaining = word.Contains(remove);
                if (isContaining)
                {
                    int index = word.IndexOf(remove);
                    word = word.Remove(index, remove.Length);
                }
            }
            Console.WriteLine(word);
        }
    }
}
