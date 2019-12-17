using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbling
{
    class Program
    {
        public static String Accum(string s)
        {
            string[] letters = s.ToLower().Select(x=>x.ToString()).ToArray();//string to string array
            for(int i = 0; i < s.Length ; i++)
            {
                letters[i] = letters[i].ToUpper() + String.Concat(Enumerable.Repeat(letters[i],i));
            }
            s = string.Join("-", letters);
            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input random string to perform mumbling:");
            string s = Console.ReadLine();
            Console.WriteLine(Accum(s));
            Console.ReadKey();
        }
    }
}
