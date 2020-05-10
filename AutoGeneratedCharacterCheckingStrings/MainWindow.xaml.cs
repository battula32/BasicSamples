﻿using System;
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

namespace AutoGeneratedCharacterCheckingStrings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestLabel();
        }

        private void TestLabel()
        {
            Random rand1 = new Random();
            int item1 = rand1.Next(10000, 99999);
            int item2 = rand1.Next(65, 91);
            int item3 = rand1.Next(65, 91);
            char c1 = Convert.ToChar(item2);
            char c2 = Convert.ToChar(item3);
            this.label1.Content = c1 + item1.ToString() + c2;
            Random rand2 = new Random(-6);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestLabel();
        }
    }
}