using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Array_Elements
{
    class Program
    {
        public static Dictionary<string, int> Count(List<string> lst)
        {
            Dictionary<string, int> counted = new Dictionary<string, int>();
            foreach (var item in lst.GroupBy(x => x))
            {
                item.Count();
                counted.Add(item.First(),item.Count());
            }
            return counted;
        }

        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            string[] strArray = new string[5];
            Console.WriteLine("Input arrray values");
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = Console.ReadLine();
                lst.Add(strArray[i]);
            }
            Console.WriteLine(string.Join(",", (Count(lst))));
            Console.ReadKey();
        }
    }
}