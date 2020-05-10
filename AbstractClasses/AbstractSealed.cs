using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbstractClasses
{
    public abstract class AbstractSealed
    {
        public static void AbstractMethod1()
        {
            MessageBox.Show("Abstract method 1");
        }

        public abstract void AbstractMethod2();
    }

    public class ChildClass1 : AbstractSealed
    {
        //public override void AbstractMethod1()
        //{
        //    MessageBox.Show("Implementation to Abstract methos");
        //}
        public override void AbstractMethod2()
        {
            MessageBox.Show("Implementation to Abstract method");
        }
    }
}
