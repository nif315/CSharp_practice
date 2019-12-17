using System;

namespace valid_parentheses
{
    class Program
    {
        public static bool ValidParentheses(string input)
        {
            int length = input.Length / 2;

            repeat:
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input, i))
                {
                    input = input.Remove(i, 1);
                    goto repeat;
                }
            }
            Console.WriteLine(input);

            for (int i = 0; i < length; i++)
            {
                input = input.Replace("()", "");
            }

            if (string.IsNullOrEmpty(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input any string to check if parentheses are valid:");
            string input = Console.ReadLine();
            Console.WriteLine("Result is " + ValidParentheses(input));
            Console.ReadKey();
        }
    }
}
