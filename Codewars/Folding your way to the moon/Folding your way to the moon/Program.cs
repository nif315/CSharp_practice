using System;

namespace Folding_your_way_to_the_moon
{
    class Program
    {
        static double ToTheMoon(double thickness, double distance)
        {
            int i = 0;
            while (thickness < distance)
            {
                thickness *= 2;
                i++;
            }
            return i;
        }
        static void Main(string[] args)
        {
            double thickness = 0.0001;
            Console.WriteLine("Paper's thickness is " + thickness + " meters");
            double distance = 384400000;
            Console.WriteLine("Distance to the moon is " + distance + " meters");
            Console.WriteLine("You will have to fold a piece of paper " + ToTheMoon(thickness, distance) + " times");
            Console.ReadKey();
        }
    }
}
