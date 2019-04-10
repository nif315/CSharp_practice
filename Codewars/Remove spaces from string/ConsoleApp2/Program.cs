using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static string NoSpace(string input)
        {
            input = input.Replace(" ", "");
            return input;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите инпут");
            string input = Console.ReadLine();
            Console.WriteLine("Результат");
            Console.WriteLine(NoSpace(input));
            Console.ReadKey();
        }
    }
}