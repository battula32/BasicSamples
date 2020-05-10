namespace ParseXml
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cmdChooseFile = new System.Windows.Forms.Button();
            this.txtResultFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.txtFiledName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose file";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(138, 23);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(176, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // cmdChooseFile
            // 
            this.cmdChooseFile.Location = new System.Drawing.Point(320, 24);
            this.cmdChooseFile.Name = "cmdChooseFile";
            this.cmdChooseFile.Size = new System.Drawing.Size(31, 19);
            this.cmdChooseFile.TabIndex = 2;
            this.cmdChooseFile.Text = "...";
            this.cmdChooseFile.UseVisualStyleBackColor = true;
            this.cmdChooseFile.Click += new System.EventHandler(this.cmdChooseFile_Click);
            // 
            // txtResultFile
            // 
            this.txtResultFile.Location = new System.Drawing.Point(138, 104);
            this.txtResultFile.Name = "txtResultFile";
            this.txtResultFile.Size = new System.Drawing.Size(176, 20);
            this.txtResultFile.TabIndex = 4;
            this.txtResultFile.Text = "Temp.xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New file name";
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(188, 140);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(126, 35);
            this.cmdGenerate.TabIndex = 5;
            this.cmdGenerate.Text = "Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // txtFiledName
            // 
            this.txtFiledName.Location = new System.Drawing.Point(138, 66);
            this.txtFiledName.Name = "txtFiledName";
            this.txtFiledName.Size = new System.Drawing.Size(176, 20);
            this.txtFiledName.TabIndex = 7;
            this.txtFiledName.Text = "<ParameterNameId>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Field name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 521);
            this.Controls.Add(this.txtFiledName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.txtResultFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdChooseFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Modify file content";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button cmdChooseFile;
        private System.Windows.Forms.TextBox txtResultFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.TextBox txtFiledName;
        private System.Windows.Forms.Label label3;
    }
}

