using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoDotNetSqlParams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //"Data Source=(local);Initial Catalog=Fls.Core.Trend;Integrated Security=SSPI
            //string sqlConnectionString = "Persist Securit Info=Flase;Integrated Security=true;Initial Catalog=Fls.Core.Trend;server=(local)";
            string sqlConnectionString = "Data Source=(local);Initial Catalog=Fls.Core.Trend;Integrated Security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            try
            {
                sqlConnection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataSet ds = new DataSet();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string sqlQuery = "select * from [Fls.Core.Trend].[dbo].[Package] where PackageName='sin'";

            sqlCommand.CommandText = sqlQuery;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, sqlConnection);
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
