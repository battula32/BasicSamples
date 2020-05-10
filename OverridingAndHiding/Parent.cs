using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverridingAndHiding
{
    public class Parent
    {
        public virtual void Method1()
        {
            MessageBox.Show("Method 1 Parent");
        }

        public void Method2()
        {
            MessageBox.Show("Method 2 parent");
        }
    }
}
