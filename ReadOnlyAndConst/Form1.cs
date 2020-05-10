using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadOnlyAndConst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestClass testClass = new TestClass(20);
            MessageBox.Show(testClass.TestReadonly.ToString(), "ReadOnly variable");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TestClass.TestConst.ToString(), "Const variable");
            ////MessageBox.Show(TestClass.TestConstant.ToString(), "Const variable");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TestClass.TestStaticReadOnly.ToString(), "Static readonly variable");
        }
    }
}
