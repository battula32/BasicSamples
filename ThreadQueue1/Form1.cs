using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace ThreadQueue1
{
    public partial class Form1 : Form
    {
        private ThreadItemsQueue tq = new ThreadItemsQueue();
        private delegate void TextDelegate(string status);
        private delegate void UpdateListDelegate(Queue<DataManip> dataQueue);
        public Form1()
        {
            this.InitializeComponent();
            this.textBox1.Text = this.tq.TQueue.Count.ToString();
            this.FillListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread tEnQueue = new Thread(EnQueueData);
            tEnQueue.Start();
            tEnQueue.Join();
        }

        private void EnQueueData()
        {
            lock (this.tq.TQueue)
            {
                Random rand = new Random();
                DataManip data = new DataManip();
                data.ItemNumber = rand.Next(500);
                data.ItemName = "Item " + data.ItemNumber.ToString();
                this.tq.EnQueueData(data);
                this.UpdateControls(this.tq.TQueue.Count.ToString());
                this.UpdateList(this.tq.TQueue);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread tDeQueue = new Thread(DeQueueData);
            tDeQueue.Start();
        }

        private void DeQueueData()
        {
            lock (this.tq.TQueue)
            {
                this.tq.DeQueueData();
                this.UpdateControls(this.tq.TQueue.Count.ToString());
                this.UpdateList(this.tq.TQueue);
            }
        }

        private void FillListBox()
        {
            this.listBox1.Items.Clear();
            foreach (DataManip data in this.tq.TQueue)
            {
                this.listBox1.Items.Add(data.ItemName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Go);
            thread.Start();
        }

        private void Go()
        {
            lock (this.tq.TQueue)
            {
                while (this.tq.TQueue.Count != 0)
                {
                    this.tq.DeQueueData();
                    this.UpdateList(this.tq.TQueue);
                    this.UpdateControls(this.tq.TQueue.Count.ToString());
                    Thread.Sleep(2000);
                }
            }
        }

        private void UpdateControls(string count)
        {
            if (this.textBox1.InvokeRequired)
            {
                TextDelegate delg = new TextDelegate(UpdateControls);
                this.Invoke(delg, count);
            }
            else
            {
                this.textBox1.Text = count;
            }
        }

        private void UpdateList(Queue<DataManip> dataQ)
        {
            if (this.listBox1.InvokeRequired)
            {
                UpdateListDelegate listDelg = new UpdateListDelegate(UpdateList);
                this.Invoke(listDelg, dataQ);
            }
            else
            {

                this.listBox1.Items.Clear();
                foreach (DataManip data in dataQ)
                {
                    this.listBox1.Items.Add(data.ItemName);
                }
            }
        }
    }
}
