using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rot13
{
    class Program
    {
        public static string Rot13(string message)
        {
            List<int> tmp = new List<int>();
            List<string> result = new List<string>();
            foreach (char c in message)
            {
                tmp.Add(System.Convert.ToInt32(c));
            }

            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i] < 65 || tmp[i] > 122 || (tmp[i] > 90 && tmp[i] < 97))
                {
                    result.Add(char.ConvertFromUtf32(tmp[i]));
                }
                else
                {
                    tmp[i] += 13;
                    if (tmp[i] > 122 && tmp[i] > 96)
                    {
                        tmp[i] = 96 + (tmp[i] - 122);
                    }
                    else if (tmp[i] - 13 <= 90 && tmp[i] > 90)
                    {
                        tmp[i] = 64 + (tmp[i] - 90);
                    }
                    result.Add(char.ConvertFromUtf32(tmp[i]));
                }
            }
            return string.Join("", result);
        }

        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            Console.WriteLine($"Your message is \"{message}\"");
            Console.WriteLine(Rot13(message));
            Console.ReadKey();
        }
    }
}
