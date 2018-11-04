namespace SchoolSoft_V1._2
{
    partial class TesteUnidade
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nó6");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nó0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nó7");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nó1", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nó8");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nó2", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nó9");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nó3", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nó10");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nó4", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nó5");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Aqua;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nó6";
            treeNode1.Text = "Nó6";
            treeNode2.Name = "Nó0";
            treeNode2.Text = "Nó0";
            treeNode3.Name = "Nó7";
            treeNode3.Text = "Nó7";
            treeNode4.Name = "Nó1";
            treeNode4.Text = "Nó1";
            treeNode5.Name = "Nó8";
            treeNode5.Text = "Nó8";
            treeNode6.Name = "Nó2";
            treeNode6.Text = "Nó2";
            treeNode7.Name = "Nó9";
            treeNode7.Text = "Nó9";
            treeNode8.Name = "Nó3";
            treeNode8.Text = "Nó3";
            treeNode9.Name = "Nó10";
            treeNode9.Text = "Nó10";
            treeNode10.Name = "Nó4";
            treeNode10.Text = "Nó4";
            treeNode11.Name = "Nó5";
            treeNode11.Text = "Nó5";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8,
            treeNode10,
            treeNode11});
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(178, 456);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(178, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 456);
            this.panel1.TabIndex = 1;
            // 
            // TesteUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "TesteUnidade";
            this.Text = "TesteUnidade";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
    }
}