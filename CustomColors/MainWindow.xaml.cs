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

namespace CustomColors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] customColors;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog.CustomColors = this.CustomColors;
            colorDialog.FullOpen = false;
            colorDialog.ShowDialog();
        }

        private Color[] colors = new Color[]
        { 
            Color.FromRgb(0, 75, 133),Color.FromRgb(6, 82, 42),Color.FromRgb(232, 125, 29),Color.FromRgb(117, 5, 14),
            Color.FromRgb(0, 127, 177),Color.FromRgb(194, 123, 19),Color.FromRgb(194, 123, 19),Color.FromRgb(255, 59, 148),
            Color.FromRgb(0, 174, 197),Color.FromRgb(194, 205, 35), Color.FromRgb(166, 132, 98),Color.FromRgb(162, 27, 112),
            Color.FromRgb(25, 147, 81),Color.FromRgb(238, 178, 17), Color.FromRgb(181, 17, 26), Color.FromRgb(88, 32, 140)
        };

        //private Color[] colors = new Color[]
        //{ 
        //    Color.FromRgb(0, 75, 133), Color.FromRgb(0, 127, 177), Color.FromRgb(0, 174, 197), Color.FromRgb(25, 147, 81),

        //    Color.FromRgb(6, 82, 42), Color.FromRgb(109, 141, 35), Color.FromRgb(194, 205, 35), Color.FromRgb(238, 178, 17), 

        //    Color.FromRgb(232, 125, 29), Color.FromRgb(194, 123, 19), Color.FromRgb(166, 132, 98), Color.FromRgb(181, 17, 26), 

        //    Color.FromRgb(117, 5, 14), Color.FromRgb(255, 59, 148), Color.FromRgb(162, 27, 112), Color.FromRgb(88, 32, 140)
        //};

        /// <summary>
        /// Gets the custom colors.
        /// </summary>
        /// <value>The custom colors.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "ok")]
        public int[] CustomColors
        {
            get
            {
                if (customColors == null)
                {
                    customColors = GetColors();
                }

                return customColors;
            }
        }

        /// <summary>
        /// Gets the colors.
        /// </summary>
        /// <returns>The list of custom colors</returns>
        private int[] GetColors()
        {
            int[] clrs = new int[16];
            for (int i = 0; i < 16; i++)
            {
                clrs[i] = colors[i].B << 16 | colors[i].G << 8 | colors[i].R;
            }

            return clrs;
        }
    }
}
