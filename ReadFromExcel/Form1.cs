using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadFromExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                string sql = null;
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='DayReport.xlsx';Extended Properties=Excel 8.0;";
                MyConnection = new System.Data.OleDb.OleDbConnection(connectionString);
                MyConnection.Open();
                myCommand.Connection = MyConnection;
                sql = "Insert into [Sheet1$] (id,name) values('5','e')";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                //MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='BM8 report card schedule - 2011-11-12T00.20.00.xls';Extended Properties=Excel 8.0;");
                //MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [DayReport$]", MyConnection);
                //MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='DayReport.xlsx';Extended Properties=Excel 8.0;");
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='DayReport.xlsx';Extended Properties=Excel 12.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dataGridView1.DataSource = DtSet.Tables[0];
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
