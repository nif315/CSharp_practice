using System;
using System.Linq;
using System.Collections.Generic;


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
            var numbersList = secondaryArr.ToList();
            repeat:
            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                if (numbersList[i] + numbersList[i + 1] == 0)
                {
                    numbersList.RemoveRange(i, 2);
                    goto repeat;
                }              
            }
            List<string> optimizedDirections = new List<string>();
            for (int i = 0; i < numbersList.Count; i++)
            {
                switch (numbersList[i])
                {
                    case 1:
                        optimizedDirections.Add("NORTH");
                        break;
                    case -1:
                        optimizedDirections.Add("SOUTH");
                        break;
                    case 2:
                        optimizedDirections.Add("WEST");
                        break;
                    case -2:
                        optimizedDirections.Add("EAST");
                        break;
                }
            }
            var result = optimizedDirections.ToArray();
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input directions to go:");
            String[] arr = new String[7];
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