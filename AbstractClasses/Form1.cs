using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbstractClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildToAbstract childObj = new ChildToAbstract();
            childObj.TestMethod1();
            childObj.TestAbstractMethod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChildClass1 childClass = new ChildClass1();
            childClass.AbstractMethod2();
            AbstractSealed.AbstractMethod1();
        }
    }
}
