using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        /*
         C:\Projects\Internal\Data-Structures\LinkedList.cs 
        */
        static void Main(string[] args)
        {
            char c = (char)92;
            string[] input = Console.ReadLine().Split(c).ToArray();
            int lastIndex = input.GetUpperBound(0);
            string[] nameToExt = input[lastIndex].Split(".", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string fileName = nameToExt[0];
            string fileExtension = nameToExt[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
