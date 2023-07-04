using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Channels;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            bool[] fieldCells = new bool[fieldSize]; //maybe it can be fieldSize-1
            int[] ladybugsPlaces = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = string.Empty;
            //for (int s = 0; s <= ladybugsPlaces.Length; s++)
            //{

            //    fieldCells[ladybugsPlaces[s]] = true;
            //    //to be fixed
            //}

            fieldCells[0] = true;
            fieldCells[1] = true;


            while (true)
            {
                input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                input.ToArray();
                
                //int ladybugIndexPlaced = input[0];
                string direction = input[1].ToString();
                int moveNum = input[2];
                Console.WriteLine(direction);
                Console.WriteLine(moveNum);
                if (fieldCells[input[0]] = true)
                {
                    if (direction == "right") //
                    {
                        if (fieldCells[input[0] + input[2]] == false)
                        {
                            fieldCells[input[0]] = false;
                            fieldCells[input[0] + input[2]] = true;
                        }
                        else
                        {
                            while (fieldCells[input[0] + input[2]] != true)
                            {
                                input[2] = 2; //
                                if (fieldCells[input[0] + moveNum] == false)
                                {
                                    fieldCells[input[0]] = false;
                                    fieldCells[input[0] + moveNum] = true;
                                }
                            }
                            if (fieldCells[input[0] + moveNum] == false)
                            {
                                fieldCells[input[0]] = false;
                                fieldCells[input[0] + moveNum] = true;
                            }
                        }
                    }
                    if (fieldCells[input[0] + moveNum] == false) //idk if i need this if
                    {
                        fieldCells[input[0]] = false;
                        fieldCells[input[0] + moveNum] = true;
                    }
                    else
                    {
                        if (fieldCells[input[0] - moveNum] == false)
                        {
                            fieldCells[input[0]] = false;
                            fieldCells[input[0] - moveNum] = true;
                        }
                        else
                        {
                            while (fieldCells[input[0] - moveNum] != true)
                            {
                                moveNum *= 2;
                                if (fieldCells[input[0] - moveNum] == false)
                                {
                                    fieldCells[input[0]] = false;
                                    fieldCells[input[0] - moveNum] = true;
                                }
                            }
                            if (fieldCells[input[0] - moveNum] == false)
                            {
                                fieldCells[input[0]] = false;
                                fieldCells[input[0] - moveNum] = true;
                            }
                        }
                    } 
                }
            }

            for (int l = 0; l < fieldCells.Length; l++)
            {
                if (fieldCells[l] = true)
                {
                    Console.Write($"{'1'} ");
                }
                else
                {
                    Console.Write($"{'0'} ");
                }
            }
            //Console.WriteLine(string.Join(" ", fieldCells));
        }
    }
}
