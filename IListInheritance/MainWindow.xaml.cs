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

namespace IListInheritance
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

        private void IntList_Click(object sender, RoutedEventArgs e)
        {
            List<int> lst = new List<int>();
            lst.Add(10);
            lst.Add(20);
            lst.Add(30);
            lst.Add(40);
            CustomList<List<int>, int> custList = new CustomList<List<int>, int>(lst);
            custList.AddUnique(60);
            MessageBox.Show(custList.t.Count.ToString());
            custList.AddUnique(100);
            MessageBox.Show(custList.t.Count.ToString());
            custList.AddUnique(10);
            MessageBox.Show(custList.t.Count.ToString());
        }

        private void DoubleList_Click(object sender, RoutedEventArgs e)
        {
            CustomList<List<double>, double> custList = new CustomList<List<double>, double>(new List<double>());
            for (int i = 0; i < 10; i++)
            {
                custList.AddUnique(i * 10 / 1.5);
            }

            MessageBox.Show(custList.t.Count.ToString());
        }

        private void StringList_Click(object sender, RoutedEventArgs e)
        {
            CustomList<List<string>, string> custList = new CustomList<List<string>, string>(new List<string>());
            for (int i = 0; i < 10; i++)
            {
                custList.AddUnique("Ravi " +i.ToString());
            }

            MessageBox.Show(custList.t.Count.ToString());
        }

        private void RemoveSameItems_Click(object sender, RoutedEventArgs e)
        {
            IList<int> lst = new List<int>();
            lst.Add(10);
            lst.Add(20);
            lst.Add(30);
            lst.Add(10);
            lst.Add(40);
            lst.Add(10);

            CustomList<IList<int>, int> custList = new CustomList<IList<int>, int>(lst);
            int removedItems = custList.RemoveSameItems(10);
            MessageBox.Show(removedItems.ToString());
        }
    }
}
