using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_this_a_triangle
{
    class Program
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a + b > c && b + c > a && a + c > b)
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
            Console.WriteLine("Input length of the side A");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input length of the side B");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input length of the side C");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine(IsTriangle(a, b, c));
            Console.ReadKey();
        }
    }
}
