using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RunCommands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "Xcopy " + "C:\\FLSADev\\Bin\\License\\*.* " + "C:\\FLSADEVBACKUP\\Bin\\License\\*.*";//Console.ReadLine().Trim(); //
            ExecuteCommands cmd = new ExecuteCommands();
            string result = cmd.ExecuteCommand(command);
            richTextBox1.Text = result;
        }
    }
}
