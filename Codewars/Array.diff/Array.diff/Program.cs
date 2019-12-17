using System;
using System.Collections.Generic;
using System.Linq;

namespace Array.diff
{
    class Program
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> arrayA = a.OfType<int>().ToList();
            List<int> arrayB = b.OfType<int>().ToList();
            arrayA = arrayA.Except(arrayB).ToList();//удаляем массив Б из массива А
            a = arrayA.ToArray();
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input array");
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input values to remove");
            int[] b = new int[1];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("New array with numbers removed");
            Console.WriteLine(string.Join(",", ArrayDiff(a, b)));
            Console.ReadKey();
        }
    }
}
