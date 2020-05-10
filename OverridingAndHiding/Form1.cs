using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverridingAndHiding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //Override
            Parent parent;
            Child child;
            parent = new Parent();
            child = new Child();
            parent.Method1();
            child.Method1();

            parent = new Child();
            parent.Method1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Method hiding
            Parent parent;
            Child child;
            parent = new Parent();
            child = new Child();
            parent.Method2();
            child.Method2();

            parent = new Child();
            parent.Method2();
        }
    }
}
