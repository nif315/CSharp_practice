using System;

namespace Bit_calculator
{
    class Program
    {
        public static int Calculate(string num1, string num2)
        {
            int result = BinaryToInt(num1) + BinaryToInt(num2);
            return result;
        }

        private static int BinaryToInt(string number)
        {
            int val = 0;
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                val = Int32.Parse(number[i].ToString());
                if (val == 1)
                    result += (int)Math.Pow(2, number.Length - 1 - i);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input first number:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Input second number:");
            string num2 = Console.ReadLine();
            Console.WriteLine("The result is " + Calculate(num1, num2));
            Console.ReadKey();
        }

    }
}
/*
    namespace Extensions
    {
        using System;
        using Bit_calculator;

        public static class Extension
        {

           
        }
    }
}
*/
