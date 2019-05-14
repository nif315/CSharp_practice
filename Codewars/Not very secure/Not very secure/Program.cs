using System;
using System.Linq;

namespace Not_very_secure
{
    class Program
    {
        public static bool Alphanumeric(string str)
        {
            if (str.All(Char.IsLetterOrDigit) && str.Length > 0)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input any alphanumeric string:");
            string str = Console.ReadLine();
            Console.WriteLine(Alphanumeric(str));
            Console.ReadKey();
        }
    }
}
