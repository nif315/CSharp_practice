using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static int CountBits(int n)
        {
            int count = 0;
            var binary = Convert.ToString(n, 2);
            foreach (char c in binary)
                if (c == '1') count++;
            n = count;
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество единиц в двоичном варианте числа");
            Console.WriteLine(CountBits(n));
            Console.ReadKey();
        }
    }
}
/*            Random random = new Random();

var stopwatch = Stopwatch.StartNew();
            

            for (int i = 0; i< 1000; i++)
            {
                n = random.Next();
                }

            stopwatch.Stop();
            Console.WriteLine("ElapsedTicks: " + stopwatch.ElapsedTicks);

            var stopwatch2 = Stopwatch.StartNew();
int counter2 = 0;

            for (int i = 0; i< 1000; i++)
            {
                n = random.Next();

                for (int j= 0; j< 32; j++)
                    if ((n & (1 << j)) > 0)
                        counter2++;
            }

            stopwatch2.Stop();
            Console.WriteLine("ElapsedTicks 2: " + stopwatch2.ElapsedTicks);
    static bool Temp(int a)
{
    int r = 1 << 5;  // 0000 0001 --> 0001 0000

    // r = 0001 0000
    // a = 0011 1010 --> 0001 0000

    return (a & r) > 0;
}*/