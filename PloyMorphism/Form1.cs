using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PloyMorphism
{
    public partial class Form1 : Form
    {
        private DrawingObject drawingObject;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Line
            this.drawingObject = new Line();
            this.drawingObject.Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Circle
            this.drawingObject = new Circle();
            this.drawingObject.Draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Rectangle
            this.drawingObject = new Rectangle();
            this.drawingObject.Draw();
        }
    }
}
