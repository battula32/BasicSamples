namespace Splitter
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(124, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(160, 262);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 262);
            this.treeView1.TabIndex = 1;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(121, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 262);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
    }
}

