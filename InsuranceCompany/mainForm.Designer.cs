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
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationCriteriaDependenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryAttributeDependenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryCriterionDepenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compensationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criterionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criterionValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policyTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(124, 26);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(106, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.userPanelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.applicationCriteriaDependenceToolStripMenuItem,
            this.attributeToolStripMenuItem,
            this.attributeValuesToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.categoryAttributeDependenceToolStripMenuItem,
            this.categoryCriterionDepenceToolStripMenuItem,
            this.compensationToolStripMenuItem,
            this.criterionToolStripMenuItem,
            this.criterionValuesToolStripMenuItem,
            this.damageToolStripMenuItem,
            this.policyToolStripMenuItem,
            this.policyTypeToolStripMenuItem,
            this.rateToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tableToolStripMenuItem.Text = "Table";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.applicationToolStripMenuItem.Text = "Application";
            this.applicationToolStripMenuItem.Click += new System.EventHandler(this.applicationToolStripMenuItem_Click);
            // 
            // applicationCriteriaDependenceToolStripMenuItem
            // 
            this.applicationCriteriaDependenceToolStripMenuItem.Name = "applicationCriteriaDependenceToolStripMenuItem";
            this.applicationCriteriaDependenceToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.applicationCriteriaDependenceToolStripMenuItem.Text = "ApplicationCriteriaDependence";
            this.applicationCriteriaDependenceToolStripMenuItem.Click += new System.EventHandler(this.applicationCriteriaDependenceToolStripMenuItem_Click);
            // 
            // attributeToolStripMenuItem
            // 
            this.attributeToolStripMenuItem.Name = "attributeToolStripMenuItem";
            this.attributeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.attributeToolStripMenuItem.Text = "Attribute";
            this.attributeToolStripMenuItem.Click += new System.EventHandler(this.attributeToolStripMenuItem_Click);
            // 
            // attributeValuesToolStripMenuItem
            // 
            this.attributeValuesToolStripMenuItem.Name = "attributeValuesToolStripMenuItem";
            this.attributeValuesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.attributeValuesToolStripMenuItem.Text = "AttributeValues";
            this.attributeValuesToolStripMenuItem.Click += new System.EventHandler(this.attributeValuesToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click_1);
            // 
            // categoryAttributeDependenceToolStripMenuItem
            // 
            this.categoryAttributeDependenceToolStripMenuItem.Name = "categoryAttributeDependenceToolStripMenuItem";
            this.categoryAttributeDependenceToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.categoryAttributeDependenceToolStripMenuItem.Text = "CategoryAttributeDependence";
            this.categoryAttributeDependenceToolStripMenuItem.Click += new System.EventHandler(this.categoryAttributeDependenceToolStripMenuItem_Click);
            // 
            // categoryCriterionDepenceToolStripMenuItem
            // 
            this.categoryCriterionDepenceToolStripMenuItem.Name = "categoryCriterionDepenceToolStripMenuItem";
            this.categoryCriterionDepenceToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.categoryCriterionDepenceToolStripMenuItem.Text = "CategoryCriterionDepence";
            this.categoryCriterionDepenceToolStripMenuItem.Click += new System.EventHandler(this.categoryCriterionDepenceToolStripMenuItem_Click);
            // 
            // compensationToolStripMenuItem
            // 
            this.compensationToolStripMenuItem.Name = "compensationToolStripMenuItem";
            this.compensationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.compensationToolStripMenuItem.Text = "Compensation";
            this.compensationToolStripMenuItem.Click += new System.EventHandler(this.compensationToolStripMenuItem_Click);
            // 
            // criterionToolStripMenuItem
            // 
            this.criterionToolStripMenuItem.Name = "criterionToolStripMenuItem";
            this.criterionToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.criterionToolStripMenuItem.Text = "Criterion";
            this.criterionToolStripMenuItem.Click += new System.EventHandler(this.criterionToolStripMenuItem_Click);
            // 
            // criterionValuesToolStripMenuItem
            // 
            this.criterionValuesToolStripMenuItem.Name = "criterionValuesToolStripMenuItem";
            this.criterionValuesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.criterionValuesToolStripMenuItem.Text = "CriterionValues";
            this.criterionValuesToolStripMenuItem.Click += new System.EventHandler(this.criterionValuesToolStripMenuItem_Click);
            // 
            // damageToolStripMenuItem
            // 
            this.damageToolStripMenuItem.Name = "damageToolStripMenuItem";
            this.damageToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.damageToolStripMenuItem.Text = "Damage";
            this.damageToolStripMenuItem.Click += new System.EventHandler(this.damageToolStripMenuItem_Click);
            // 
            // policyToolStripMenuItem
            // 
            this.policyToolStripMenuItem.Name = "policyToolStripMenuItem";
            this.policyToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.policyToolStripMenuItem.Text = "Policy";
            this.policyToolStripMenuItem.Click += new System.EventHandler(this.policyToolStripMenuItem_Click);
            // 
            // policyTypeToolStripMenuItem
            // 
            this.policyTypeToolStripMenuItem.Name = "policyTypeToolStripMenuItem";
            this.policyTypeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.policyTypeToolStripMenuItem.Text = "PolicyType";
            this.policyTypeToolStripMenuItem.Click += new System.EventHandler(this.policyTypeToolStripMenuItem_Click);
            // 
            // rateToolStripMenuItem
            // 
            this.rateToolStripMenuItem.Name = "rateToolStripMenuItem";
            this.rateToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.rateToolStripMenuItem.Text = "Rate";
            this.rateToolStripMenuItem.Click += new System.EventHandler(this.rateToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // userPanelToolStripMenuItem
            // 
            this.userPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.userPanelToolStripMenuItem.Name = "userPanelToolStripMenuItem";
            this.userPanelToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.userPanelToolStripMenuItem.Text = "User panel";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(24, 67);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(902, 419);
            this.dgv.TabIndex = 4;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(236, 26);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(106, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(348, 27);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete selected row";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(464, 28);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(100, 20);
            this.deleteBox.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 523);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "mainForm";
            this.Text = "Insurance Company";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationCriteriaDependenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributeValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryAttributeDependenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryCriterionDepenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compensationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criterionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criterionValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policyTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteBox;
    }
}

