using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_mix
{
    class Program
    {
        public static string Mix(string s1, string s2)
        {
            List<char> string1 = new List<char>();
            List<char> string2 = new List<char>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (char.IsLower(s1[i]) && char.IsWhiteSpace(s1[i]) != true && char.IsLetter(s1[i]))
                    string1.Add(s1[i]);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (char.IsLower(s2[i]) && char.IsWhiteSpace(s2[i]) != true && char.IsLetter(s2[i]))
                    string2.Add(s2[i]);
            }
            string1 = string1.OrderBy(x => x).ToList();
            string2 = string2.OrderBy(x => x).ToList();

            int count = 0;
            List<char> nonRptChrsRmvd1 = new List<char>();
            for (int i = 0; i < string1.Count; i++)
            {
                for (int j = 0; j < string1.Count; j++)
                {
                    if (string1[i] == string1[j])
                        count++;
                }

                if (count > 1)
                    nonRptChrsRmvd1.Add(string1[i]);

                count = 0;
            }

            List<char> nonRptChrsRmvd2 = new List<char>();
            for (int i = 0; i < string2.Count; i++)
            {
                for (int j = 0; j < string2.Count; j++)
                {
                    if (string2[i] == string2[j])
                        count++;
                }

                if (count > 1)
                    nonRptChrsRmvd2.Add(string2[i]);

                count = 0;
            }


            int different = 1;
            for (int i = 0; i < nonRptChrsRmvd1.Count; i++)
            {
                if (i > 1 && nonRptChrsRmvd1[i] != nonRptChrsRmvd1[i - 1])
                    different++;
            }
            Console.WriteLine("ada"+different);
            string[] mix = new string[different];


            for (int j = 0; j < mix.Length; j++)
            {
                for (int i = 0; i < nonRptChrsRmvd1.Count; i++)
                {
                    mix[j] += nonRptChrsRmvd1[i];

                    if (i < (nonRptChrsRmvd1.Count - 1) && nonRptChrsRmvd1[i] != nonRptChrsRmvd1[i + 1])
                        j++;
                }
            }

            List<string> readyToMix1 = new List<string>();
            for (int i = 0; i < nonRptChrsRmvd1.Count; i++)
            {
                if (i == 0)
                {
                    readyToMix1.Add("1:" + nonRptChrsRmvd1[i]);
                }
                else if (i > 1 && nonRptChrsRmvd1[i] != nonRptChrsRmvd1[i - 1])
                {
                    readyToMix1.Add("/1:" + nonRptChrsRmvd1[i]);
                }
                else if (i == nonRptChrsRmvd1.Count - 1)
                {
                    readyToMix1.Add(nonRptChrsRmvd1[i] + "/");
                }
                else
                {
                    readyToMix1.Add(nonRptChrsRmvd1[i].ToString());
                }
            }

            List<string> readyToMix2 = new List<string>();
            for (int i = 0; i < nonRptChrsRmvd2.Count; i++)
            {
                if (i == 0)
                {
                    readyToMix2.Add("2:" + nonRptChrsRmvd2[i]);
                }
                else if (i > 1 && nonRptChrsRmvd2[i] != nonRptChrsRmvd2[i - 1])
                {
                    readyToMix2.Add("/2:" + nonRptChrsRmvd2[i]);
                }
                else if (i == nonRptChrsRmvd2.Count - 1)
                {
                    readyToMix2.Add(nonRptChrsRmvd2[i] + "/");
                }
                else
                {
                    readyToMix2.Add(nonRptChrsRmvd2[i].ToString());
                }
            }
            string mixed = string.Join("", readyToMix1) + string.Join("", readyToMix2);
            return mixed;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input first string: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Input second string: ");
            String s2 = Console.ReadLine();
            Console.WriteLine(Mix(s1, s2));
            Console.ReadKey();
        }
    }
}
