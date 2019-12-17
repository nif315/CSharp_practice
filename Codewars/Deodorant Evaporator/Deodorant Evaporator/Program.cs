using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deodorant_Evaporator
{
    class Program
    {
        public static int evaporator(double content, double evap_per_day, double threshold)
        {
            int day = 0;
            threshold = content / 100 * threshold;
            while (content > threshold)
            {
                content = content - (content / 100 * evap_per_day);
                day++;
            }
            return day;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input content of evaporator in ml:");
            double content = double.Parse(Console.ReadLine());
            Console.WriteLine("Input in percents, how much gas es evaporating per day:");
            double evap_per_day = double.Parse(Console.ReadLine());
            Console.WriteLine("Input threshold in percentage beyond which the evaporator is no longer useful:");
            double threshold = double.Parse(Console.ReadLine());
            Console.WriteLine(evaporator(content, evap_per_day, threshold));
            Console.ReadKey();
        }
    }
}
