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

            //find the smallest number to the right of pivot
            List<int> right = new List<int>();
            for (int i = pivot; i < combo.Length; i++)
            {
                right.Add(combo[i]);
            }
            //List<int> right = n.ToString().ToList(combo.Length - pivot, combo.Length - pivot);
            int min = right.Min();
            Console.WriteLine(min);
            /*for (int i = 0; i < combo.Length; i++)
            {
                if (combo.Length = 1 || )
                {
                    return -1;
                }
            }*/
            return n;
            //code me
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
