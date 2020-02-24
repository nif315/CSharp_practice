using System;

namespace Number_of_trailing_zeros_of_N_
{
    class Program
    {
        public static int TrailingZeros(int n)
        {
            int result = 0;
            while (n != 0)
            {
                result += n / 5;
                n /= 5;
            }
            return result;

            //slow algorhithm below
            /*Console.WriteLine(n);
            int count = 0;
            BigInteger factorial = 1;
            List<int> result = new List<int>();
            for (int i = 1; i <= n; i++)
                factorial *= i;

            for (int j = 0; j < factorial.ToString().Length; j++)
            {
                if (factorial.ToString()[j] != '0')
                {
                    count = 0;
                    continue;
                }

                if (factorial.ToString()[j] == '0')
                    count += 1;

                if (factorial.ToString()[factorial.ToString().Length-1] == '0')
                {
                    result.Add(count);
                }
            }
            if (result.Count != 0)
                return result.Max();
            return 0;*/
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input any number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeros(n));
            Console.ReadKey();
        }
    }
}
