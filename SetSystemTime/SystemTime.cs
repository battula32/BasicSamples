using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace SetSystemTime
{
    class SystemTime
    {
        /// <summary>
        /// SYSTEMTIME structure with some useful methods
        /// </summary>
        private struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;

            /// <summary>
            /// Convert form System.DateTime
            /// </summary>
            /// <param name="time"></param>
            public void FromDateTime(DateTime time)
            {
                wYear = (ushort)time.Year;
                wMonth = (ushort)time.Month;
                wDayOfWeek = (ushort)time.DayOfWeek;
                wDay = (ushort)time.Day;
                wHour = (ushort)time.Hour;
                wMinute = (ushort)time.Minute;
                wSecond = (ushort)time.Second;
                wMilliseconds = (ushort)time.Millisecond;
            }

            /// <summary>
            /// Convert to System.DateTime
            /// </summary>
            /// <returns></returns>
            private DateTime ToDateTime()
            {
                return new DateTime(wYear, wMonth, wDay, wHour, wMinute, wSecond, wMilliseconds);
            }
            /// <summary>
            /// STATIC: Convert to System.DateTime
            /// </summary>
            /// <param name="time"></param>
            /// <returns></returns>
            private static DateTime ToDateTime(SYSTEMTIME time)
            {
                return time.ToDateTime();
            }
        }

        [DllImport("kernel32.dll")]
        static extern bool SetLocalTime([In] ref SYSTEMTIME lpLocalTime);
         //Example
        private void Add7Days()
        {
            //Get current time and add 7 days to it
            DateTime t = DateTime.Now.AddDays(7);;
            //Convert to SYSTEMTIME
            SYSTEMTIME st = new SYSTEMTIME();
            st.FromDateTime(t);
            //Call Win32 API to set time
            SetLocalTime(ref st);
        }

        public void SetSystemTime(DateTime dateTime)
        {
            SYSTEMTIME st = new SYSTEMTIME();
            st.FromDateTime(dateTime);
            //Call Win32 API to set time
            SetLocalTime(ref st);
        }
    }
}
