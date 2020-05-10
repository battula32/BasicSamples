using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TogglePages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.panel1.Visible)
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
                panel1.Visible = true;
            }
        }
    }
}
