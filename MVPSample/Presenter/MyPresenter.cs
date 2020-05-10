using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVPSample.View;
using MVPSample.Model;

namespace MVPSample.Presenter
{
    public class MyPresenter
    {
        private readonly IMyView view;
        private readonly IMyModel model;

        public IMyView View
        {
            get { return view; }
        } 

        public MyPresenter()
        {
            this.view = new MyView();
            this.model = new MyModel();
            this.view.Initialize(this);
        }

        public void ShowLabel()
        {
            string labelName = this.model.GetMyLabel();
            this.View.ShowLabel(labelName);
        }
    }
}
