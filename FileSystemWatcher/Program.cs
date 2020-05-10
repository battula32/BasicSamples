using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileSystemWatcherNS
{
    class Program
    {
        static FileSystemWatcher fileWatcher = new FileSystemWatcher();
        static void Main(string[] args)
        {
            fileWatcher.Filter = "*txt";
            fileWatcher.Path = @"D:\BRBLapTop\D\TestSamples\BasicSamples\BasicSample\FileSystemWatcher\bin\Debug";
            fileWatcher.EnableRaisingEvents = true;
            fileWatcher.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite| NotifyFilters.Attributes;
            fileWatcher.Created += new FileSystemEventHandler(fileWatcher_Created);
            fileWatcher.Changed += new FileSystemEventHandler(fileWatcher_Changed);
            fileWatcher.Deleted += new FileSystemEventHandler(fileWatcher_Deleted);
            Console.Read();
        }

        static void fileWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File deleted {0}", e.Name);
        }

        static void fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Modified {0}", e.Name);
        }

        static void fileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Created {0}", e.Name);
        }
    }
}
