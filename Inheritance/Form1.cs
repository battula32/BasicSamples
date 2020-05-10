using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChildClass child = new ChildClass();
            child.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            child.Print();
            ((Parent)child).Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            child.Show();
            ((Parent)child).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Parent parent = new Child();
            parent.Show();
            parent.Print();
        }
    }
}
