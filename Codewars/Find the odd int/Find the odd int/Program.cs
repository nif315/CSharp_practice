using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_odd_int
{
    class Program
    {
        public static int find_it(int[] seq)
        {
            int count = 0;
            for(int i = 0; i < seq.Length; i++)
            {
                for(int j= 0; j < seq.Length - 1; j++)
                {
                    if (seq[i] == seq[j])
                    {
                        count++;
                        Console.WriteLine(seq[i]);
                    }
                }
                if(count%2 != 0)
                {
                    return seq[i];
                }
                else
                {
                    continue;
                }
            }
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Input sequence's length:");
            int length = int.Parse(Console.ReadLine());
            int[] seq = new int[length];
            for (int i = 0; i < seq.Length; i++)
                seq[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(find_it(seq));
            Console.ReadKey();
        }
    }
}
