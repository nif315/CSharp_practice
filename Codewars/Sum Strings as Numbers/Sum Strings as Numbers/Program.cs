using System;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Sum_Strings_as_Numbers
{
    class Program
    {
        public static string sumStrings(string a, string b)
        {
            Regex check = new Regex("[0-9]");
            BigInteger sum = 0;
            {
                if (string.IsNullOrEmpty(a))
                    a = "0";
                if (string.IsNullOrEmpty(b))
                    b = "0";

                if (check.IsMatch(a) && check.IsMatch(b))
                {
                    BigInteger[] array = { BigInteger.Parse(a), BigInteger.Parse(b) };
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum = sum + array[i];
                    }
                }
                else
                {
                    return Convert.ToString(sum);
                }
            }
            string result = Convert.ToString(sum);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input first string");
            string a = Console.ReadLine();
            Console.WriteLine("Input the second string");
            string b = Console.ReadLine();
            Console.WriteLine(sumStrings(a, b));
            Console.ReadKey();
        }
    }
}
