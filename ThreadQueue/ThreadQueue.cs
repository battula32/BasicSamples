using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadQueue1
{
    public class ThreadQueue
    {
        private readonly object locker = new object();
        private Thread[] workers;
        private Queue<Action> itemQ = new Queue<Action>();

        public ThreadQueue(int workerCount)
        {
            this.workers = new Thread[workerCount];
            for (int i = 0; i < workerCount; i++)
            {
                this.workers[i] = new Thread(Consume);
                this.workers[i].Start();
                Console.WriteLine("Thread {0} started", i + 1);
            }
        }

        public void ShutDown(bool waitForWorker)
        {
            foreach (Thread worker in this.workers)
            {
                Console.WriteLine("Shutdown for worker {0} initiated", worker);
                this.EnqueueItem(null);
            }

            if (waitForWorker)
            {
                foreach (Thread worker in this.workers)
                {
                    Console.WriteLine("Waiting for worker {0} to shutdown", worker);
                    worker.Join();
                }
            }
        }

        public void EnqueueItem(Action item)
        {
            lock (this.locker)
            {
                itemQ.Enqueue(item);
                Monitor.Pulse(this.locker);
                Console.WriteLine("En queue for item {0}", item);
            }
        }

        public void Consume()
        {
            while (true)
            {
                Action item;
                lock (this.locker)
                {
                    while (this.itemQ.Count == 0)
                    {
                        Monitor.Wait(this.locker);
                    }

                    item = this.itemQ.Dequeue();
                    if (item == null)
                    {
                        return;
                    }

                    item();
                }
            }
        }
    }
}
