using System;
using System.Collections.Generic;
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

namespace RenderTier
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
            int currentRenderTier = (RenderCapability.Tier >> 16);
            switch (currentRenderTier)
            {
                case 0:
                    renderTier.Text = string.Format("{0} No hardware acceleration.", currentRenderTier.ToString());
                    break;

                case 1:
                    renderTier.Text = string.Format("{0} Partial hardware acceleration.", currentRenderTier.ToString());
                    break;

                case 2:
                    renderTier.Text = string.Format("{0} Full hardware acceleration.", currentRenderTier.ToString());
                    break;

                default:
                    renderTier.Text = string.Format("{0} Rendering not applicable", currentRenderTier.ToString());
                    break;
            }
        }
    }
}
