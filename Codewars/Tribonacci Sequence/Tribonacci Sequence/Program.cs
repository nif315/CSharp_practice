using System;
using System.Collections.Generic;
using System.Linq;

namespace Tribonacci_Sequence
{
    class Program
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            List<double> sequence = new List<double>();
            for (int i = 0; i < signature.Length; i++)
            {
                sequence.Add(signature[i]);
            }
            if (n == 0)
            {
                return new List<double>().ToArray();
            }
            else if (n <= 3 & n != 0)
            {
                return sequence.Take(n).ToArray();
            }
            else
            {
                double[] tribo = new double[n];
                tribo[0] = signature[0];
                tribo[1] = signature[1];
                tribo[2] = signature[2];
                for (int i = 3; i < n; i++)
                {
                    tribo[i] = tribo[i - 1] + tribo[i - 2] + tribo[i - 3];
                    sequence.Add(tribo[i]);
                }
                return sequence.ToArray();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input sequence's signature:");
            double[] signature = new double[3];
            for (int i = 0; i < signature.Length; i++)
            {
                signature[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input sequence's length:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tribonacci sequence is:" + string.Join(",", Tribonacci(signature, n)));
            Console.ReadKey();
        }
    }
}
