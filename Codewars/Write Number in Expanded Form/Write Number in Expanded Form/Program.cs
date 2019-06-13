using System;
using System.Collections.Generic;

namespace Write_Number_in_Expanded_Form
{
    class Program
    {
        public static string ExpandedForm(long num)
        {
            string zeros = "";
            string digits = num.ToString();
            List<string> result = new List<string>();
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > 0)
                {
                    zeros = "";
                }
                for (int j = digits.Length - i - 1; j > 0; j--)//идем в обратном порядке и дописываем нолики
                {
                    zeros += "0";
                }
                result.Add(digits[i] + zeros);
            }
        repeat:
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].StartsWith("0"))
                {
                    result.RemoveAt(i);
                    goto repeat;
                }
            }
            return string.Join("+", result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input a number you want to expand:");
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(ExpandedForm(num));
            Console.ReadKey();
        }
    }
}
