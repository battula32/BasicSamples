using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadQueue1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadQueue q = new ThreadQueue(2);
            Console.WriteLine("Enqueuing 10 items...");
            for (int i = 0; i < 10; i++)
            {
                int itemNumber = i;
                q.EnqueueItem(() =>
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Task " + itemNumber);
                    });
            }

            q.ShutDown(true);
            Console.WriteLine();
            Console.WriteLine("Worker Complered");
            Console.Read();
        }
    }
}
