using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace NotifyIcon
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private delegate void EnableSystemTray();
        bool showTip;
        int progressValue = 0;
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.BalloonTipText = "Hello";
            notifyIcon1.BalloonTipTitle = "Battula";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.showTip)
            {
                this.showTip = false;
                this.notifyIcon1.Visible = false;
                notifyIcon1.BalloonTipText = "Hello";
                notifyIcon1.BalloonTipTitle = "Battula";
                notifyIcon1.ShowBalloonTip(0);
            }
            else
            {
                this.notifyIcon1.Visible = true;
                this.showTip = true;
                notifyIcon1.BalloonTipText = "Hello";
                notifyIcon1.BalloonTipTitle = "Battula";
                notifyIcon1.ShowBalloonTip(1000);
            }
            this.thread = new Thread(new ThreadStart(this.UseSystemTray));
            this.thread.Start();
        }

        private void UseSystemTray(int tipTime)
        {

           
        }

        private void UseSystemTray()
        {
            if (this.progressBar1.InvokeRequired)
            {
                for (int i = 0; i < 6; i++)
                {
                    this.progressValue = i;
                    EnableSystemTray d = new EnableSystemTray(UseSystemTray);
                    this.Invoke(d, new object[] {});
                    Thread.Sleep(30000);
                }
            }
            else
            {
                this.progressBar1.Value = this.progressValue;
                this.notifyIcon1.ShowBalloonTip(0);
                if(this.progressValue == 5)
                {
                    this.progressBar1.Visible = false;
                    this.thread.Abort();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
