using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MVPSample.View;
using MVPSample.Presenter;

namespace MVPSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyPresenter presenter = new MyPresenter();
            Application.Run((Form)presenter.View);
        }
    }
}
