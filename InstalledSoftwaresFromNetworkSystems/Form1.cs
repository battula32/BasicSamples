using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace InstalledSoftwaresFromNetworkSystems
{
    /// <summary>
    /// This is tested in windows 7.
    /// </summary>
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
                if (string.IsNullOrEmpty(txtSystemName.Text))
                {
                    MessageBox.Show("Please enter system name");
                    return;
                }

                List<string> computerList = new List<string>();
                computerList.Add("CPH2-TBACE810-P");
                computerList.Add("CPH2-TB-BUF01-P");
                computerList.Add("CPH2-TB-BUF02-P");
                computerList.Add("CPH2-TB-BUF03-P");
                computerList.Add("CPH2-TB-CORE8-T");
                computerList.Add("CPH2-TBECC89-P");
                computerList.Add("CPH2-TB-ECCPE-P");
                computerList.Add("CPH2-TB-ECCRM-P");
                computerList.Add("CPH2-TB-ENMRM-P");
                computerList.Add("CPH2-TBFRMWRM-P");
                computerList.Add("CPH2-TB-KILN-P");
                computerList.Add("CPH2-TB-LIT01-T");
                computerList.Add("CPH2-TB-MACT8-P");
                computerList.Add("CPH2-TB-QCX84-P");
                computerList.Add("CPH2-TBQCXBLX-M");
                computerList.Add("CPH2-TB-QCXD84");
                computerList.Add("CPH2-TBQCXDRV-M");
                computerList.Add("CPH2-TB-QCXRM-P");
                computerList.Add("CPH2-TB-RAJRT-D");
                computerList.Add("CPH2-TB-SMX01-T");
                computerList.Add("CPH2-TBTFVS17-T");
                computerList.Add("CPH2-TFS-CEM-P");
                computerList.Add("CPH4-ACS-VS13-D");
                computerList.Add("CPH4-TB-CCR82-P");
                computerList.Add("CPH4-TB-HIS81-P");
                computerList.Add("CPH4-TFSIOTV8-P");
                computerList.Add("CPH4-TFSPXPM-P");
                computerList.Add("CPH4-TFSV7IOT-P");
                computerList.Add("CPH4-TFSVS17C-T");
                computerList.Add("CPH4-TIAV8-P");
                computerList.Add("CPH4-T-PLGIOT-P");
                computerList.Add("CPH-BXPCCR01-T");
                computerList.Add("CPH-BXPLEG01-T");
                computerList.Add("CPH-TB-BLX80-P");
                computerList.Add("CPH-TB-BXP-M-P");
                computerList.Add("CPH-TB-CEM-M-P");
                computerList.Add("CPH-TB-CORE15-P");
                computerList.Add("CPH-TB-CORE89-P");
                computerList.Add("CPH-TB-ECC88-P");
                computerList.Add("CPH-TB-ENMS-M-P");
                computerList.Add("CPH-TB-FDEV88-P");
                computerList.Add("CPH-TB-FRMW89-P");
                computerList.Add("CPH-TB-HIRE-M-P");
                computerList.Add("CPH-TB-HIST80-P");
                computerList.Add("CPH-TB-HIST-M-P");
                computerList.Add("CPH-TB-LANG-P");
                computerList.Add("CPH-TB-PX-M-P");
                computerList.Add("CPH-TB-QCX83-P");
                computerList.Add("CPH-TB-QCXD83-P");
                computerList.Add("CPH-TB-RVG01-T");
                computerList.Add("CPH-TB-SMC-M-P");
                computerList.Add("CPH-TB-SMX-M-P");
                computerList.Add("CPH-TB-SUV01-T");
                computerList.Add("CPH-TB-TA01-T");
                computerList.Add("CPH-TB-TA02-T");
                computerList.Add("CPH-TB-TA04-T");
                computerList.Add("CPH-TB-TAUTO-T");
                computerList.Add("CPH-TB-TREND-T");
                computerList.Add("CPH-TB-VS15-T");
                computerList.Add("CPH-TB-WXP80-P");
                computerList.Add("CPH-TB-WXP-M-P");
                computerList.Add("CPH-TFSB-ACE710");
                computerList.Add("CPH-TFSB-ACE7-M");
                computerList.Add("CPH-TFSB-ACE810");
                computerList.Add("CPH-TFSB-ACE8-M");
                computerList.Add("CPH-TFSB-BRAN01");
                computerList.Add("CPH-TFSB-BRAN02");
                computerList.Add("CPH-TFSB-BRAN04");
                computerList.Add("CPH-TFSB-BRAN05");
                computerList.Add("CPH-TFSB-BRAN06");
                computerList.Add("CPH-TFSB-BRAN08");
                computerList.Add("CPH-TFSB-BRAN09");
                computerList.Add("CPH-TFSB-BRAN10");
                computerList.Add("CPH-TFSB-BRAN13");
                computerList.Add("CPH-TFSB-BRAN14");
                computerList.Add("CPH-TFSB-BRAN15");
                computerList.Add("CPH-TFSB-CEM81");
                computerList.Add("CPH-TFSB-CEM82_RE");
                computerList.Add("CPH-TFSB-CEM-M");
                computerList.Add("CPH-TFSB-CORE82");
                computerList.Add("CPH-TFSB-CORE83");
                computerList.Add("CPH-TFSB-CORE85");
                computerList.Add("CPH-TFSB-CORE86");
                computerList.Add("CPH-TFSB-CORE87");
                computerList.Add("CPH-TFSB-CORE88");
                computerList.Add("CPH-TFSB-CORE-M");
                computerList.Add("CPH-TFSB-DOWNRM");
                computerList.Add("CPH-TFSB-ECC84");
                computerList.Add("CPH-TFSB-ECC85");
                computerList.Add("CPH-TFSB-ECC86");
                computerList.Add("CPH-TFSB-ECC87");
                computerList.Add("CPH-TFSB-ECC-M");
                computerList.Add("CPH-TFSB-EMUL87");
                computerList.Add("CPH-TFSB-EMUL-M");
                computerList.Add("CPH-TFSB-FDEV-M");
                computerList.Add("CPH-TFSB-FRMW86");
                computerList.Add("CPH-TFSB-FRMW87");
                computerList.Add("CPH-TFSB-FRMW88");
                computerList.Add("CPH-TFSB-FRMW-M");
                computerList.Add("CPH-TFSB-HMI10");
                computerList.Add("CPH-TFSB-HMI-M");
                computerList.Add("CPH-TFSB-IU10");
                computerList.Add("CPH-TFSB-IU-M");
                computerList.Add("CPH-TFSB-MACT7");
                computerList.Add("CPH-TFSB-MACT71");
                computerList.Add("CPH-TFSB-PXP81");
                computerList.Add("CPH-TFSB-PXP82");
                computerList.Add("CPH-TFSB-PXP-M");
                computerList.Add("CPH-TFSB-QCX82");
                computerList.Add("CPH-TFSB-QCXD82");
                computerList.Add("CPH-TFSB-QCXL81");
                computerList.Add("CPH-TFSB-QCXS82");
                computerList.Add("CPH-TFSB-STG-M");
                computerList.Add("CPH-TFSB-STSY10");
                computerList.Add("CPH-TFSB-STSY-M");
                computerList.Add("CPH-TFSB-THIRD-M");
                computerList.Add("CPH-TFSB-TPC-FRMW82");
                computerList.Add("CPH-TFSB-V8V7RM");
                computerList.Add("CPH-TFS-CLN");
                computerList.Add("CPH-TFS-CLNVS13");
                computerList.Add("CPH-TFS-CORE82");
                computerList.Add("CPH-TFS-DEV15-T");
                computerList.Add("CPH-TFS-PXP83-P");
                computerList.Add("CPH-TFS-TSTV14");
                computerList.Add("CPH-TFS-V8COURS");
                computerList.Add("CPH-TFSVS15CL-T");
                int counter = 0;
                using (StreamWriter sw = new StreamWriter("installedSoftwares" +  ".csv", false, Encoding.Unicode))
                {
                    CoumputerInfo computerInfo = new CoumputerInfo();
                    
                    computerInfo.UserName = @"fls\svc-tfsservice"; ////txtUserName.Text;
                    computerInfo.Password = "R1imfaxe";////txtPassword.Text;

                    foreach (var com in computerList)
                    {
                        computerInfo.ComputerName = com;
                        try
                        {
                            List<Software> programs = this.ReadRemoteRegistryusingWMI(computerInfo);
                            double ram = GetRam(computerInfo);
                            double hardDisk = GetHardDisk(computerInfo);
                            this.GenerateFile(programs, computerInfo, sw, ram, hardDisk);
                        }
                        catch
                        {
                            MessageBox.Show("com");
                        }
                        //this.ClearFields();
                        counter++;
                    }

                    sw.Close();
                }

                MessageBox.Show(string.Format("Software list .csv file is created no of computers passed:{0}, number of computers completed :{1}", computerList.Count, counter));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private double GetRam(CoumputerInfo computerInfo)
        {
            return 0.0d;
        }

        private double GetHardDisk(CoumputerInfo computerInfo)
        {
            return 0.0d;
        }

        private void ClearFields()
        {
            txtSystemName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private List<Software> ReadRemoteRegistryusingWMI(CoumputerInfo computerInfo)
        {
            List<Software> programs = new List<Software>();

            ConnectionOptions connectionOptions = new ConnectionOptions();
            connectionOptions.Username = computerInfo.UserName;
            connectionOptions.Password = computerInfo.Password;
            //connectionOptions.Impersonation = ImpersonationLevel.Impersonate;
            ManagementScope scope = new ManagementScope("\\\\" + computerInfo.ComputerName + "\\root\\CIMV2", connectionOptions);
            scope.Connect();

            string softwareRegLoc = @"Software\Microsoft\Windows\CurrentVersion\Uninstall";

            ManagementClass registry = new ManagementClass(scope, new ManagementPath("StdRegProv"), null);
            ManagementBaseObject inParams = registry.GetMethodParameters("EnumKey");
            inParams["hDefKey"] = 0x80000002;//HKEY_LOCAL_MACHINE
            inParams["sSubKeyName"] = softwareRegLoc;

            // Read Registry Key Names 
            ManagementBaseObject outParams = registry.InvokeMethod("EnumKey", inParams, null);
            string[] programGuids = outParams["sNames"] as string[];

            foreach (string subKeyName in programGuids)
            {
                inParams = registry.GetMethodParameters("GetStringValue");
                inParams["hDefKey"] = 0x80000002;//HKEY_LOCAL_MACHINE
                inParams["sSubKeyName"] = softwareRegLoc + @"\" + subKeyName;
                inParams["sValueName"] = "DisplayName";
                // Read Registry Value 
                outParams = registry.InvokeMethod("GetStringValue", inParams, null);
                Software softWare = new Software();
                if (outParams.Properties["sValue"].Value != null)
                {
                    string softwareName = outParams.Properties["sValue"].Value.ToString();
                    if (!softwareName.ToLower().Contains("security update for") &&
                        !softwareName.ToLower().Contains("update for windows") &&
                        !softwareName.ToLower().Contains("hotfix for"))
                    {

                        softWare.Name = softwareName;
                        inParams = registry.GetMethodParameters("GetStringValue");
                        inParams["hDefKey"] = 0x80000002;//HKEY_LOCAL_MACHINE
                        inParams["sSubKeyName"] = softwareRegLoc + @"\" + subKeyName;
                        inParams["sValueName"] = "Publisher";
                        // Read Registry Value 
                        outParams = registry.InvokeMethod("GetStringValue", inParams, null);
                        if (outParams.Properties["sValue"].Value != null)
                        {
                            softWare.Publisher = outParams.Properties["sValue"].Value.ToString();
                        }
                        else
                        {
                            softWare.Publisher = "Un-known";
                        }

                        programs.Add(softWare);
                    }
                }
            }

            return programs;
        }

        private bool GenerateFile(List<Software> softwareList, CoumputerInfo computerInfo, StreamWriter sw, double ram, double hardDisk)
        {
            ////using (StreamWriter sw = new StreamWriter("installedSoftwares_" + computerInfo.ComputerName + ".csv", false, Encoding.Unicode))
            ////{
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
            sw.Write(string.Format("Ram:{0}", ram));
            sw.Write('\t');
            sw.Write(string.Format("hardDisk:{0}", hardDisk));
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
                sw.Write(computerInfo.ComputerName);
                sw.Write('\t');
                sw.Write(@"Yes\No");
                sw.Write(sw.NewLine);
                i++;
            }

            ////    sw.Close();
            ////}

            ////MessageBox.Show("Software list .csv file is created");
            return true;
        }
    }
}
