using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverridingAndHiding
{
    public class Child : Parent
    {
        public override void Method1()
        {
            MessageBox.Show("Method 1 Child");
            base.Method1();// in order to capture base implementation you need to call like this.
        }

        public new void Method2() // new key word is to avoid warning, If you use new mean you are kowingly doing this.
        {
            MessageBox.Show("Method 2 Child");
        }
    }
}
