using System;

namespace Pandemia
{
    class Program
    {
        public static double infected(string s)
        {
            string[] arr = s.Split('X');

            if (string.IsNullOrEmpty(string.Join("", arr)))
                return 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == '1')
                        arr[i] = arr[i].Replace('0', '1');
                }
            }

            string result = String.Join("",arr);
            int count = 0;
            for(int i = 0; i < result.Length; i++)
            {
                if (result[i] == '1')
                    count++;
            }
            return (double)count/(double)result.Length*100;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(infected(s));
            Console.ReadKey();
        }
    }
}
