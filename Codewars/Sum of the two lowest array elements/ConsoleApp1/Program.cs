using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            int i;
            Random RandNum = new Random();
            Console.WriteLine("Массив значений");//вывод массива с рандомными значениями
            for (i = 0; i < array.Length; i++)
            {
                array[i] = RandNum.Next(1, 50);
                Console.Write(array[i] + ", ");
            }
            //сортировка массива
            Array.Sort(array);
            //Array.Reverse(array) - сортировка по убыванию
            Console.WriteLine();
            for (i = 0; i < array.Length; i++)//вывод отсортированного массива
            {
                Console.Write(array[i] + ",");
            }
            int sum = array[0] + array[1];
            Console.WriteLine();
            Console.WriteLine("Сумма = "+ sum);
            Console.WriteLine("Нажмите любую клавишу, чтобы выйти");
            Console.ReadKey();
        }
    }
}
