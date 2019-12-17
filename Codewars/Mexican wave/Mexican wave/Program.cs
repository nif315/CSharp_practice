using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexican_wave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any word to perform Mexican wave");
            string str = Console.ReadLine().ToLower();

            List<string> wave = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    continue;
                var array = str.ToCharArray();
                array[i] = Char.ToUpper(array[i]);
                wave.Add(new string(array));
            }
            Console.WriteLine(string.Join("-",wave));
            Console.ReadKey();
        }
    }
}
