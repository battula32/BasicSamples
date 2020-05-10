using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadBasic1
{
    class Program
    {
        static System.Timers.Timer tmr = new System.Timers.Timer();
        static void Main(string[] args)
        {
            try
            {
                tmr.Elapsed += new System.Timers.ElapsedEventHandler(tmr_Elapsed);
                tmr.Enabled = true;
                tmr.Interval = 1000;
                System.Threading.Thread t = new System.Threading.Thread(Go);
                t.Name = "Thread1";
                t.Start();

                Thread.Sleep(1000);
                System.Threading.Thread tt = new System.Threading.Thread(Go);
                tt.Name = "Thread1";
                tt.IsBackground = true;
                tt.Start();

                Thread.Sleep(1000);
                System.Threading.Tasks.TaskFactory taskFactory = new System.Threading.Tasks.TaskFactory();
                taskFactory.StartNew(Go);

                ////Thread.Sleep(1000);
                ////System.Threading.Tasks.TaskFactory<string> taskFactory1 = new System.Threading.Tasks.TaskFactory<string>(() => Go("TaskFactory"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }

        static void tmr_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.Write("This is timer ");

            if (Thread.CurrentThread.IsThreadPoolThread)
            {
                Console.WriteLine("timer is default thread pool");
            }
            else
            {
                Console.WriteLine("Timer is not thread pool");
            }
        }

        static void Go()
        {
            try
            {
                if (Thread.CurrentThread.IsThreadPoolThread)
                {
                    Console.WriteLine("This is thread pool thread");
                }
                else
                {
                    Console.WriteLine("This is not thread pool thread");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Go(string str)
        {
            if (Thread.CurrentThread.IsThreadPoolThread)
            {
                Console.WriteLine(str + " This is thread pool thread");
            }
            else
            {
                Console.WriteLine(str + " This is not thread pool thread");
            }
        }
    }
}
