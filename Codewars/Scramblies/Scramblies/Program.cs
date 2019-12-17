using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scramblies
{
    class Program
    {
        public static bool Scramble(string str1, string str2)
        {
            if (str2.Length > str1.Length)
                return false;

            var string1 = str1.OrderBy(c => c).ToArray();
            var string2 = str2.OrderBy(c => c).ToArray();
            int count = 0;
            //compare all elements of all elements by using additional int value "count"
            for (int i = 0; i < string1.Length && count < string2.Length; i++)
            {
                if (string1[i] == string2[count])
                    count++;
                Console.WriteLine(count);
            }

            if (count == string2.Length)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input first srting:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Input second string:");
            string str2 = Console.ReadLine();
            Console.WriteLine(Scramble(str1, str2));
            Console.ReadKey();
        }
    }
}
