using System;
using System.Text.RegularExpressions;

namespace Base64_Encoding
{
    class Program
    {
        public static string ToBase64(string s)
        {
            if (Regex.IsMatch(s, "^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)?$"))// Base64 regular expression
            {
                return "Given string is in Base64 format";
            }
            else
            {
                var sEncoded = System.Text.Encoding.UTF8.GetBytes(s);
                return System.Convert.ToBase64String(sEncoded);
            }
        }

        public static string FromBase64(string s)
        {
            if (Regex.IsMatch(s, "^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)?$"))
            {
                var sDecoded = System.Convert.FromBase64String(s);
                return System.Text.Encoding.UTF8.GetString(sDecoded);
            }
            else
            {
                return "Given string is in UTF-8 format";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input string you want do decode:");
            string s = Console.ReadLine();
            Console.WriteLine("To Base64: " + ToBase64(s));
            Console.WriteLine("From Base64: " + FromBase64(s));
            Console.ReadKey();
        }
    }
}
