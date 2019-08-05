using System;
using System.Collections.Generic;

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
            for (int i = 0; i < charArray.Length; i++)
            {
                str.Add(charArray[i].ToString());
            }
            return str;
        }

        //public static string demovingShift(List<string> s, int shift)
        public static string demovingShift(string s, int shift)
        {
            //the same as with movingShift but demoving shift
            var temp = 0;
            // List<string> str = s.ToList();
            char[] charArray = s.ToString().ToCharArray();
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
                    temp = Convert.ToInt32(charArray[i]) - shift;
                    if (temp <= 64 || temp <= 96 && Convert.ToInt32(charArray[i]) > 96)
                        temp = temp + 26;
                    charArray[i] = Convert.ToChar(temp);
                    shift++;
                }
            }
            List<string> demoved = new List<string>();
            for (int i = 0; i < charArray.Length; i++)
            {
                demoved.Add(charArray[i].ToString());
            }
            string result = string.Join("", demoved.ToArray());
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input any string:");
            string s = Console.ReadLine();
            Console.WriteLine("Input, how many shifts to perform");
            int shift = int.Parse(Console.ReadLine());
            Console.WriteLine("Shifted string: " + string.Join("", movingShift(s, shift)));
            Console.WriteLine("Demoved shifting: " + string.Join("", demovingShift(s, shift)));
            Console.ReadLine();
        }
    }
}
