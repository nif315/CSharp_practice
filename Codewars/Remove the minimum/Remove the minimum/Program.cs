using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_the_minimum
{
    class Program
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Count == 0)
                return new List<int>();
            numbers.Remove(numbers.Min());
            return numbers;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int[] numbersInput = new int[5];
            Console.WriteLine("Input numbers");
            for (int i = 0; i < numbersInput.Length; i++)
            {
                string str = Console.ReadLine();
                if (str == null || str.Length == 0)
                    continue;
                numbersInput[i] = int.Parse(str);
            }
            numbers.AddRange(numbersInput);
            Console.Clear();
            Console.WriteLine("Your numbers list:");
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine("New list with the smallest number removed:");
            Console.WriteLine(string.Join(",", RemoveSmallest(numbers)));
            Console.ReadKey();
        }
    }
}
