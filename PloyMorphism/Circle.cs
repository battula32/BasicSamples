using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PloyMorphism
{
    public class Circle:DrawingObject
    {
        public override void Draw()
        {
            MessageBox.Show("Draw circle");
        }
    }
}
