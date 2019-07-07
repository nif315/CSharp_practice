using System;
using System.Collections.Generic;
using System.Linq;

namespace Next_bigger_number_with_the_same_digits
{
    class Program
    {
        public static long NextBiggerNumber(long n)
        {
            var combo = n.ToString().ToArray();

            //find the pivot
            int pivotNumber = 0;
            int pivot = 0;
            for (int i = combo.Length - 1; i > 0; i--)
            {
                if (combo[i] > combo[i - 1])
                {
                    pivot = i - 1;
                    pivotNumber = combo[pivot];
                    break;
                }
            }
            // if we are unable to find the pivot, skip
            if (pivot == -1)
                return -1;

            //splice the digits in the pivot and get the right side
            var right = n.ToString().Substring(pivot);

            //find the smallest number to the right of pivot
            //Converting to int, because .min() method returns in ASCII format
            int min = Convert.ToInt32(Convert.ToString(n.ToString().Substring(pivot + 1).Where(f => f > pivotNumber).Min()));

            int swap;
            List<int> swapMin = right.Select(x => Convert.ToInt32(x.ToString())).ToList();
            for (int i = 0; i < swapMin.Count; i++)
            {
                if (swapMin[i] == min)
                {
                    swap = swapMin[0];
                    swapMin[0] = min;
                    swapMin[i] = swap;

                }
            }

            List<int> sortedRight = new List<int>();
            for (int i = 1; i < swapMin.Count; i++)
            {
                sortedRight.Add(swapMin[i]);
            }
            sortedRight.Sort((a, b) => a.CompareTo(b));
            sortedRight.Insert(0, min);

            string left = n.ToString().Substring(0, pivot);
            string result = left + String.Join("", sortedRight);

            if (long.Parse(result) < n || long.Parse(result) == n)
             return -1;

            return long.Parse(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input number to get next bigger number:");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Next bigger number is:");
            //Console.WriteLine(string.Join(",", temp));
            Console.WriteLine(NextBiggerNumber(n));
            Console.ReadKey();
        }
    }
}
