using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbstractClasses
{
    public abstract class AbstractClass
    {
        public void TestMethod1()
        {
            MessageBox.Show("Hello normal method in abstract class");
        }

        public abstract void TestAbstractMethod();
    }

    public class ChildToAbstract : AbstractClass
    {
        public override void TestAbstractMethod()
        {
            MessageBox.Show("Implementation for abstrcatmethod");
        }
    }

}
