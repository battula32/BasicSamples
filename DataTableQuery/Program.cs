using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            ////DataSet ds = new DataSet();
            ////DataTable dt = new DataTable();
            ////DataColumnCollection dcc = new DataColumnCollection();
            ////DataColumn dc = new DataColumn("")
            List<SomeData> datas = new List<SomeData>();
            SomeData dt = new SomeData();
            dt.Name = "Name1";
            dt.IsAnalog = true;
            dt.InputAllowed = "true";
            dt.ShowType = '2';
            datas.Add(dt);

            dt = new SomeData();
            dt.Name = "Name2";
            dt.IsAnalog = true;
            dt.InputAllowed = "true";
            dt.ShowType = '2';
            datas.Add(dt);

            dt = new SomeData();
            dt.Name = "Name3";
            dt.IsAnalog = true;
            dt.InputAllowed = "true";
            dt.ShowType = '1';
            datas.Add(dt);

            var items = datas.Select(x => x.IsAnalog ? x.InputAllowed == "true" && x.ShowType != '2' : x.InputAllowed == "true" && x.ShowType != '1').ToList();
            //var item  = from x in datas where x.IsAnalog ? x.InputAllowed == "true" && x.ShowType != '2' : x.InputAllowed == "true" && x.ShowType != '1')
            Console.WriteLine(items.Count());
            Console.Read();
        }
    }
}
