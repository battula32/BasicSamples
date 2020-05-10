using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inheritance
{
    public class ChildClass :ParentClass
    {
        public ChildClass()
        {
            MessageBox.Show("Child class construction");
        }
    }
}
