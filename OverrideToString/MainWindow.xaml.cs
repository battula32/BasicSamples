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

namespace OverrideToString
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
            Person person = new Person("Ravi", "Battula", 30);
            MessageBox.Show(person.ToString());

            Person per1 = new Person(10);
            Person per2 = per1;
            per1.number += 10;
            MessageBox.Show("per1", per1.number.ToString());
            MessageBox.Show("per2", per2.number.ToString());
        }
    }
}
