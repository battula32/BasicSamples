using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RunCommandsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "echo f|xcopy " + "C:\\FLSADev\\Bin\\License\\*.* " + "C:\\FLSADEVBACKUP\\Bin\\License\\*.*";//Console.ReadLine().Trim(); //
            string result = ExecuteCommand(command);
            richTextBox1.Text = result;
        }

        private string ExecuteCommand(string command)
        {
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C" + command);
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = processStartInfo;
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            ////Console.WriteLine(result);
            return result;
        }
    }
}
