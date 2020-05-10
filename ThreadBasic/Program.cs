using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadBasic
{
    class ThreadClass
    {
        static bool done;
        static readonly object locker = new object();
        static void Main(string[] args)
        {
            //Thread lock
            //Thread t = new Thread(Go);
            //t.Name = "Worker";
            //Console.WriteLine(Thread.CurrentThread.Name);
            //t.Start();
            

            //GoY();
            //t = new Thread(() =>
            //    {
            //        Console.WriteLine("Hello I am in seperate Anonymous thread");
            //        Console.WriteLine("Hello There");
            //        Console.WriteLine(Thread.CurrentThread.Name);
            //        Console.WriteLine("Last statement in thred");
            //    });
            //t.Name = "Anonymous thread";

            //t.Start();
            //t = new Thread(delegate()
            //{
            //    Console.WriteLine("Hello I am in seperate delegate thread");
            //    Console.WriteLine("Hello There");
            //    Console.WriteLine(Thread.CurrentThread.Name);
            //    Console.WriteLine("Last statement in thred");
            //});
            
            //t.Name = "Delegate thread";

            //t.Start();

            //t = new Thread(() => MethodWith2Params("Hello", "Ravi"));
            //t.Start();

            TestCommonData testCommonData = new TestCommonData();
            testCommonData.RequestMessage = "MyMessage";
            testCommonData.ReplyMessage = "MyMessage";
            Thread t = new Thread(testCommonData.UpdateReply);
            t.Start();
            t.Join();
            Console.WriteLine(testCommonData.ReplyMessage);

            Console.Read();

            //Thread Join()
            //Thread tt = new Thread(Go);
            //tt.Start();
            //tt.Join();
            //Console.WriteLine("Thread ended");

            //Thread t = new Thread(Go);
            //t.Start();
            //bool threadState = t.Join(10);
            //if (threadState)
            //{
            //    Console.WriteLine("Thred ended safely");
            //}
            //else
            //{
            //    Console.WriteLine("Thread time out happened");
            //}

            //Thread sleep
            //Thread tSleep = new Thread(Go);
            //tSleep.Start();
            //Thread.Sleep(20);
            //Console.WriteLine("Main thred is called");
            //Console.Read();

            //Thread delegate/Ananymus difination
            //Thread tDelegate = new Thread(() => Console.WriteLine("Hello"));
            //Thread tDelegate = new Thread(() => DelegateGo());
            //tDelegate.Start();

            // Passing parameters over thread
            //Thread parametsThread = new Thread(() => ParametesGo("Hello"));
            //parametsThread.Start();

            //Thread parametersThread = new Thread(ParametesGo);
            //parametersThread.Start("Hello object sent");

            // Lambda expressions in thread
            //new Thread(() =>
            //    {
            //        Console.WriteLine("This is not main thread - sub thread");
            //        Thread.Sleep(10);
            //        Console.WriteLine("Sleep is called in sub thread");
            //    }).Start();

            //Console.WriteLine("This is mainThread");
            //Console.Read();

            //Delegate implementation
            //new Thread(delegate()
            //    {
            //        Console.WriteLine("This is not main thread - sub thread");
            //        Thread.Sleep(10);
            //        Console.WriteLine("Sleep is called in sub thread");
            //    }).Start();
            //Console.WriteLine("This is mainThread");
            Console.Read();
        }

        /// <summary>
        /// Tests this instance.
        /// </summary>
        static void Test()
        {
            lock (locker)
            {
                if (!done)
                {
                    Console.WriteLine("Done");
                    done = true;
                }
            }
        }

        static void Go()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
                //if (i == 20)
                //{
                //    Thread.Sleep(20);
                //}
            }
        }

        static void GoY()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Y");
            }
        }

        static void DelegateGo()
        {
            Console.WriteLine("Hello");
        }

        static void ParametesGo(string msg)
        {
            Console.WriteLine(msg);
        }

        static void ParametesGo(object msg)
        {
            Console.WriteLine(msg);
        }

        static void MethodWith2Params(string str1, string str2)
        {
            Console.WriteLine("Parameter 1: {0}, Parameter 2: {1}", str1, str2);
        }
    }

    class TestCommonData
    {
        public string RequestMessage;
        public string ReplyMessage;

        public void UpdateReply()
        {
            Console.WriteLine(RequestMessage);
            ReplyMessage = "Hello there";
        }
    }
}
