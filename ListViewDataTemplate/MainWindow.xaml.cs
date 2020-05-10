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
using System.Collections.ObjectModel;

namespace ListViewDataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Items> itemsList;

        public MainWindow()
        {
            InitializeComponent();
        }

        public ObservableCollection<Items> ItemsList
        {
            get
            {
                if (this.itemsList == null)
                {
                    this.itemsList = new ObservableCollection<Items>();
                    itemsList.Add(new Items() { ItemName = "Item 1", Comment = "Comment 1", StartDate = DateTime.Now });
                    itemsList.Add(new Items() { ItemName = "Item 2", Comment = "Comment 2", StartDate = DateTime.Now.AddDays(-1) });
                    itemsList.Add(new Items() { ItemName = "Item 3", Comment = "Comment 3", StartDate = DateTime.Now.AddDays(-2) });
                }

                return this.itemsList;
            }
        }
    }
}
