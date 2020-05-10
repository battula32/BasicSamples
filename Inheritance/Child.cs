using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inheritance
{
    public class Child : Parent
    {
        public Child()
            : base("From derived")
        {
            MessageBox.Show("Child constructor");
        }

        ////public Child()
        ////{
        ////    MessageBox.Show("Child constructor");
        ////}

        public void Print()
        {
            //base.Print();
            MessageBox.Show("I am in child print");
        }

        public override void Show()
        {
            MessageBox.Show("I am in child show");
        }
    }
}
