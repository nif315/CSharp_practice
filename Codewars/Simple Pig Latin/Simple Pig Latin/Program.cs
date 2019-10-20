using System;

namespace Simple_Pig_Latin
{
    class Program
    {
        public static string PigIt(string str)
        {
            string[] arr = str.Split(' ');
            string tmp;
            string firstLetter;
            for(int i=0;i<arr.Length;i++)
            {
                firstLetter = arr[i].Substring(0, 1);
                tmp = arr[i].Substring(1);
                tmp += firstLetter + "ay";
                arr[i] = tmp;
            }
            string result = string.Join(" ",arr);
            return result;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(PigIt(str));
            Console.ReadKey();
        }
    }
}
