namespace Treview_Control
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Child1");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Child2");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Parant", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("child");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Parant", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Grand_parant", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Node1";
            treeNode13.Text = "Child1";
            treeNode14.Name = "Node2";
            treeNode14.Text = "Child2";
            treeNode15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            treeNode15.ForeColor = System.Drawing.Color.Black;
            treeNode15.Name = "Node0";
            treeNode15.Text = "Parant";
            treeNode16.Name = "Node5";
            treeNode16.Text = "child";
            treeNode17.Name = "Node4";
            treeNode17.Text = "Parant";
            treeNode18.Name = "Node3";
            treeNode18.Text = "Grand_parant";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(1206, 618);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 618);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

