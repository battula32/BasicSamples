using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThreadLock
{
    public partial class Form1 : Form
    {
        private delegate void StringDelegate(string msg);
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread1 = new System.Threading.Thread(ExecuteThread1);
            thread1.Name = "Thread1";
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread2 = new System.Threading.Thread(ExecuteThread2);
            thread2.Name = "Thread2";
            thread2.Start();
        }

        private void ExecuteThread1()
        {
            this.Execute("Thread1");
        }

        private void ExecuteThread2()
        {
            this.Execute("Thread2");
        }

        private void Execute(string msg)
        {
             lock (this.label1)
             {
                 int l = 0;
                 if (msg == "Thread1")
                 {
                     l = 10;
                     Console.WriteLine("Thread 1 entered");
                 }
                 else
                 {
                     l = 5;
                     Console.WriteLine("Thread 2 entered");
                 }

                 for (int i = 0; i < l; i++)
                 {
                     System.Threading.Thread.Sleep(500);
                 }

                 this.count++;
                 this.SetLabel(this.count.ToString() + " " + msg);
             }
        }

        private void SetLabel(string msg)
        {
            if (this.label1.InvokeRequired)
            {
                StringDelegate dlg = new StringDelegate(SetLabel);
                this.Invoke(dlg, msg);
            }
            else
            {
                this.label1.Text = msg;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread3 = new System.Threading.Thread(ExecuteThread3);
            thread3.Name = "Thread3";
            thread3.Start();
        }

        private void ExecuteThread3()
        {
            lock (this.label1)
            {
                ////System.Threading.Thread.CurrentThread.Join(); This is dead lock, Ith blocks the other threads also
                // because this thread is locked by label1 object, label1 object should be freed by this, then only other
                // threads can use label1.
                this.SetLabel("Thread3");
            }
        }
    }
}
