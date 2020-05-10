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
using System.IO;
using System.Security.Permissions;

[assembly:FileIOPermissionAttribute(SecurityAction.RequestMinimum, Read=@"E:\\pers.ini")] // This is security permission attribute
namespace BasicSample
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

        private void ArraySort_Click(object sender, RoutedEventArgs e)
        {
            int[] ar = { 10, 1, 22, 3 };
            Array.Sort(ar);
            foreach (int item in ar)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void FileIO_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("Hello Battula");
            sw.Close();

            StreamReader sr = new StreamReader("test.txt");
            MessageBox.Show(sr.ReadToEnd());
            sr.Close();
        }

        private void Exceptions_Click(object sender, RoutedEventArgs e)
        {
            ReadFile();
        }

        private static void ReadFile()
        {
            try
            {
                StreamReader sr = new StreamReader("E:\\pers.ini"); // not autorized
                ////StreamReader sr = new StreamReader("test1.txt");  // File not found
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("File not found");
            }
            catch (System.UnauthorizedAccessException ex)
            {
                MessageBox.Show("You are not authorizes to access");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Cleaning process
            }
        }

        private void Type_Click(object sender, RoutedEventArgs e)
        {
            string s = "Test";
            StringBuilder sb = new StringBuilder();
            sb.Append("Test");
            int a = 1;
            double b = 1.1d;
            object[] types = { s, sb, a, b };
            foreach (object o in types)
            {
                string type = string.Empty;
                if (o.GetType().IsValueType)
                {
                    type = o.GetType().ToString() + ": Value type";
                }
                ////else if(o.GetType().)
                ////{
                ////    type = o.GetType().ToString() + ": Reference type";
                ////}

                MessageBox.Show(o.GetType().ToString(), o.ToString());
                MessageBox.Show(type);
            }
        }

        private void StringAndArray_Click(object sender, RoutedEventArgs e)
        {
            string s = "Battula Raveendra babu";
            string[] sp = s.Split(' ');
            Array.Sort(sp);
            s = string.Join(" ", sp);
            MessageBox.Show(s);
        }
    }
}
