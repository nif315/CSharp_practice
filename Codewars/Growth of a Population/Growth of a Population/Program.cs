using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Growth_of_a_Population
{
    class Program
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int n = 0;
            do
            {
                p0 = p0 + (int)(p0 * (percent/100)) + aug;
                n++;
            }
            while (p0 < p);
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input town's population:");
            int p0 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input annual population's growth percentage");
            double percent = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input how many inhabitants coming or leaving each year");
            int aug = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input population to surpass");
            int p = Int32.Parse(Console.ReadLine());
            Console.WriteLine(NbYear(p0, percent, aug, p));
            Console.ReadKey();
        }
    }
}
/* EXAMPLE
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
In a small town the population is p0 = 1000 at the beginning of a year.                                                        |
The population regularly increases by 2 percent per year and moreover 50 new inhabitants per year come to live in the town.    |
How many years does the town need to see its population greater or equal to p = 1200 inhabitants?                              |
                                                                                                                               |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
At the end of the first year there will be:                                                                                    |
1000 + 1000 * 0.02 + 50 => 1070 inhabitants                                                                                    |
                                                                                                                               |
At the end of the 2nd year there will be:                                                                                      |
1070 + 1070 * 0.02 + 50 => 1141 inhabitants (number of inhabitants is an integer)                                              |
                                                                                                                               |
At the end of the 3rd year there will be:                                                                                      |
1141 + 1141 * 0.02 + 50 => 1213                                                                                                |
                                                                                                                               |
It will need 3 entire years.                                                                                                   |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
