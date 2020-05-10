using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TemporaryTablesForSql
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Integrated Security=SSPI;" + "Initial Catalog=;" + "Data Source=localhost;";
            //string connectionString = "Data Source=Maa202092;Initial Catalog=Northwind;Integrated Security=True";


            SqlConnection conn = new SqlConnection(connectionString);//"Server=(local);DataBase=master;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            ////cmd.CommandText = "Declare @sSql varchar(1000) Set @sSql ='Use[?]; Select db_name(), rtrim(name), filename, Cast(size/128.0 As Decimal(10,2)), Cast(Fileproperty(name, ''SpaceUsed'')/128.0 As Decimal(10,2)) From dbo.sysfiles Order By groupId Desc;' Exec sp_MSforeachdb @sSql";
            ////SqlDataReader reader = cmd.ExecuteReader();
            ////double dbSize = double.NaN;
            ////double usedSpace = double.NaN;
            ////while (reader.HasRows)
            ////{
            ////    while (reader.Read())
            ////    {
            ////        Console.WriteLine("{0} {1} {2} {3} {4}", reader[0], reader[1], reader[2], reader[3], reader[4]);
            ////        if (double.IsNaN(dbSize))
            ////        {
            ////            double.TryParse(Convert.ToString(reader[3]), out dbSize);
            ////        }
            ////        else
            ////        {
            ////            double tempSize = double.NaN;
            ////            if (double.TryParse(Convert.ToString(reader[3]), out tempSize))
            ////            {
            ////                dbSize = dbSize + tempSize;
            ////            }
            ////        }

            ////        if (double.IsNaN(usedSpace))
            ////        {
            ////            double.TryParse(Convert.ToString(reader[4]), out usedSpace);
            ////        }
            ////        else
            ////        {
            ////            double tempUsedSpace = double.NaN;
            ////            if (double.TryParse(Convert.ToString(reader[4]), out tempUsedSpace))
            ////            {
            ////                usedSpace = usedSpace + tempUsedSpace;
            ////            }
            ////        }
            ////    }

            ////    reader.NextResult();
            ////}


            cmd.CommandText = "Create Table #dbInfo (sizeMg decimal(10,2) null,usedMg decimal(10,2) null) Declare @sSql varchar(1000) Set @sSql = 'Use [?]; Insert #dbInfo (sizeMg, usedMg) Select Cast(size/128.0 As Decimal(10,2)), Cast(Fileproperty(name, ''SpaceUsed'')/128.0 As Decimal(10,2)) From dbo.sysfiles Order By groupId Desc;' Exec sp_MSforeachdb @sSql select sum(sizeMg) Size,sum(UsedMg) UsedMg from #dbInfo drop table #dbInfo";
            SqlDataReader reader = cmd.ExecuteReader();
            double dbSize = double.NaN;
            double usedSpace = double.NaN;
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    Console.WriteLine(reader[0]);
                    Console.WriteLine(reader[1]);
                    double.TryParse(Convert.ToString(reader[0]), out dbSize);
                    double.TryParse(Convert.ToString(reader[1]), out usedSpace);
                }
            }

            if (dbSize != double.NaN && usedSpace != double.NaN)
            {
                double freeSpace = dbSize - usedSpace;
                Console.WriteLine("FreeSapce : {0}, UsedSpace : {1}, FreeSpacePercentage : {2}, UsedSapcePercentage : {3}", freeSpace, usedSpace, (freeSpace / dbSize) * 100, (usedSpace / dbSize) * 100);
            }

            Console.Read();
        }
    }
}
