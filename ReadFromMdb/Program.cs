using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ReadFromMdb
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conn = null;
            OleDbDataReader reader = null;
            string connectionString = string.Empty;
            string dbPath = string.Empty;

            try
            {
                dbPath = "C:\\MyFolder\\Sample.mdb";

                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;
                conn = new OleDbConnection(connectionString);
                conn.Open();

                OleDbCommand cmd = new OleDbCommand("Select * FROM SampleTable", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                    Console.WriteLine(reader.GetString(1));
                }

                string fisrtName="Nikhil";
                string lastName = "Battula";
                //string insertQuery = "Insert into SampleTable ([FirstName], [LastName]) Values (@fisrtName, @lastName)";
                //cmd = new OleDbCommand(insertQuery, conn);
                //cmd.Parameters.Add(@fisrtName, OleDbType.VarChar, 50);
                //cmd.Parameters.Add(@lastName, OleDbType.VarChar, 50);
                //cmd.Parameters[@fisrtName].Value = fisrtName;
                //cmd.Parameters[@lastName].Value = lastName;

                string insertQuery = "Insert into SampleTable ([FirstName], [LastName]) Values " + "(" + "'" + fisrtName + "'" + "," + "'" + lastName + "'" + ")";
                cmd = new OleDbCommand(insertQuery, conn);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("Select * FROM SampleTable", conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                    Console.WriteLine(reader.GetString(1));
                }

                Console.Read();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (conn != null)
                    conn.Close();

            }
        }
    }
}
