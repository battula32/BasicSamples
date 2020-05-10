using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVPSample.Presenter;

namespace MVPSample.View
{
    public partial class MyView : Form, IMyView
    {
        private MyPresenter presnter;

        public MyView()
        {
            InitializeComponent();
        }

        void IMyView.Initialize(Presenter.MyPresenter presenter)
        {
            this.presnter = presenter;
        }


        void IMyView.ShowLabel(string label)
        {
            this.label1.Text = label;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.presnter.ShowLabel();
        }
    }
}
