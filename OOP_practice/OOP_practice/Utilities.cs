using System;

namespace OOP_practice
{
    //static class is equivalent to singleton design pattern
    static class Utilities
    {
         public static void ColorfulWriteline(string message, ConsoleColor color )
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
