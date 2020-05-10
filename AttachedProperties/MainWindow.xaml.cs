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

namespace AttachedProperties
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement source = e.Source as FrameworkElement;
            switch (source.Name)
            {
                case "button1":
                    MessageBox.Show("You clicked on button1");
                    break;
                case "button2":
                    MessageBox.Show("You clicked on button2");
                    break;
            }
        }

        private void MyControl_MouseWheel(object sender, MouseWheelEventArgs e)
        {

        }
    }
}
