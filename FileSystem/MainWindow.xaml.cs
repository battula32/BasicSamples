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
using System.IO;
using System.IO.Compression;

namespace FileSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DriveInformation();
        }

        private void DriveInformation()
        {
            foreach(DriveInfo dr in DriveInfo.GetDrives())
            {
                string driveinfo = string.Empty;
                float usedSpacePercent = 0;
                if (dr.IsReady)
                {
                    driveinfo = dr.Name + " - " + dr.DriveType + "," + dr.AvailableFreeSpace + "," + dr.TotalSize + ", root directory - "+ dr.RootDirectory;
                    usedSpacePercent = (dr.TotalSize - dr.AvailableFreeSpace) * 100 / dr.TotalSize;
                }
                else
                {
                    driveinfo = dr.Name + " - " + dr.DriveType +", root directory - "+ dr.RootDirectory;
                }

                this.listBox.Items.Add(driveinfo);
                if (dr.IsReady && dr.DriveType == DriveType.Fixed)
                {
                    string message = string.Format("{0} - used space percentage {1}", dr.Name, usedSpacePercent);
                    this.listBox.Items.Add(message);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileSystemWatcher fsw = new FileSystemWatcher(@"C:\");
            ////fsw.NotifyFilter = NotifyFilters.DirectoryName | NotifyFilters.CreationTime;
            fsw.IncludeSubdirectories = true;
            fsw.EnableRaisingEvents = true;
            fsw.Changed += new FileSystemEventHandler(fsw_Changed);
            fsw.Deleted += new FileSystemEventHandler(fsw_Deleted);
        }

        void fsw_Deleted(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(e.Name, e.ChangeType.ToString());
        }

        void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            // Write this into some file and cjeck condition if the file nor equal to current file
            // This may not be wise to monitor the changed to directory root.
            MessageBox.Show(e.Name, e.ChangeType.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextReader tr = File.OpenText("Hello.txt");
            Console.Write(tr.ReadToEnd());
            tr.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Hello.txt");
            string input;
            while ((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

            sr.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.log", FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);
            StreamReader sr = new StreamReader("Hello.txt");

            for (int i = 0; i < 10; i++)
            {
                w.Write((int)i);
            }

            w.Close();
            fs.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.log", FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.ReadInt32());
            }

            r.Close();
            fs.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            sw.WriteLine("Hello !");
            sw.WriteLine("Battula");
            sw.Close();

            StringReader sr = new StringReader(sb.ToString());
            Console.WriteLine(sr.ReadToEnd());

            //// Here you have to hjustify why you used string writer, you can read direcly string builder/string to read string.
            ////If you need to provide a stream input of if you have stream parameter then may be you can use.
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);
            sw.WriteLine("Hello ! Battula");

            sw.Flush();
            if (File.Exists("Memeory.txt"))
            {
                ms.WriteTo(File.Open("Memeory.txt", FileMode.Append));
            }
            else
            {
                ms.WriteTo(File.Open("Memeory.txt", FileMode.Create));
            }

            ms.Flush();
            ms.Close();
            sw.Close();

            TextReader tr = File.OpenText("Memeory.txt");
            Console.Write(tr.ReadToEnd());
            tr.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            GZipStream zipStream = new GZipStream(File.Create("data.zip"), CompressionMode.Compress);

            StreamWriter sw = new StreamWriter(zipStream);
            for (int i = 0; i < 1000; i++)
            {
                sw.WriteLine("Hello ! Battula");
            }

            sw.Close();
            zipStream.Close();

            GZipStream zipOpen = new GZipStream(File.OpenRead("data.Zip"), CompressionMode.Decompress);
            StreamReader sr = new StreamReader(zipOpen);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            zipOpen.Close();
        }
    }
}
