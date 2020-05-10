using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestControl
{
    public partial class ThreeButtons : UserControl
    {
        public ThreeButtons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        public virtual void OnThreeButtonsClick(object sender, EventArgs e)
        {
            MessageBox.Show("user control is called");
        }
    }
}
