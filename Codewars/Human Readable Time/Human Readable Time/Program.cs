using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Readable_Time
{
    class Program
    {
        public static string GetReadableTime(int seconds)
        {
            int minutes = (seconds - seconds % 60) / 60;
            int hours = (minutes - minutes % 60) / 60;

            if (seconds >= 60)
                seconds = seconds - (minutes * 60);

            if (minutes >= 60)
                minutes = minutes - (hours * 60);


            string secondsString = seconds.ToString();
            string minutesString = minutes.ToString();
            string hoursString = hours.ToString();

            if (seconds < 10)
                secondsString = seconds.ToString().Insert(0, "0");

            if (minutes < 10)
                minutesString = minutes.ToString().Insert(0, "0");

            if (hours < 10)
                hoursString = hours.ToString().Insert(0, "0");

            return hoursString + ":" + minutesString + ":" + secondsString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input time in seconds");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine(GetReadableTime(seconds));
            Console.ReadKey();
        }
    }
}
