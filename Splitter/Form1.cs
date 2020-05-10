using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.InitData();
        }

        private void InitData()
        {
            treeView1.Nodes.Add("One");
            treeView1.Nodes.Add("two");
            treeView1.Nodes.Add("three");
            treeView1.Nodes[0].Nodes.Add("One-One");
            treeView1.Nodes[0].Nodes.Add("One-Two");
            treeView1.Nodes[0].Nodes.Add("One-Three");
            treeView1.Nodes[1].Nodes.Add("Two-One");
            treeView1.Nodes[1].Nodes.Add("Two-Two");

            ListViewItem item1 = new ListViewItem(new string[]{"Data1", "Data2", "Data3"});
            ListViewItem item2 = new ListViewItem(new string[] { "Item1", "Item2", "Item3" });
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.View = View.List;
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            treeView1.DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                e.Effect = DragDropEffects.Copy;
                TreeNode tn = (TreeNode)e.Data.GetData(typeof(TreeNode));
                listView1.Items.Add(tn.Text);
            }
            else if (e.Data.GetDataPresent(typeof(string)))
            {
                string str = Convert.ToString(e.Data.GetData(typeof(string)));
                if (str.Length > 0)
                {
                    listView1.Items.Add(str);
                }
                else
                {
                    MessageBox.Show("you dropped empty string");
                }
            }
            else
            {
                System.Windows.Forms.DataObject obj =(System.Windows.Forms.DataObject)e.Data.GetData(typeof(System.Windows.Forms.DataObject));
                if (obj.ContainsText())
                {
                    listView1.Items.Add(obj.GetText());
                }
                else
                {
                    MessageBox.Show("You dropped some unknown format");
                }
            }
        }
    }
}
