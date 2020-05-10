using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ThreadWindowsSample
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private delegate void SetItemsCallBackDelegate(IList<string> items);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.thread = new Thread(new ThreadStart(this.FillList));
            this.thread.Start();
        }

        private void FillList()
        {
            IList<string> items = new List<string>();
            items.Add("Hello");
            this.FillListBox(items);
            Thread.Sleep(2000);
            items.Add("Battula");
            Thread.Sleep(2000);
            this.FillListBox(items);
            Thread.Sleep(2000);
            items.Add("Ravi");
            Thread.Sleep(2000);
            this.FillListBox(items);
        }

        private void FillListBox(IList<string> items)
        {
            if (this.listBox1.InvokeRequired && this.textBox1.InvokeRequired)
            {
                SetItemsCallBackDelegate d = new SetItemsCallBackDelegate(FillListBox);
                this.Invoke(d, new object[] { items });
            }
            else
            {
                foreach (string itm in items)
                {
                    this.listBox1.Items.Add(itm);
                }

                if (items != null && items.Count > 0)
                {
                    this.textBox1.Text = items[items.Count - 1];
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.FillList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
    }
}
