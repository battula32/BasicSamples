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

namespace AyncSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Sync_Click(object sender, RoutedEventArgs e)
        {
            Utilities utilities = new Utilities();
            double sum = utilities.Add(10, 12);
            MessageBox.Show("Sum is " + sum.ToString());
        }

        private void Async_Click(object sender, RoutedEventArgs e)
        {
            Utilities utilities = new Utilities();
            Utilities.DelegateAdd add = utilities.Add;
            IAsyncResult result = add.BeginInvoke(20, 30, null, null);
            double sum = add.EndInvoke(result);
            MessageBox.Show("Sum is " + sum.ToString());
        }
    }
}
