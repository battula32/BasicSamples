using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inheritance
{
    public class Parent
    {
        string parentString;

        public Parent()
        {
            MessageBox.Show("Parent constructor");
        }

        public Parent(string myString)
        {
            this.parentString = myString;
            MessageBox.Show(this.parentString);
        }

        public void Print()
        {
            MessageBox.Show("I am in Parent print");
        }

        public virtual void Show()
        {
            MessageBox.Show("I am in parent show");
        }
    }
}
