using System;
using System.Linq;


namespace ConsoleApp4
{
    class Program
    {
        public static string[] dirReduc(String[] arr)
        {
            int[] secondaryArr = new int[arr.Length];
            for (int j = 0; j < arr.Length; j++)
            {
                switch (arr[j])
                {
                    case "NORTH":
                        secondaryArr[j] = 1;
                        break;
                    case "SOUTH":
                        secondaryArr[j] = -1;
                        break;
                    case "WEST":
                        secondaryArr[j] = 2;
                        break;
                    case "EAST":
                        secondaryArr[j] = -2;
                        break;
                }
            }
            var directions = arr.ToList();
            restart:
            for (int i = 0; i < directions.Count - 1; i++)
            {
                for (int j = 0; j < secondaryArr.Length - 1; j++)
                {
                    if (secondaryArr[j] + secondaryArr[j + 1] == 0)
                    {
                        directions.RemoveRange(i, 2);
                        goto restart;
                    }
                }
            }
            arr = directions.ToArray();
            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input directions to go:");
            String[] arr = new String[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Optimised route is: " + string.Join(",", dirReduc(arr)));
            Console.ReadKey();
        }
    }
}

//придумать алгоритм с суммой, где север равен 1, юг -1, восток и запад 2 и -2 соответственно. если сумма равна нулю, то нужно удалять элементы массива