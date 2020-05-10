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

namespace PolymorphismEx
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
            ImplementTest obj = new ImplementTest();
            MessageBox.Show(obj.Name);
            SubToImplementTest subToImplementTest = new SubToImplementTest();
            MessageBox.Show(subToImplementTest.TestName);
            MessageBox.Show(obj.Name);
            subToImplementTest.NewName = "Hello";
            MessageBox.Show(subToImplementTest.TestName);
            MessageBox.Show(obj.Name);
            MessageBox.Show(subToImplementTest.NewName);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SubToImplementTest subImplemntsTest = new SubToImplementTest();
            MessageBox.Show(subImplemntsTest.MyDigits.ToString());
            subImplemntsTest.MyDigits = 256;
            MessageBox.Show(subImplemntsTest.MyDigits.ToString());
            MessageBox.Show(subImplemntsTest.MyDigits.ReverseDigits().ToString());
        }
    }
}
