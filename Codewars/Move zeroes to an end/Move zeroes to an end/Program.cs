using System;
using System.Collections.Generic;
using System.Linq;

namespace Move_zeroes_to_an_end
{
    class Program
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> numbers = new List<int>();
            List<int> zeroes = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zeroes.Add(arr[i]);
                }
                else
                {
                    numbers.Add(arr[i]);
                }
            }
            var temp = numbers.Concat(zeroes);
            int[] result = temp.ToArray();
            return result;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[7];
            Console.WriteLine("Input integer array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",",MoveZeroes(arr)));
            Console.ReadKey();
        }
    }
}
