using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_numeric
{
    class Program
    {
        public static string Solution(int n)
        {
            int[] arabic = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string result = "";
            for (int i = 0; i < arabic.Length; i++)
            {
                while (arabic[i]<=n)
                {
                    result += roman[i];
                    n -= arabic[i];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution(n));
            Console.ReadKey();
        }
    }
}
