using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Timers;
using System.Diagnostics;

namespace ClockFrequency
{
    public class ClsCPUFrequency
    {
        System.Timers.Timer timer1;
        List<PerformanceCounter> performanCeCounterList = new List<PerformanceCounter>();
        PerformanceCounter processorFrequencyTotal = new PerformanceCounter("Processor Information", "% of Maximum Frequency", "_Total");
        public ClsCPUFrequency()
        {
            timer1 = new System.Timers.Timer();
            Console.WriteLine("getCPUSpeed");
            Settimerdata();
            CPUSpeed();
        }

        public void CPUSpeed()
        {
            ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'");
            uint sp = (uint)(Mo["CurrentClockSpeed"]);
            Mo.Dispose();
            Console.WriteLine("CPU Clock Speed :    {0:#,###.##}  % ", sp);
            Console.WriteLine("\nPress any key to exit.");
            Console.WriteLine("");
            float frequencyValue = this.processorFrequencyTotal.NextValue();
            Console.WriteLine("Frequecny using counter {0}", frequencyValue);
        }
        public void Settimerdata()
        {
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Elapsed);
            timer1.Enabled = true;
            timer1.Interval = 10000;
        }
        public void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff tt"));
            CPUSpeed();
            Console.WriteLine("");
        }
    }
}
