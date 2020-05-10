using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridAndXML
{
    public partial class Form1 : Form
    {
        private DataSet dsTemp = new DataSet("test");
        public Form1()
        {
            InitializeComponent();
            this.InitDataSet();
        }

        private void InitDataSet()
        {
            string filePath = "Fls.Core.Trend.xml";
            dsTemp.ReadXml(filePath);
            this.xmlTables.Items.Clear();
            foreach (DataTable tab in this.dsTemp.Tables)
            {
                this.xmlTables.Items.Add(tab.TableName);
            }

            this.dataGridView1.DataSource = dsTemp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.xmlTables.SelectedItem != null)
            {
                this.dataGridView1.DataMember = this.xmlTables.SelectedItem.ToString();
            }
        }
    }
}
