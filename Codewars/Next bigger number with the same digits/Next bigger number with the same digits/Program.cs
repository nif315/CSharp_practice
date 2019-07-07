using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_bigger_number_with_the_same_digits
{
    class Program
    {
        public static long NextBiggerNumber(long n)
        {
            var combo = n.ToString().ToArray();

            //find the pivot
            int pivot = 0;
            for (int i = combo.Length - 1; i > 0; i--)
            {
                if (combo[i] > combo[i - 1])
                {
                    pivot = i - 1;
                    Console.WriteLine(pivot);
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
            int min = Convert.ToInt32(Convert.ToString(n.ToString().Substring(pivot + 1).Min()));

            char swap;
            for (int i = 0; i < right.Length; i++)
            {
                if (right[i] == min)
                {
                    swap = right[0];
                    right[0] = Convert.ToChar(min);
                    right[i] = swap;

                }
            }
            return n;
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
