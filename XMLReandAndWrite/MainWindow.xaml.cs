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

namespace XMLReandAndWrite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private XmlManipulation xmlManipulation;
        public MainWindow()
        {
            InitializeComponent();
            this.xmlManipulation = new XmlManipulation();
        }

        private void ReadFromXml(object sender, RoutedEventArgs e)
        {
            this.xmlManipulation.ReadFromXml();
        }

        private void WriteToXml(object sender, RoutedEventArgs e)
        {
            this.xmlManipulation.WriteToXml();
        }

        private void ReadXml_Click(object sender, RoutedEventArgs e)
        {
            this.xmlManipulation.ReadXmlFile();
        }

        private void Write_Click(object sender, RoutedEventArgs e)
        {
            this.xmlManipulation.WriteXML();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
