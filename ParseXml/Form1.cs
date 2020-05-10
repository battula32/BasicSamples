using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ParseXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //{ SelectedPath = this.txtFileName.Text };

            openFileDialog1.Filter = "Text Files (.xml)|*.xml|(.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (DialogResult.OK != dialogResult)
            {
                return;
            }

            this.txtFileName.Text = openFileDialog1.FileName;
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFileName.Text))
            {
                MessageBox.Show("Please choose file");
                return;
            }

            StringBuilder newFile = new StringBuilder();

            string fileName = this.txtFileName.Text;
            string[] file = File.ReadAllLines(fileName);

            //string fieldName = "<ParameterNameId>";
            string fieldName = "<ParameterNameId>";
            foreach (string line in file.Where(line => !line.Contains(fieldName)))
            {
                newFile.Append(line + "\r\n");
            }

            string resultFileName = string.Empty;
            if (!string.IsNullOrEmpty(txtResultFile.Text))
            {
                resultFileName = txtResultFile.Text;
            }
            else
            {
                resultFileName = this.txtFileName.Text;
            }

            File.WriteAllText(resultFileName, newFile.ToString());

            File.Exists(resultFileName);
        }
    }
}
