using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static bool isDivisible(long n, long x, long y, bool result)
        {
            if (n%x==0 && n%y==0)
            {
                Console.WriteLine("Is Divisible");
                result = true;
            }
            else
            {
                Console.WriteLine("Non Divisible");
                result = false;
            }
            return result;
        }
        static void Main(string[] args)
        {
            bool result = true;
            long n = long.Parse(Console.ReadLine());
            long x = long.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());
            Console.WriteLine(isDivisible(n,x,y,result));
            Console.ReadKey();
        }
    }
}
