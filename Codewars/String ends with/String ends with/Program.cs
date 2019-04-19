using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_ends_with
{
    class Program
    {
        public static bool Solution(string str, string ending)
        { 
            if (str.EndsWith(ending))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool contains;
            Console.WriteLine("Input any word:");
            string str = Console.ReadLine();
            Console.WriteLine("Input word's ending");
            string ending = Console.ReadLine();
            Console.WriteLine(Solution(str,ending));
            Console.ReadKey();
        }
    }
}
