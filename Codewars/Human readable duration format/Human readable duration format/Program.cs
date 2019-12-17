using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_readable_duration_format
{
    class Program
    {
        public static string formatDuration(int seconds)
        {
            int minutes = (seconds - seconds % 60) / 60;
            int hours = (minutes - minutes % 60) / 60;
            int days = (hours - hours % 24) / 24;
            int years = (days - days % 365) / 365;

            if (seconds == 0)
                return "now";

            if (seconds == 1)
                return seconds + " second";

            if (seconds < 60)
                return seconds + " seconds";

            if (seconds >= 60)
            {
                seconds = seconds - (minutes * 60);
            }

            if (minutes >= 60)
            {
                minutes = minutes - (hours * 60);
            }

            if (hours >= 24)
            {
                hours = hours - (days * 24);
            }

            if (days >= 365)
            {
                days = days - (years * 365);
            }

            List<string> sentence = new List<string>();
            string[] units = { " years", " days", " hours", " minutes", " seconds" };
            int[] unitsResult = { years, days, hours, minutes, seconds };

            for (int i = 0; i < unitsResult.Length; i++)
            {
                if (unitsResult[i] != 0)
                {
                    if (unitsResult[i] == 1)
                    {
                        sentence.Add(unitsResult[i].ToString() + units[i].Substring(0, units[i].Length - 1) + ", ");
                    }
                    else
                    {
                        sentence.Add(unitsResult[i].ToString() + units[i] + ", ");
                    }
                }
            }

            string and = "";
            if (sentence.Count > 1)
            {
                and = " and " + sentence.Last().Substring(0, sentence.Last().Length - 2); //remove comma
                sentence.RemoveAt(sentence.Count - 1);
            }


            for (int i = 0; i < sentence.Count; i++)//also removes last comma but from the list
            {
                if (i == sentence.Count - 1)
                {
                    sentence[i] = sentence[i].Substring(0, sentence[i].Length - 2);
                }
            }

            sentence.Add(and);

            string result = string.Join("", sentence);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input time is seconds:");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine("It's " + formatDuration(seconds));
            Console.ReadKey();
        }
    }
}
