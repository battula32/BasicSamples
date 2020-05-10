using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace EventsSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            this.timer.Interval = new TimeSpan(0, 0, 1);
            this.timer.Start();
            this.timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.progressBar.Value < 200)
            {
                this.progressBar.Value += 10;
            }
            else
            {
                this.timer.Stop();
            }
        }
    }
}
