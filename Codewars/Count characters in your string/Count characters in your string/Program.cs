using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_characters_in_your_string
{
    class Program
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> counted = new Dictionary<char, int>();
            if (String.IsNullOrEmpty(str))
                return null;
            char[] letters = str.ToCharArray();
            foreach(var item in letters.GroupBy(x=>x))
            {
                item.Count();
                counted.Add(item.First(), item.Count());
            }
            return counted;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
            string str = Console.ReadLine();
            Console.WriteLine(string.Join(",",Count(str)));
            Console.ReadKey();
        }
    }
}
