using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Variation_on_Caesar_Cipher
{
    class Program
    {
        public static List<string> movingShift(string s, int shift)
        {
            var temp = 0;
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (shift >= 26)
                    shift = shift - 26;

                if (charArray[i] == ' ')
                {
                    shift++;
                    continue;
                }

                if (char.IsLetter(charArray[i]))
                {
                    temp = Convert.ToInt32(charArray[i]) + shift;
                    if (temp >= 123 && Convert.ToInt32(charArray[i]) > 97 || temp >= 91 && Convert.ToInt32(charArray[i]) <= 90)
                        temp = temp - 26;
                    charArray[i] = Convert.ToChar(temp);
                    shift++;
                }
            }
            List<string> str = new List<string>();
            for (int i=0;i<charArray.Length;i++)
            {
                str.Add(charArray[i].ToString());
            }
            return str;
        }

        public static string demovingShift(List<string> s, int shift)
        {
            //the same as with movingShift but demoving shift
            char[] demo
            return "";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input any string:");
            string s = Console.ReadLine();
            Console.WriteLine("Input, how many shifts to perform");
            int shift = int.Parse(Console.ReadLine());
            Console.WriteLine("Shifted string: " + string.Join("",movingShift(s, shift)));
            //Console.WriteLine("Demived shifting: " + demovingShift(s, shift));
            Console.ReadLine();
        }
    }
}
