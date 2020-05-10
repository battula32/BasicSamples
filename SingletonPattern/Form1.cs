using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        private SingletonClass singletonObject1;
        private SingletonClass singletonObject2;
        public Form1()
        {
            InitializeComponent();
            
            this.singletonObject1 = SingletonClass.Singleton;
        }

        private void cmdSingleton_Click(object sender, EventArgs e)
        {
            this.singletonObject1.TestString = "Hello Battula";
            MessageBox.Show(this.singletonObject1.TestString);
        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            this.singletonObject2 = SingletonClass.Singleton;
            if (this.singletonObject1.Equals(this.singletonObject2))
            {
                MessageBox.Show("Both instances are same");
            }
            else
            {
                MessageBox.Show("Both instances are different");
            }

            // This is to make sure that both instances has same data
            MessageBox.Show(this.singletonObject2.TestString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingletonClass1 obj = SingletonClass1.SingletonObject;
            obj.TestString = "Hello Varun";
            MessageBox.Show(obj.TestString);

            SingletonClass1 obj1 = SingletonClass1.SingletonObject;
            MessageBox.Show(obj1.TestString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SingletonThreadSync obj = SingletonThreadSync.SingletonThread;
        }
    }
}
