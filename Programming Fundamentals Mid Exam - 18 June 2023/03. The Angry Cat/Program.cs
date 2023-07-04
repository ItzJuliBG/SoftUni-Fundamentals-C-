using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int startingIndex = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = startingIndex + 1; i < numList.Count; i++) //may be numlist-1
            { //right
                if (itemType == "cheap")
                {
                    if (numList[i] < numList[startingIndex])
                    {
                        rightSum += numList[i];
                    }
                }
                else
                {
                    if (numList[i] >= numList[startingIndex])
                    {
                        rightSum += numList[i];
                    }
                }
            }

            for (int i = 0; i < startingIndex; i++) //may be numlist-1
            { //left
                if (itemType == "cheap")
                {
                    if (numList[i] < numList[startingIndex])
                    {
                        leftSum += numList[i];
                    }
                }
                else
                {
                    if (numList[i] >= numList[startingIndex])
                    {
                        leftSum += numList[i];
                    }
                }
            }
            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }

        }
    }
}
