using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThreadMonitoring
{
    public partial class Form1 : Form
    {
        private delegate void StringDelegate(string msg);
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Executes the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        private void Execute(string msg)
        {
            object obj = this.label1;
            System.Threading.Monitor.Enter(obj);
            try
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

            finally
            {
                System.Threading.Monitor.Exit(obj);
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
    }
}
