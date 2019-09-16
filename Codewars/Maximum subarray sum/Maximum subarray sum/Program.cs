using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_subarray_sum
{
    class Program
    {
        public static int MaxSequence(int[] arr)
        {
            Console.WriteLine(string.Join(",", arr));
            bool checkNegative = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    checkNegative = true;
                    continue;
                }
                else
                {
                    checkNegative = false;
                    break;
                }
            }
            if (checkNegative)
            {
                return 0;
            }

            int currentSum = 0;
            int maxSum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (maxSum < arr[i])
                    maxSum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (j == i + 1)
                        currentSum = arr[i];

                    currentSum += arr[j];

                    if (maxSum < currentSum)
                        maxSum = currentSum;
                }
            }
            return maxSum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input an array: ");
            int[] arr = new int[9];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(MaxSequence(arr));
            Console.ReadKey();
        }
    }
}
