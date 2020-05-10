using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SquareRootCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double squareRoot = SqareRoot(5, 0.0001);
            MessageBox.Show(squareRoot.ToString(CultureInfo.CurrentCulture));
        }

        private double SqareRoot(double square, double epsilon)
        {
            double root = 1.0;
            double ourGuess = (square/root + root)/2.0;
            while (Math.Abs(ourGuess - root) > epsilon)
            {
                root = ourGuess;
                ourGuess = (square / root + root) / 2.0;
            }

            return ourGuess;
        }
    }
}
