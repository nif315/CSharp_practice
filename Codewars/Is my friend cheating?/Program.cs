using System;
using System.Collections.Generic;
using System.Linq;

namespace Pascals_Diagonals
{
    class MainClass
    {
        public static List<long[]> removNb(long n)
        {
            long[] sequence = (Enumerable.Range(1, unchecked((int)n)).ToArray()).Select(item=>(long)item).ToArray();

            long sum = sequence.Sum();
            List<long[]> result = new List<long[]>();
            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (sequence[i] * sequence[j] == sum - sequence[i] - sequence[j])
                    {
                        result.Add(new long[] { sequence[i], sequence[j] });
                        result.Add(new long[] { sequence[j], sequence[i] });
                    }
                }
            }

            if (result.Any())
                return result;

            return new List<long[]>();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Input the sequence's length (n):");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("A and B are: " + string.Join(",", removNb(n)));
            Console.ReadKey();
        }
    }
}
