using System;
using System.Collections.Generic;

namespace Sort_the_odd
{
    class Program
    {
        public static int[] SortArray(int[] array)
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    odds.Add(array[i]);
                }
            }
            odds.Sort();
            int[] oddsArr = odds.ToArray();
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = oddsArr[j];
                    j++;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input array of numbers to sort:");
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine(string.Join(",", SortArray(array)));
            Console.ReadKey();
        }
    }
}
/*
You have an array of numbers.
Your task is to sort ascending odd numbers but even numbers must be on their places.

Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.

Example

sortArray([5, 3, 2, 8, 1, 4]) == [1, 3, 2, 8, 5, 4]
*/