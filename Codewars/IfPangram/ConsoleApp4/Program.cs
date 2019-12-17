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
            return str.ToLower().Where(ch => char.IsLetter(ch)).Distinct().Count() >= 26;
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
