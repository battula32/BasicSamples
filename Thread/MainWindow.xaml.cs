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
using System.Threading;

namespace ThreadSafe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread thread;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            thread = new Thread(new ThreadStart(this.FillList));
            thread.Start();
        }

        private void FillList()
        {
            IList<string> items = new List<string>();
            items.Add("Hello");
            items.Add("Battula");
            this.FillListBox(items);
        }

        private void FillListBox(IList<string> items)
        {
            ////if (this.listItems.)
            ////{

            ////}
        }
    }
}
