using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> song = new List<Song>(); 
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split("_").ToList();

                if(input.Count>1)
                {
                    song.Add(new Song(input[0], input[1], input[2]));
                }
            }
            string type = Console.ReadLine();
            foreach (Song item in song)
            {
                if (type == "all")
                {
                    Console.WriteLine(item.Name);
                }
                else if(item.TypeList==type)
                {
                    Console.WriteLine(item.Name);
                }
               
            }
            
        }
        public class Song 
        {
            public Song(string typeList, string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }

            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }
        }
    }
}
