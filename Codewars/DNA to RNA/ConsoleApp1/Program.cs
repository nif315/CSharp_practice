using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MyOwnStringExtensions
    {
        public static bool ContainsAnyCase(this string stroka, char symbol)
        {
            return stroka.IndexOf(symbol.ToString(), StringComparison.CurrentCultureIgnoreCase) != -1;
        }

        public static bool ContainsAnyCase(this string stroka, string symbol)
        {
            return stroka.IndexOf(symbol, StringComparison.CurrentCultureIgnoreCase) != -1;
        }

        public static bool ContainsAnyCase(this string stroka, params char[] symbols)
        {
            // Входят ли все символы и массива:
            // bool containsResult = true;
            // 
            // foreach (var item in symbols)
            //     containsResult &= stroka.ContainsAnyCase(item);

            // -------------------------------------------------
            // Входят ли хотябы один символ из массива:
            // bool containsResult = false;
            // 
            // foreach (var item in symbols)
            //     containsResult |= stroka.ContainsAnyCase(item);  // containsResult = containsResult || stroka.ContainsAnyCase(item);
            bool containsResult = true;
            foreach (var item in symbols)
            containsResult &= stroka.ContainsAnyCase(item);
            return containsResult;
        }
    }
    class Program
    {
        public static string dnaToRna(string dna)
        {
            return dna.Replace("T", "U");
        }


        static void Main(string[] args)
        {
            string dna = Console.ReadLine().ToUpper(); 
            if (dna.Length > 4 || dna.ContainsAnyCase("") || dna.Length < 4)
            {
                Console.WriteLine("Your input string is wrong, try again");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(dnaToRna(dna));
                Console.ReadKey();
            }
        }
    }
}