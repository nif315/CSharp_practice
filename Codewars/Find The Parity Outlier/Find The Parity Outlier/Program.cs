using System;
using System.Collections.Generic;

namespace Find_The_Parity_Outlier
{
    class Program
    {
        public static int Find(int[] integers)
        {
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    evens.Add(integers[i]);
                }
                else
                {
                    odds.Add(integers[i]);
                }
            }
            if (odds.Count < evens.Count)
            {
                return int.Parse(string.Join("",odds));
            }
            else
            {
                return int.Parse(string.Join("",evens));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input array of only odd or only even numbers");
            int[] integers = new int[5];
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The only odd/even number is:" + Find(integers));
            Console.ReadKey();
        }
    }
}
