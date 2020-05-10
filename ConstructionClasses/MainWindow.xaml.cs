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

namespace ConstructionClasses
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

        private void ThrowException_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                throw new DerivedException();
                
            }
            catch (DerivedException ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void ThrowException1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                throw new DerivedException("This exception is thrown by user");

            }
            catch (DerivedException ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Generics.Normal normalObj = new Generics.Normal("Sai", "Ravi");
            MessageBox.Show(normalObj.t.ToString(), normalObj.u.ToString());

            Generics.Generic<string, string> genericObj = new Generics.Generic<string, string>("Ravi", "Battula");
            MessageBox.Show(genericObj.t, genericObj.u);

            normalObj = new Generics.Normal(10, 20.5);
            MessageBox.Show(normalObj.t.ToString(), normalObj.u.ToString());

            Generics.Generic<int, double>  genericObj1 = new Generics.Generic<int, double>(10, 20.4);
            MessageBox.Show(genericObj1.t.ToString(), genericObj1.u.ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Generics.GenericOther<int, string, double> obj1 = new Generics.GenericOther<int, string, double>(10, "hell0", 10.1);
            MessageBox.Show(obj1.Obj1.GetType().ToString());
            MessageBox.Show(obj1.Obj2.GetType().ToString());
            MessageBox.Show(obj1.Obj3.GetType().ToString());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Generics.GenCompare<double> obj = new Generics.GenCompare<double>(10, 2);
            MessageBox.Show(obj.Max().ToString(), "Maximum Value");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int param1 = 10;
            int param2 = 20;

            Events.EventData obj = new Events.EventData();
            obj.MyEvent += new Events.MyEventHandler(obj_MyEvent);
            obj.CalCulate(param1, param2);
            obj.MyOtherEvent += new Events.MyEventHandlerExt(obj_MyOtherEvent);
            obj.CalculateExt(10, 15);
        }

        void obj_MyOtherEvent(int result)
        {
            MessageBox.Show(result.ToString());
        }

        void obj_MyEvent(object obj, EventArgs e)
        {
            MessageBox.Show(obj.ToString());
        }
    }
}
