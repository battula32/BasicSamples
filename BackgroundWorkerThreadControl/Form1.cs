using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BackgroundWorkerThreadControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void ShowProgress_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                backgroundWorker1.ReportProgress(i * 10);
                Thread.Sleep(1000);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(1000);
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }
    }
}
