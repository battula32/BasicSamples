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

namespace WpfBasicDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        public MainWindow()
        {
            InitializeComponent();
            Data data = new Data();
            data.Name = "Ravi";
            data.PhoneNumber = "904366000";
            DataContext = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data data = DataContext as Data;
            if (txtName.Text.Equals(data.Name))
            {
                MessageBox.Show("Name binded in two way");
            }

            data.Name = "Raveendrababu";
            data.PhoneNumber = "111111";
            DataContext = data;
        }
    }
}
