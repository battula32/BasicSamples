using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inheritance
{
    public class ParentClass
    {
        public ParentClass()
        {
            MessageBox.Show("Parent class construction");
        }

        public void Print()
        {
            MessageBox.Show("I am in parent class");
        }
    }
}
