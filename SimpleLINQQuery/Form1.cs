using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SimpleLINQQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            string startFolder = @"C:\V8Production";
            string otherPath = @"C:\V7\Stg";
            // Take a snapshot of the file system.
            IEnumerable<System.IO.FileInfo> fileList = GetFiles(startFolder);

            IEnumerable<System.IO.FileInfo> fileListOther = GetFiles(otherPath);

            var Files = from file in fileList
                        select new
                        {
                            file.CreationTime,
                            file.FullName
                        };

            var myFiles = from file in fileList select file;
            DateTime datetime = Convert.ToDateTime("8/28/2012 7:10 PM");
            var sortedBydate = (from file in fileList orderby file.LastWriteTime descending where file.LastWriteTime <= datetime select file).Take(10);
            //dataGridView1.DataSource = myFiles.ToList();

            dataGridView1.DataSource = sortedBydate.ToList();

            //var result = from F in fileList
            //             join S in fileListOther on F.Extension equals S.Extension
            //             select new
            //             {
            //                 F.CreationTime,
            //                 F.FullName,
            //                 S.DirectoryName,
            //                 S.Extension,
            //             };

            //var resultNew = from F in fileList
            //                from S in fileListOther
            //                where F.Name == S.Name
            //                select new
            //                {
            //                    F.CreationTime,
            //                    F.FullName,
            //                    S.Extension,
            //                    S.DirectoryName
            //                };

            ////var result = from F in fileList
            ////             join S in fileListOther on F.Name equals S.Name
            ////             select new
            ////             {
            ////                 F.CreationTime,
            ////                 F.FullName,
            ////                 S.Name,
            ////                 S.DirectoryName,
            ////                 S.Extension
            ////             };

            ////dataGridView1.DataSource = result.ToList();
        }

        private object GetSortedFiles(IEnumerable<System.IO.FileInfo> fileList)
        {
            var myFiles = (from file in fileList orderby file.LastWriteTime select file).Take(10);
            return myFiles;
        }

        // This method assumes that the application has discovery 
        // permissions for all folders under the specified path.
        static IEnumerable<System.IO.FileInfo> GetFiles(string path)
        {
            if (!System.IO.Directory.Exists(path))
                throw new System.IO.DirectoryNotFoundException();

            string[] fileNames = null;
            List<System.IO.FileInfo> files = new List<System.IO.FileInfo>();

            fileNames = System.IO.Directory.GetFiles(path, "*.*", System.IO.SearchOption.AllDirectories);
            foreach (string name in fileNames)
            {
                files.Add(new System.IO.FileInfo(name));
            }
            return files;
        }
        // This method assumes that the application has discovery 
        // permissions for all folders under the specified path.
        static IEnumerable<System.IO.FileInfo> GetFilesOther(string path)
        {
            if (!System.IO.Directory.Exists(path))
                throw new System.IO.DirectoryNotFoundException();

            string[] fileNames = null;
            List<System.IO.FileInfo> files = new List<System.IO.FileInfo>();

            fileNames = System.IO.Directory.GetFiles(path, "*.*", System.IO.SearchOption.AllDirectories);
            foreach (string name in fileNames)
            {
                files.Add(new System.IO.FileInfo(name));
            }
            return files;
        }
    }
}
