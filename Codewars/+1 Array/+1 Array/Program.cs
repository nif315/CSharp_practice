using System;
using System.Collections.Generic;

namespace _1_Array
{
    class Program
    {
        public static int[] UpArray(int[] num)
        {
            if (num == null || num.Length == 0)
                return null;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0 || num[i].ToString().Length > 1)
                    return null;
            }

            if (num[num.Length - 1] == 9)
            {
                int sum = int.Parse(string.Join("", num)) + 1;
                List<int> result = new List<int>();
                while (sum > 0)
                {
                    result.Add(sum % 10);
                    sum /= 10;
                }
                result.Reverse();
                return result.ToArray();
            }
            else
            {
                num[num.Length - 1] = num[num.Length - 1] + 1;
            }
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input array's length");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input numbers array to perform +1 func");
            int[] num = new int[n];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",", UpArray(num)));
            Console.ReadKey();
        }
    }
}
