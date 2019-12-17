using System;
using System.Collections.Generic;
using System.Linq;

namespace Counting_Duplicates
{
    class Program
    {
        public static int DuplicateCount(string str)
        {
            Dictionary<char, int> counted = new Dictionary<char, int>();
            char[] letters = str.ToLower().ToCharArray();
            foreach(var item in letters.GroupBy(x=>x))
            {
                if(item.Count()>1)
                    counted.Add(item.First(), item.Count());
            }
            return counted.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input any string");
            string str = Console.ReadLine();
            Console.WriteLine(DuplicateCount(str));
            Console.ReadKey();
        }
    }
}