using System;
using System.Windows;

namespace net.sylde.x2h
{
    public partial class DoNotEditW : Window
    {
        public DoNotEditW()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
        }

        private async void onTranslate(object sender, RoutedEventArgs e)
        {
            _translate.Visibility = Visibility.Collapsed;
            _progress.Visibility = Visibility.Visible;

            try
            {
                string message_s = await Root.cTradutionAsync(_x2hEditor);

                _translate.Visibility = Visibility.Visible;
                _progress.Visibility = Visibility.Collapsed;

                if (message_s == null)
                {
                    MessageBox.Show("Success! The files index.html and xaml2html.css have been created in the folder\r\n" + AppDomain.CurrentDomain.BaseDirectory);
                }
                else
                {
                    MessageBox.Show(message_s);
                }
            }
            catch (ArgumentException)
            {
                _translate.Visibility = Visibility.Visible;
                _progress.Visibility = Visibility.Collapsed;
                MessageBox.Show("Sorry, your page is too big and cannot be translated.");
            }
            catch (FormatException)
            {
                _translate.Visibility = Visibility.Visible;
                _progress.Visibility = Visibility.Collapsed;
                MessageBox.Show("Sorry, the x2h server cannot be reach. It may be because of a maintenance operation, but please also check your firewall!");
            }
        }
    }
}
