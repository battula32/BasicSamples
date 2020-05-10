using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadDataFromSQLTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ConnectTodataBase();
        }

        private void ConnectTodataBase()
        {
            BugSystemDataContext dataContext = new BugSystemDataContext();
            var bugsData = from bugsTable in dataContext.Bugs select bugsTable;
            bugsList.Items.Clear();
            this.dataGridView1.DataSource = bugsData;
            foreach (var bugsTablerow in bugsData)
            {
                bugsList.Items.Add(bugsTablerow.BugName +"" + bugsTablerow.BugDescription);
            }

            var productData = from productsTable in dataContext.Products select productsTable;
            this.dataGridView2.DataSource = productData; 
            productsList.Items.Clear();
            foreach (var productRow in productData)
            {
                productsList.Items.Add(productRow.ProductName);
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter/ Form accept button is pressed");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel/ Form cancel button is pressed");
        }

        private void addBugData_Click(object sender, EventArgs e)
        {
            BugSystemDataContext dataContext = new BugSystemDataContext();
            Bug bug = new Bug();
            bug.BugId = Guid.NewGuid();
            bug.BugName = "Test bug";
            bug.ProductId = Guid.Parse("AE820719-6AA1-4E7F-B7FE-5614FEC2A4CB");
            dataContext.Bugs.InsertOnSubmit(bug);
            dataContext.SubmitChanges();
        }
    }
}
