using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValidateTextBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (this.IsNumeric(textBox1.Text))
            {
                MessageBox.Show("text box1 is numeric");
            }
            else
            {
                MessageBox.Show("text box1 is not numeric");
            }
        }

        private bool IsNumeric(string sTemp)
        {
            try
            {
                int portnumber = Int32.Parse(sTemp);
                //if (portnumber > 1024 && portnumber < 65535)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}

            }
            catch
            {
                return false;
            }

            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (this.IsNumeric(textBox2.Text))
            {
                MessageBox.Show("text box2 is numeric");
            }
            else
            {
                MessageBox.Show("text box2 is not numeric");
            }
        }
    }
}
