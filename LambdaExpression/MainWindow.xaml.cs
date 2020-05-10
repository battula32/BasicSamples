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

namespace LambdaExpression
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

        private void WithoutDelegate(object sender, RoutedEventArgs e)
        {
            TestDelegateClass testDelegate = new TestDelegateClass();
            int result = testDelegate.TestMethod(10);
            MessageBox.Show(result.ToString());
        }

        private void WithSimpleDelegate(object sender, RoutedEventArgs e)
        {
            TestDelegateClass testDelegateObject = new TestDelegateClass();
            TestDelegateClass.TestDelegate testDelegate = new TestDelegateClass.TestDelegate(testDelegateObject.TestMethod);
            int result = testDelegate(10);
            MessageBox.Show(result.ToString());
        }

        private void DelegateWithDirectAssignment(object sender, RoutedEventArgs e)
        {
            TestDelegateClass testDelegateObject = new TestDelegateClass();
            TestDelegateClass.TestDelegate testDelegate = testDelegateObject.TestMethod;
            int result = testDelegate(10);
            MessageBox.Show(result.ToString());
        }

        private void GenericDelegate(object sender, RoutedEventArgs e)
        {
            TestDelegateClass testDelegateObject = new TestDelegateClass();
            
            TestDelegateClass.GenericDelegate<int, int> testDelegate = testDelegateObject.TestMethod;
            int result = testDelegate(10);
            MessageBox.Show(result.ToString());

            TestDelegateClass.GenericDelegate<double, double> testDelegateDouble = testDelegateObject.TestMethod1;
            double doubleResult = testDelegateDouble(10.2);
            MessageBox.Show(doubleResult.ToString());

            TestDelegateClass.GenericDelegate<string, string> testDelegateString = testDelegateObject.TestMethod2;
            string stringResult = testDelegateString("Ravi");
            MessageBox.Show(stringResult);
        }

        private void AnonymousDelegateInline(object sender, RoutedEventArgs e)
        {
            TestDelegateClass.TestDelegate testDelegate = delegate(int x){return x*2;};
            int result = testDelegate(10);
            MessageBox.Show(result.ToString());
        }

        private void AnonymousDelegateInlineWithFunc(object sender, RoutedEventArgs e)
        {
            Func<int, int> testDelegate = delegate(int x) { return x * 2; };
            int result = testDelegate(10);
            MessageBox.Show(result.ToString());
        }

        private void AnonymousDelegateInlineWithLambdaExpresssion(object sender, RoutedEventArgs e)
        {
            TestDelegateClass.TestDelegate testDelegate = x => { return x * 2; };
            int result = testDelegate(10);
            MessageBox.Show(result.ToString());
        }

        private void AnonymousFincWithLambdaExpression(object sender, RoutedEventArgs e)
        {
            Func<int, int> testDelegate = x => { return x * 2; };
            int result = testDelegate(10);
            MessageBox.Show(result.ToString());

            Func<double, double> testDelegateDouble = x => { return x * 2; };
            double doubleResult = testDelegateDouble(15.2);
            MessageBox.Show(doubleResult.ToString());
        }

        private void LambdaExpressionWithoutReturn(object sender, RoutedEventArgs e)
        {
            TestDelegateClass.TestDelegate testDelegate = x => x * 2;
            int result = testDelegate(10);
            MessageBox.Show(result.ToString());
        }

        private void LambdaExpressionWithoutReturnWithFunc(object sender, RoutedEventArgs e)
        {
            Func<int, int> testDelegate = x => x * 2;
            int result = testDelegate(10);
            MessageBox.Show(result.ToString());
        }

        private void OtherLambdaExpression1(object sender, RoutedEventArgs e)
        {
            // Multiplication of two numbers
            Func<double, double, double> multiplication = (a, b) => a * b;
            double result = multiplication(10.1, 20.1);
            MessageBox.Show(result.ToString(), "Multiplication");
        }

        private void OtherLambdaExpression2(object sender, RoutedEventArgs e)
        {
            // Concatination of two strings
            Func<string, string, string> concatination = (str1, str2) => str1 + " " + str2;
            string result = concatination("Hello", "Battula");
            MessageBox.Show(result);
        }
    }
}
