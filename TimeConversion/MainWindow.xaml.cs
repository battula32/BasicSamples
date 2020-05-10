using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimeConversion.Properties;

namespace TimeConversion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const int HOUR = 60;
        public const int DAY = 1440;
        public const int WEEK = 10080;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertMinutes(object sender, RoutedEventArgs e)
        {
            string finalResult = string.Empty;
            int minutes = int.Parse(this.minutes.Text);
            ////finalResult = SplitMinutes(finalResult, minutes);
            finalResult = this.SplitMinutes1(minutes);
            this.result.Content = finalResult;
        }

        private string SplitMinutes(string finalResult, int minutes)
        {
            if (minutes == 1)
            {
                finalResult = minutes.ToString() + Properties.Resources.Minute;
            }
            else if (minutes > 1 && minutes < HOUR)
            {
                finalResult = minutes.ToString() + Properties.Resources.Minutes;
            }
            else if (minutes == HOUR)
            {
                finalResult = (minutes / HOUR).ToString() + Properties.Resources.Hour;
            }
            else if (minutes > HOUR && minutes < DAY)
            {
                bool isHoleHour = (minutes % HOUR) == 0;
                if (isHoleHour)
                {
                    finalResult = (minutes / HOUR).ToString() + Properties.Resources.Hours;
                }
                else
                {
                    finalResult = minutes.ToString() + Properties.Resources.Minutes;
                }
            }
            else if (minutes == DAY)
            {
                finalResult = (minutes / DAY).ToString() + Properties.Resources.Day;
            }
            else if (minutes > DAY && minutes < WEEK)
            {
                bool isWholeDay = (minutes % DAY) == 0;
                if (isWholeDay)
                {
                    finalResult = (minutes / DAY).ToString() + Properties.Resources.Days;
                }
                else
                {
                    int remainingMins = minutes % DAY;
                    int numberOfDays = minutes / DAY;
                    if (numberOfDays > 1)
                    {
                        finalResult = numberOfDays.ToString() + Properties.Resources.Days;
                    }
                    else
                    {
                        finalResult = numberOfDays.ToString() + Properties.Resources.Day;
                    }

                    finalResult = finalResult + this.SplitMinutes(finalResult, remainingMins);
                }
            }
            else if (minutes == WEEK)
            {
                finalResult = (minutes / WEEK).ToString() + Properties.Resources.Week;
            }
            else if (minutes > WEEK)
            {
                bool isWholeWeek = (minutes % WEEK) == 0;
                if (isWholeWeek)
                {
                    finalResult = (minutes / WEEK).ToString() + Properties.Resources.Weeks;
                }
                else
                {
                    int remainingMins = minutes % WEEK;
                    int numberOfWeeks = minutes / WEEK;
                    if(numberOfWeeks > 1)
                    {
                        finalResult = numberOfWeeks.ToString() + Properties.Resources.Weeks;
                    }
                    else
                    {
                        finalResult = numberOfWeeks.ToString() + Properties.Resources.Week;
                    }

                    finalResult = finalResult + this.SplitMinutes(finalResult, remainingMins);
                }
            }

            return finalResult;
        }

        private string SplitMinutes1(int minutes)
        {
            TimeSpan tim = TimeSpan.FromMinutes(minutes);

            string str = string.Empty;

            if (tim.Days > 0)
            {
                if (tim.Days == 1)
                {
                    str = str + tim.Days + Properties.Resources.Day;
                }
                else if (tim.Days == 7)
                {
                    str = str + (tim.Days / 7) + Properties.Resources.Week;
                    CalculateDays(ref tim, ref str);
                }
                else if (tim.Days > 7)
                {
                    int numberOfWeeks = tim.Days / 7;
                    if (numberOfWeeks == 1)
                    {
                        str = str + numberOfWeeks + Properties.Resources.Week;
                    }
                    else if (numberOfWeeks > 1)
                    {
                        str = str + numberOfWeeks + Properties.Resources.Weeks;
                    }

                    CalculateDays(ref tim, ref str);
                }
                else
                {
                    str = str + tim.Days + Properties.Resources.Days;
                }
            }
            if (tim.Hours == 1)
            {
                str = str + tim.Hours + Properties.Resources.Hour;
            }
            else if (tim.Hours > 0)
            {
                str = str + tim.Hours + Properties.Resources.Hours;
            }

            if (tim.Minutes == 1)
            {
                str = str + tim.Minutes + Properties.Resources.Minute;
            }
            else if (tim.Minutes > 0)
            {
                str = str + tim.Minutes + Properties.Resources.Minutes;
            }

            if (tim.Seconds == 1)
            {
                str = str + tim.Seconds + "Sec ";
            }
            else if (tim.Seconds > 0)
            {
                str = str + tim.Seconds + "Secs ";
            }

            return str;
        }

        private static void CalculateDays(ref TimeSpan tim, ref string str)
        {
            int numberOfDays = tim.Days % 7;
            if (numberOfDays == 1)
            {
                str = str + numberOfDays + Properties.Resources.Day;
            }
            else if(numberOfDays > 1)
            {
                str = str + numberOfDays + Properties.Resources.Days;
            }
        }

        private string GetHours(int mins)
        {
            if (mins % 60 == 0 && mins / 60 < 24)
            {
                if (mins / 60 == 1)
                {
                    return mins / 60 + "hour";
                }
                else
                {
                    return mins / 60 + "hours";
                }
            }
            else
            {
                if (mins == 1 || mins == 0)
                {
                    return mins.ToString() + "min";
                }
                else
                {
                    return mins.ToString() + "mins";
                }
            }
        }

        private string GetDays(int mins)
        {
            string appendMins = string.Empty;
            string daysText = string.Empty;
            int remainingMins = mins % 1440;
            if (remainingMins > 0)
            {
                appendMins = this.GetHours(remainingMins);
            }

            return daysText + appendMins;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.fResult.Content = dt.ToString("f");
            this.FResult.Content = dt.ToString("F");

            this.dResult.Content = dt.ToString("d");
            this.DResult.Content = dt.ToString("D");

            this.gResult.Content = dt.ToString("g");
            this.GResult.Content = dt.ToString("G");

            this.mResult.Content = dt.ToString("m");
            this.MResult.Content = dt.ToString("M");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            long ticks = DateTime.Now.AddDays(-7).Ticks;
            if (this.TicsForConvertion.Text.Length > 0)
            {
                long tics = long.Parse(this.TicsForConvertion.Text);
                DateTime dtUtc = new DateTime(tics);
                this.localUTCTime.Text = dtUtc.ToString();
                int item = (int)tics;
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            long tics = long.Parse(this.TicsForConvertion.Text);
            DateTime dtLocal = new DateTime(tics);
            ////DateTime dtUtc = Convert.ToDateTime(tics).ToUniversalTime();
            this.localUTCTime.Text = dtLocal.ToLocalTime().ToString();
        }
    }
}
