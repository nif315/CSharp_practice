using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snail
{
    class Program
    {
        public static int[] Snail(int[][] array)
        {
            List<int> mixed = new List<int>();

            for (int i = 0; i < array[0].Length; i++)//first row
            {
                mixed.Add(array[0][i]);
            }

            for (int i = 1; i < array.Length; i++)//every last number of a row
            {
                mixed.Add(array[i][array[0].Length - 1]);
            }

            int heightIndex;
            if (array.Length <= 4)
            {
                heightIndex = 2;
            }
            else
            {
                heightIndex = 2 + (array.Length - 4);
            }

            for (int i = array.Length - heightIndex; i >= 0; i--)//lower row from right to left
            {
                mixed.Add(array[array.Length - 1][i]);
            }

            for (int i = array.Length - 2; i > 0; i--)//go up the left column
            {
                mixed.Add(array[i][0]);
            }

            int secondRowIndex;
            if (array.Length <= 4)
            {
                secondRowIndex = 1;
            }
            else
            {
                secondRowIndex = 1 + (array.Length - 4);
            }

            for (int i = 1; i < array.Length - secondRowIndex; i++)//начало закручивания по центру
            {
                mixed.Add(array[1][i]);
            }

            int lengthIndex;
            if (array.Length == 3)
            {
                lengthIndex = 1;
            }
            else
            {
                lengthIndex = (3 - array.Length) + 1;
            }
            Console.WriteLine(array.Length);
            Console.WriteLine(lengthIndex);

            for (int i = array.Length - 2; i > lengthIndex; i--)
            {
                mixed.Add(array[array.Length - 2][i]);
            }
            Console.WriteLine(string.Join("|", mixed));
            return mixed.ToArray();
        }

        static void Main(string[] args)
        {
            int[][] array = new int[3][];

            array[0] = new int[] { 1, 2, 3 };
            array[1] = new int[] { 8, 9, 4 };
            array[2] = new int[] { 7, 6, 5 };

            /*array[0] = new int[] { 1, 2, 3, 9 };
            array[1] = new int[] { 4, 5, 6, 4 };
            array[2] = new int[] { 7, 8, 9, 1 };
            array[3] = new int[] { 1, 2, 3, 4 };
            array[4] = new int[] { 5, 4, 3, 2 };*/

            Console.WriteLine(string.Join(",", Snail(array)));
            Console.ReadKey();
        }
    }
}
