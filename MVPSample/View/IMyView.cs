using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVPSample.Presenter;

namespace MVPSample.View
{
    public interface IMyView
    {
        void Initialize(MyPresenter presenter);

        void ShowLabel(string label);
    }
}
