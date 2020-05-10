using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.Reflection;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass myClass = new MyClass();
            myClass.TestMethod();// this method is called by extension method, in extension method reflection is happening
        }
    }

    public class MyClass
    {
        private void TestMethod()
        {
            //Console.WriteLine("Test method is called through reflection");
            MessageBox.Show("Test method is called through reflection");
        }
    }

    internal static class MyClassHelper
    {
        public static void TestMethod(this MyClass myClass)
        {
            MethodInfo method = typeof(MyClass).GetMethod("TestMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            method.Invoke(myClass, null);
        }
    }
}
