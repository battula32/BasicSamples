using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreviousQuarterTimeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeSpan = new TimeSpan(0, 15, 0);
            int hours = timeSpan.Hours;
            int mins = timeSpan.Minutes;
            int seconds = timeSpan.Seconds;
            int days = timeSpan.Days;


            //if (hours > 0)// && days == 0)
            //{
            //    hours = hours - 1;
            //}

            if (mins > 0 && hours == 0)
            {
                mins = DateTime.Now.Minute - ((int)(DateTime.Now.Minute / mins) * mins);
            }
            else
            {
                mins = DateTime.Now.Minute;
            }

            if (seconds > 0 && hours == 0)
            {
                seconds = DateTime.Now.Second - ((int)(DateTime.Now.Second / seconds) * seconds);
            }
            else
            {
                seconds = DateTime.Now.Second;
            }

            DateTime PreviusQuarter = DateTime.Now.Subtract(new TimeSpan(0, 0, mins, seconds));
            DateTime statTime = PreviusQuarter.Subtract(timeSpan);
            Console.WriteLine(PreviusQuarter.ToString());
            Console.Read();
        }
    }
}
