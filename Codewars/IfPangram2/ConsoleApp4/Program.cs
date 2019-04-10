using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    class Program
    {
        public static bool IsPangram(string str)
        {
            var symbols = new HashSet<char>("QWERTYUIOPASDFGHJKLZXCVBNM");
            foreach (char c in str)
            {
                if (symbols.Remove(char.ToUpper(c)) && symbols.Count == 0)
                {
                    return true;
                }
            }
            return false;
        }
    static void Main(string[] args)
        {
            Console.WriteLine("Введите текст н английском");
            string str = Console.ReadLine();
            Console.WriteLine(IsPangram(str));
            Console.ReadKey();
        }
    }
}
