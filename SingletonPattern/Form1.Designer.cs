namespace SingletonPattern
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
            this.cmdSingleton = new System.Windows.Forms.Button();
            this.cmdCompare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSingleton
            // 
            this.cmdSingleton.Location = new System.Drawing.Point(64, 44);
            this.cmdSingleton.Name = "cmdSingleton";
            this.cmdSingleton.Size = new System.Drawing.Size(170, 30);
            this.cmdSingleton.TabIndex = 0;
            this.cmdSingleton.Text = "Singleton with static instance";
            this.cmdSingleton.UseVisualStyleBackColor = true;
            this.cmdSingleton.Click += new System.EventHandler(this.cmdSingleton_Click);
            // 
            // cmdCompare
            // 
            this.cmdCompare.Location = new System.Drawing.Point(68, 93);
            this.cmdCompare.Name = "cmdCompare";
            this.cmdCompare.Size = new System.Drawing.Size(165, 30);
            this.cmdCompare.TabIndex = 1;
            this.cmdCompare.Text = "Compare Instances";
            this.cmdCompare.UseVisualStyleBackColor = true;
            this.cmdCompare.Click += new System.EventHandler(this.cmdCompare_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Other way to create singleton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "ThreadSync for singleton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdCompare);
            this.Controls.Add(this.cmdSingleton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSingleton;
        private System.Windows.Forms.Button cmdCompare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

