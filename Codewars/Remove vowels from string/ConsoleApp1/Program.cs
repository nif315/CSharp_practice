using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string Disemvowel(string str)
        {
            //string vowels = "aeuio";
            //str = System.Text.RegularExpressions.Regex.Replace(vowels, "aeuio", "");
            //str = str.Replace(vowels, "");
            str = str.ToLower().Replace("a", "");
            str = str.ToLower().Replace("e", "");
            str = str.ToLower().Replace("u", "");
            str = str.ToLower().Replace("i", "");
            str = str.ToLower().Replace("o", "");
            return str;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(Disemvowel(str));
            Console.ReadKey();
        }
    }
}

/*
    string strNew = "";

            string[] strings = str.Split('a', 'u', 'e', 'i', 'o', 'A', 'U', 'E', 'I', 'O');

            foreach (var item in strings)
            {
                strNew += item;
            }
            
    return strNew;
*/