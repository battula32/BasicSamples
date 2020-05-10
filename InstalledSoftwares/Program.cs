using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.IO;

namespace InstalledSoftwares
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInstalledApps();
            Console.Read();
        }

        private static void GetInstalledApps()
        {
            List<Software> softwareList = new List<Software>();

            string win32 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            GetSoftwaresForThisOs(softwareList, win32);
            string win64 = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            GetSoftwaresForThisOs(softwareList, win64);
            Console.WriteLine(softwareList.Count);
            GenerateFile(softwareList);
        }

        private static void GenerateFile(List<Software> softwareList)
        {
            string machineName = System.Environment.MachineName;
            using (StreamWriter sw = new StreamWriter("installedSoftwares_" + machineName + ".csv", false, Encoding.Unicode))
            {
                int i = 1;
                sw.Write("Sl.No");
                sw.Write('\t');
                sw.Write("Software Installed");
                sw.Write('\t');
                sw.Write("Publisher");
                sw.Write('\t');
                sw.Write("Machine name");
                sw.Write('\t');
                sw.Write("Is required for work");
                sw.Write('\t');
                sw.Write(sw.NewLine);
                foreach (var software in softwareList)
                {
                    sw.Write(i);
                    sw.Write('\t');
                    sw.Write(software.Name);
                    sw.Write('\t');
                    sw.Write(software.Publisher);
                    sw.Write('\t');
                    sw.Write(machineName);
                    sw.Write('\t');
                    sw.Write(@"Yes\No");
                    sw.Write(sw.NewLine);
                    i++;
                }

                sw.Close();
            }
        }

        private static void GetSoftwaresForThisOs(List<Software> softwareList, string uninstallKey)
        {
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    Software software = new Software();
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            string displayName = Convert.ToString(sk.GetValue("DisplayName"));
                            if (string.IsNullOrEmpty(displayName.Trim()))
                            {
                                continue;
                            }
                            else
                            {
                                software.Name = displayName;
                            }

                            string publisher = Convert.ToString(sk.GetValue("Publisher"));
                            if (string.IsNullOrEmpty(publisher))
                            {
                                software.Publisher = "Publisher un-known";
                            }
                            else
                            {
                                software.Publisher = publisher;
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    if (!softwareList.Contains(software))
                    {
                        softwareList.Add(software);
                    }
                }
            }
        }   
    }
}
