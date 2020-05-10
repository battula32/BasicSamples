using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadQueue1
{
    public class ThreadItemsQueue
    {
        private Queue<DataManip> tQueue;

        public ThreadItemsQueue()
        {
            this.tQueue = new Queue<DataManip>();
            DataManip data = new DataManip();
            data.ItemName = "Item 1";
            data.ItemNumber = 1;
            this.tQueue.Enqueue(data);

            data = new DataManip();
            data.ItemName = "Item 2";
            data.ItemNumber = 2;
            this.tQueue.Enqueue(data);

            data = new DataManip();
            data.ItemName = "Item 3";
            data.ItemNumber = 3;
            this.tQueue.Enqueue(data);
        }

        public Queue<DataManip> TQueue
        {
            get
            {
                if (this.tQueue == null)
                {
                    this.tQueue = new Queue<DataManip>();
                }

                return this.tQueue;
            }
        }

        public void EnQueueData(DataManip data)
        {
            this.tQueue.Enqueue(data);
        }

        public void DeQueueData()
        {
            if (this.tQueue.Count > 0)
            {
                this.tQueue.Dequeue();
            }
        }
    }
}
