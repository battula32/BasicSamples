using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DateTimeConverstions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            int hour = Microsoft.VisualBasic.DateAndTime.Hour(date);//Don't use visual basic date time
            Console.WriteLine(hour.ToString());
            Console.WriteLine(date.Hour);
            TimeSpan time = new TimeSpan(hour, 0, 0);
            Console.WriteLine(time.ToString());
            string str = "2010-06-07_PXP_RawMill_Day.csv";
            int l = str.IndexOf("_Pxp_ RawMill_Day", StringComparison.InvariantCultureIgnoreCase);
            //IFormatProvider culture = new CultureInfo("en-In
            DateTimeFormatInfo formt = new DateTimeFormatInfo();
            //formt.FullDateTimePattern = "dd-M-yyyy hh:mm:ss";
            IFormatProvider culture = new CultureInfo("en-IN", true);
            //culture.DateTimeFormat = formt;
            //CultureInfo.CurrentCulture.DateTimeFormat = formt;
            DateTime dt = DateTime.Parse("23-09-2011 01:55:00 PM", culture, DateTimeStyles.NoCurrentDateDefault);
            //new DateTime(
            //Console.WriteLine(dt.ToString(culture));
            IFormatProvider culture1 = new CultureInfo("en-US", false);
            string sr = dt.ToString(culture1);
            sr = dt.ToString("yyyy-M-dd hh:mm:ss");
            Console.Read();
        }
    }
}
