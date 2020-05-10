using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPSample.Model
{
    public class MyModel : IMyModel
    {
        string IMyModel.GetMyLabel()
        {
            return "MyLabel";
        }
    }
}
