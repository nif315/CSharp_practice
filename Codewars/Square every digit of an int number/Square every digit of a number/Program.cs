using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_every_digit_of_a_number
{
    class Program
    {
        public static int SquareDigits(int n)
        {
            var listArr = new List<int>();
            while (n > 0)
            {
                listArr.Add(n % 10);
                n /= 10;
            }
            listArr.Reverse();

            int[] array = listArr.ToArray();
            for (int i=0; i < array.Length; i++)
            {
                array[i] = array[i] * array[i];
            }
            Int32.TryParse(String.Join("", array), out n);
            return n;
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result of squaring evey digit is " + SquareDigits(n));
            Console.ReadKey();
        }
    }
}
