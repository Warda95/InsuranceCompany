namespace InsuranceCompany
{
    partial class mainForm
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
            this.listApps = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAddType = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.Subtype = new System.Windows.Forms.Label();
            this.textAddSubtype = new System.Windows.Forms.TextBox();
            this.listCategory = new System.Windows.Forms.ListBox();
            this.dgvApp = new System.Windows.Forms.DataGridView();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applications";
            // 
            // listApps
            // 
            this.listApps.FormattingEnabled = true;
            this.listApps.Location = new System.Drawing.Point(12, 40);
            this.listApps.Name = "listApps";
            this.listApps.Size = new System.Drawing.Size(182, 82);
            this.listApps.TabIndex = 1;
            this.listApps.SelectedIndexChanged += new System.EventHandler(this.listApps_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // textAddType
            // 
            this.textAddType.Location = new System.Drawing.Point(389, 72);
            this.textAddType.Name = "textAddType";
            this.textAddType.Size = new System.Drawing.Size(106, 20);
            this.textAddType.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(389, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(501, 26);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(106, 23);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(613, 26);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(106, 23);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.Text = "Show Data";
            this.ShowButton.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(386, 56);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 8;
            this.Type.Text = "Type";
            // 
            // Subtype
            // 
            this.Subtype.AutoSize = true;
            this.Subtype.Location = new System.Drawing.Point(498, 56);
            this.Subtype.Name = "Subtype";
            this.Subtype.Size = new System.Drawing.Size(46, 13);
            this.Subtype.TabIndex = 10;
            this.Subtype.Text = "Subtype";
            // 
            // textAddSubtype
            // 
            this.textAddSubtype.Location = new System.Drawing.Point(501, 72);
            this.textAddSubtype.Name = "textAddSubtype";
            this.textAddSubtype.Size = new System.Drawing.Size(106, 20);
            this.textAddSubtype.TabIndex = 9;
            // 
            // listCategory
            // 
            this.listCategory.FormattingEnabled = true;
            this.listCategory.Location = new System.Drawing.Point(198, 40);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(182, 82);
            this.listCategory.TabIndex = 3;
            // 
            // dgvApp
            // 
            this.dgvApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApp.Location = new System.Drawing.Point(15, 182);
            this.dgvApp.Name = "dgvApp";
            this.dgvApp.Size = new System.Drawing.Size(368, 140);
            this.dgvApp.TabIndex = 11;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(389, 182);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(368, 140);
            this.dgvCategory.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 328);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(742, 150);
            this.dgv.TabIndex = 14;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(613, 72);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(106, 23);
            this.refreshButton.TabIndex = 15;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 486);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.dgvApp);
            this.Controls.Add(this.Subtype);
            this.Controls.Add(this.textAddSubtype);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textAddType);
            this.Controls.Add(this.listCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listApps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "mainForm";
            this.Text = "Insurance Company";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listApps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAddType;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Subtype;
        private System.Windows.Forms.TextBox textAddSubtype;
        private System.Windows.Forms.ListBox listCategory;
        private System.Windows.Forms.DataGridView dgvApp;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button refreshButton;
    }
}

