using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;

namespace Timespan
{
    delegate void DeleteTest(string message);

    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timespan = TimeSpan.FromMilliseconds(-1);
            Console.WriteLine("Time span is {0}", timespan.ToString());

            DateTime dtEpoch = new DateTime(1970, 01, 01, 0,0,0, DateTimeKind.Utc);
            DateTime dtCurrent = DateTime.UtcNow;

            TimeSpan ts = dtCurrent - dtEpoch;
            Console.WriteLine("Current timestmp: {0}, epochMilliseconds: {1}", dtCurrent, ts.TotalMilliseconds);
            string actTime = ConvertEpochMilliSecondsToDateTime(ts.TotalMilliseconds.ToString());
            Console.WriteLine(actTime);

            DateTime dtRef1 = new DateTime(1980, 01, 01, 0, 0, 0, DateTimeKind.Utc);
            ts = dtRef1 - dtEpoch;
            Console.WriteLine("Current timestmp: {0}, epochMilliseconds: {1}", dtRef1, ts.TotalMilliseconds);
            actTime = ConvertEpochMilliSecondsToDateTime(ts.TotalMilliseconds.ToString());
            Console.WriteLine(actTime);

            dtRef1 = new DateTime(2018, 08, 18, 18, 18, 18, DateTimeKind.Utc);
            ts = dtRef1 - dtEpoch;
            Console.WriteLine("Current timestmp: {0}, epochMilliseconds: {1}", dtRef1, ts.TotalMilliseconds);

            actTime = ConvertEpochMilliSecondsToDateTime(ts.TotalMilliseconds.ToString());
            Console.WriteLine(actTime);

            dtRef1 = new DateTime(2018, 12, 12, 9, 00, 0, DateTimeKind.Utc);
            ts = dtRef1 - dtEpoch;
            Console.WriteLine("Current timestmp: {0}, epochMilliseconds: {1}", dtRef1, ts.TotalMilliseconds);

            actTime = ConvertEpochMilliSecondsToDateTime(ts.TotalMilliseconds.ToString());
            Console.WriteLine(actTime);

            actTime = ConvertEpochMilliSecondsToDateTime("1544580000000");
            Console.WriteLine(actTime);

            //var temp = new Action(TestMethod);
            //var result = temp.BeginInvoke(null, null);
            DeleteTest dgTest = TestMethod;
            dgTest.BeginInvoke("Hello", null, null);
            Console.WriteLine("Invoke begin");
            //temp.EndInvoke(result);

            for(int i =0; i<100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }

            Console.Read();
        }

        private static void TestMethod(string message)
        {
            NewMethod(message);
            //Thread th1 = new Thread(() => NewMethod());
            //try
            //{
            //    th1.Start();
            //}
            //catch
            //{
            //    th1.Abort();
            //    Console.WriteLine("Thread aborted");
            //}
        }

        [OneWay]
        private static double NewMethod(string message)
        {
            int counter = 0;
            Console.WriteLine(message);
            while (true)
            {
                counter++;
                Console.WriteLine("counter :{0}", counter);
                int x = 0;
                int y = 10;
                Thread.Sleep(1000);
                if (counter > 20)
                {
                    return y / x;
                }
            }
        }

        private static string ConvertEpochMilliSecondsToDateTime(string time)
        {
            double epochMilliSeconds;
            if (double.TryParse(time, out epochMilliSeconds))
            {
                TimeSpan ts = TimeSpan.FromMilliseconds(epochMilliSeconds);
                DateTime dtEpoch = new DateTime(1970, 01, 01);
                DateTime actUtcTime = dtEpoch.Add(ts);
                TimeSpan utcOffSet = System.TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now);
                DateTime actLocalTime = actUtcTime.Add(utcOffSet);
                return actLocalTime.ToString("yyyy-MM-dd HH:mm:ss");
                ////"yyyy-MM-dd HH:mm:00"
            }

            return time;
        }
    }
}
