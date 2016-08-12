namespace Base_Oversight_Accumulator
{
    partial class AccountDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetailView));
            this.AccountDetailsBox = new System.Windows.Forms.GroupBox();
            this.UnfreezeAccountButton = new System.Windows.Forms.Button();
            this.AccountStatusField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.InventoryDueField = new System.Windows.Forms.TextBox();
            this.LastInventoryField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrganizationField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AccountNumberField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumROSItems = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumDRMOItems = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ECField = new System.Windows.Forms.TextBox();
            this.EquipmentCustodianLabel = new System.Windows.Forms.Label();
            this.TotalValueField = new System.Windows.Forms.TextBox();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            this.TotalAssetsField = new System.Windows.Forms.TextBox();
            this.TotalAssetsLabel = new System.Windows.Forms.Label();
            this.AccountAssets = new System.Windows.Forms.ListBox();
            this.AccountDRMO = new System.Windows.Forms.ListBox();
            this.AccountROS = new System.Windows.Forms.ListBox();
            this.AccountActionLog = new System.Windows.Forms.ListBox();
            this.AccountActionsBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.FreezeAccountButton = new System.Windows.Forms.Button();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.NoteBox = new System.Windows.Forms.GroupBox();
            this.AccountNotesField = new System.Windows.Forms.RichTextBox();
            this.AccountAssetsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AccountDetailsBox.SuspendLayout();
            this.AccountActionsBox.SuspendLayout();
            this.NoteBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountDetailsBox
            // 
            this.AccountDetailsBox.Controls.Add(this.UnfreezeAccountButton);
            this.AccountDetailsBox.Controls.Add(this.AccountStatusField);
            this.AccountDetailsBox.Controls.Add(this.label10);
            this.AccountDetailsBox.Controls.Add(this.InventoryDueField);
            this.AccountDetailsBox.Controls.Add(this.LastInventoryField);
            this.AccountDetailsBox.Controls.Add(this.label9);
            this.AccountDetailsBox.Controls.Add(this.label8);
            this.AccountDetailsBox.Controls.Add(this.OrganizationField);
            this.AccountDetailsBox.Controls.Add(this.label7);
            this.AccountDetailsBox.Controls.Add(this.AccountNumberField);
            this.AccountDetailsBox.Controls.Add(this.label6);
            this.AccountDetailsBox.Controls.Add(this.NumROSItems);
            this.AccountDetailsBox.Controls.Add(this.label5);
            this.AccountDetailsBox.Controls.Add(this.NumDRMOItems);
            this.AccountDetailsBox.Controls.Add(this.label4);
            this.AccountDetailsBox.Controls.Add(this.ECField);
            this.AccountDetailsBox.Controls.Add(this.EquipmentCustodianLabel);
            this.AccountDetailsBox.Controls.Add(this.TotalValueField);
            this.AccountDetailsBox.Controls.Add(this.TotalValueLabel);
            this.AccountDetailsBox.Controls.Add(this.TotalAssetsField);
            this.AccountDetailsBox.Controls.Add(this.TotalAssetsLabel);
            this.AccountDetailsBox.Location = new System.Drawing.Point(40, 36);
            this.AccountDetailsBox.Name = "AccountDetailsBox";
            this.AccountDetailsBox.Size = new System.Drawing.Size(907, 860);
            this.AccountDetailsBox.TabIndex = 0;
            this.AccountDetailsBox.TabStop = false;
            this.AccountDetailsBox.Text = "Account Details";
            this.AccountDetailsBox.Enter += new System.EventHandler(this.AccountDetailsBox_Enter);
            // 
            // UnfreezeAccountButton
            // 
            this.UnfreezeAccountButton.Location = new System.Drawing.Point(533, 774);
            this.UnfreezeAccountButton.Name = "UnfreezeAccountButton";
            this.UnfreezeAccountButton.Size = new System.Drawing.Size(202, 53);
            this.UnfreezeAccountButton.TabIndex = 20;
            this.UnfreezeAccountButton.Text = "Unfreeze";
            this.UnfreezeAccountButton.UseVisualStyleBackColor = true;
            this.UnfreezeAccountButton.Visible = false;
            this.UnfreezeAccountButton.Click += new System.EventHandler(this.UnfreezeAccountButton_Click);
            // 
            // AccountStatusField
            // 
            this.AccountStatusField.BackColor = System.Drawing.SystemColors.Control;
            this.AccountStatusField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountStatusField.Location = new System.Drawing.Point(379, 786);
            this.AccountStatusField.Name = "AccountStatusField";
            this.AccountStatusField.ReadOnly = true;
            this.AccountStatusField.Size = new System.Drawing.Size(125, 31);
            this.AccountStatusField.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 785);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "Account Status:";
            // 
            // InventoryDueField
            // 
            this.InventoryDueField.BackColor = System.Drawing.SystemColors.Control;
            this.InventoryDueField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryDueField.Location = new System.Drawing.Point(379, 718);
            this.InventoryDueField.Name = "InventoryDueField";
            this.InventoryDueField.ReadOnly = true;
            this.InventoryDueField.Size = new System.Drawing.Size(400, 31);
            this.InventoryDueField.TabIndex = 17;
            this.InventoryDueField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastInventoryField
            // 
            this.LastInventoryField.BackColor = System.Drawing.SystemColors.Control;
            this.LastInventoryField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastInventoryField.Location = new System.Drawing.Point(379, 639);
            this.LastInventoryField.Name = "LastInventoryField";
            this.LastInventoryField.ReadOnly = true;
            this.LastInventoryField.Size = new System.Drawing.Size(400, 31);
            this.LastInventoryField.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 718);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "Inventory Due:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 639);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Inventory:";
            // 
            // OrganizationField
            // 
            this.OrganizationField.BackColor = System.Drawing.SystemColors.Control;
            this.OrganizationField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrganizationField.Location = new System.Drawing.Point(379, 568);
            this.OrganizationField.Name = "OrganizationField";
            this.OrganizationField.ReadOnly = true;
            this.OrganizationField.Size = new System.Drawing.Size(400, 31);
            this.OrganizationField.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Organization:";
            // 
            // AccountNumberField
            // 
            this.AccountNumberField.BackColor = System.Drawing.SystemColors.Control;
            this.AccountNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountNumberField.Location = new System.Drawing.Point(379, 494);
            this.AccountNumberField.Name = "AccountNumberField";
            this.AccountNumberField.ReadOnly = true;
            this.AccountNumberField.Size = new System.Drawing.Size(400, 31);
            this.AccountNumberField.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Acct#:";
            // 
            // NumROSItems
            // 
            this.NumROSItems.BackColor = System.Drawing.SystemColors.Control;
            this.NumROSItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumROSItems.Location = new System.Drawing.Point(379, 416);
            this.NumROSItems.Name = "NumROSItems";
            this.NumROSItems.ReadOnly = true;
            this.NumROSItems.Size = new System.Drawing.Size(400, 31);
            this.NumROSItems.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of ROS Items:";
            // 
            // NumDRMOItems
            // 
            this.NumDRMOItems.BackColor = System.Drawing.SystemColors.Control;
            this.NumDRMOItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumDRMOItems.Location = new System.Drawing.Point(379, 343);
            this.NumDRMOItems.Name = "NumDRMOItems";
            this.NumDRMOItems.ReadOnly = true;
            this.NumDRMOItems.Size = new System.Drawing.Size(400, 31);
            this.NumDRMOItems.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of DRMO Items:";
            // 
            // ECField
            // 
            this.ECField.BackColor = System.Drawing.SystemColors.Control;
            this.ECField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ECField.Location = new System.Drawing.Point(379, 267);
            this.ECField.Name = "ECField";
            this.ECField.ReadOnly = true;
            this.ECField.Size = new System.Drawing.Size(400, 31);
            this.ECField.TabIndex = 5;
            this.ECField.TextChanged += new System.EventHandler(this.ECField_TextChanged);
            // 
            // EquipmentCustodianLabel
            // 
            this.EquipmentCustodianLabel.AutoSize = true;
            this.EquipmentCustodianLabel.Location = new System.Drawing.Point(43, 266);
            this.EquipmentCustodianLabel.Name = "EquipmentCustodianLabel";
            this.EquipmentCustodianLabel.Size = new System.Drawing.Size(296, 32);
            this.EquipmentCustodianLabel.TabIndex = 4;
            this.EquipmentCustodianLabel.Text = "Equipment Custodian:";
            // 
            // TotalValueField
            // 
            this.TotalValueField.BackColor = System.Drawing.SystemColors.Control;
            this.TotalValueField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalValueField.Location = new System.Drawing.Point(379, 186);
            this.TotalValueField.Name = "TotalValueField";
            this.TotalValueField.ReadOnly = true;
            this.TotalValueField.Size = new System.Drawing.Size(400, 31);
            this.TotalValueField.TabIndex = 3;
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Location = new System.Drawing.Point(23, 186);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(317, 32);
            this.TotalValueLabel.TabIndex = 2;
            this.TotalValueLabel.Text = "Total Value (estimated):";
            // 
            // TotalAssetsField
            // 
            this.TotalAssetsField.BackColor = System.Drawing.SystemColors.Control;
            this.TotalAssetsField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalAssetsField.Location = new System.Drawing.Point(379, 111);
            this.TotalAssetsField.Name = "TotalAssetsField";
            this.TotalAssetsField.ReadOnly = true;
            this.TotalAssetsField.Size = new System.Drawing.Size(400, 31);
            this.TotalAssetsField.TabIndex = 1;
            // 
            // TotalAssetsLabel
            // 
            this.TotalAssetsLabel.AutoSize = true;
            this.TotalAssetsLabel.Location = new System.Drawing.Point(160, 111);
            this.TotalAssetsLabel.Name = "TotalAssetsLabel";
            this.TotalAssetsLabel.Size = new System.Drawing.Size(179, 32);
            this.TotalAssetsLabel.TabIndex = 0;
            this.TotalAssetsLabel.Text = "Total Assets:";
            // 
            // AccountAssets
            // 
            this.AccountAssets.FormattingEnabled = true;
            this.AccountAssets.ItemHeight = 31;
            this.AccountAssets.Location = new System.Drawing.Point(40, 990);
            this.AccountAssets.Name = "AccountAssets";
            this.AccountAssets.Size = new System.Drawing.Size(617, 779);
            this.AccountAssets.TabIndex = 1;
            // 
            // AccountDRMO
            // 
            this.AccountDRMO.FormattingEnabled = true;
            this.AccountDRMO.ItemHeight = 31;
            this.AccountDRMO.Location = new System.Drawing.Point(683, 990);
            this.AccountDRMO.Name = "AccountDRMO";
            this.AccountDRMO.Size = new System.Drawing.Size(519, 779);
            this.AccountDRMO.TabIndex = 2;
            // 
            // AccountROS
            // 
            this.AccountROS.FormattingEnabled = true;
            this.AccountROS.ItemHeight = 31;
            this.AccountROS.Location = new System.Drawing.Point(1229, 990);
            this.AccountROS.Name = "AccountROS";
            this.AccountROS.Size = new System.Drawing.Size(879, 779);
            this.AccountROS.TabIndex = 3;
            this.AccountROS.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AccountActionLog
            // 
            this.AccountActionLog.FormattingEnabled = true;
            this.AccountActionLog.ItemHeight = 31;
            this.AccountActionLog.Location = new System.Drawing.Point(20, 37);
            this.AccountActionLog.Name = "AccountActionLog";
            this.AccountActionLog.Size = new System.Drawing.Size(1789, 376);
            this.AccountActionLog.TabIndex = 4;
            // 
            // AccountActionsBox
            // 
            this.AccountActionsBox.Controls.Add(this.button2);
            this.AccountActionsBox.Controls.Add(this.button1);
            this.AccountActionsBox.Controls.Add(this.DeleteAccountButton);
            this.AccountActionsBox.Controls.Add(this.FreezeAccountButton);
            this.AccountActionsBox.Controls.Add(this.GenerateReportButton);
            this.AccountActionsBox.Location = new System.Drawing.Point(2138, 973);
            this.AccountActionsBox.Name = "AccountActionsBox";
            this.AccountActionsBox.Size = new System.Drawing.Size(700, 796);
            this.AccountActionsBox.TabIndex = 5;
            this.AccountActionsBox.TabStop = false;
            this.AccountActionsBox.Text = "Account Actions";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(630, 77);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add Note";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(630, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(29, 497);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(630, 77);
            this.DeleteAccountButton.TabIndex = 7;
            this.DeleteAccountButton.Text = "Delete";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // FreezeAccountButton
            // 
            this.FreezeAccountButton.Location = new System.Drawing.Point(29, 355);
            this.FreezeAccountButton.Name = "FreezeAccountButton";
            this.FreezeAccountButton.Size = new System.Drawing.Size(630, 74);
            this.FreezeAccountButton.TabIndex = 6;
            this.FreezeAccountButton.Text = "Freeze";
            this.FreezeAccountButton.UseVisualStyleBackColor = true;
            this.FreezeAccountButton.Click += new System.EventHandler(this.FreezeAccountButton_Click);
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(29, 215);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(630, 71);
            this.GenerateReportButton.TabIndex = 0;
            this.GenerateReportButton.Text = "Generate Report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            // 
            // NoteBox
            // 
            this.NoteBox.Controls.Add(this.AccountNotesField);
            this.NoteBox.Location = new System.Drawing.Point(997, 489);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(1841, 448);
            this.NoteBox.TabIndex = 6;
            this.NoteBox.TabStop = false;
            this.NoteBox.Text = "Notes";
            // 
            // AccountNotesField
            // 
            this.AccountNotesField.Location = new System.Drawing.Point(26, 38);
            this.AccountNotesField.Name = "AccountNotesField";
            this.AccountNotesField.Size = new System.Drawing.Size(1783, 391);
            this.AccountNotesField.TabIndex = 0;
            this.AccountNotesField.Text = "";
            // 
            // AccountAssetsLabel
            // 
            this.AccountAssetsLabel.AutoSize = true;
            this.AccountAssetsLabel.Location = new System.Drawing.Point(34, 955);
            this.AccountAssetsLabel.Name = "AccountAssetsLabel";
            this.AccountAssetsLabel.Size = new System.Drawing.Size(108, 32);
            this.AccountAssetsLabel.TabIndex = 7;
            this.AccountAssetsLabel.Text = "Assets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 955);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "DRMO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1223, 955);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "ROS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AccountActionLog);
            this.groupBox1.Location = new System.Drawing.Point(997, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1841, 447);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action Log:";
            // 
            // AccountDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3213, 1846);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountAssetsLabel);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.AccountActionsBox);
            this.Controls.Add(this.AccountROS);
            this.Controls.Add(this.AccountDRMO);
            this.Controls.Add(this.AccountAssets);
            this.Controls.Add(this.AccountDetailsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountDetailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = " Account Details";
            this.Load += new System.EventHandler(this.AccountDetailView_Load);
            this.AccountDetailsBox.ResumeLayout(false);
            this.AccountDetailsBox.PerformLayout();
            this.AccountActionsBox.ResumeLayout(false);
            this.NoteBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountDetailsBox;
        private System.Windows.Forms.TextBox TotalValueField;
        private System.Windows.Forms.Label TotalValueLabel;
        private System.Windows.Forms.TextBox TotalAssetsField;
        private System.Windows.Forms.Label TotalAssetsLabel;
        private System.Windows.Forms.ListBox AccountAssets;
        private System.Windows.Forms.TextBox ECField;
        private System.Windows.Forms.Label EquipmentCustodianLabel;
        private System.Windows.Forms.ListBox AccountDRMO;
        private System.Windows.Forms.ListBox AccountROS;
        private System.Windows.Forms.ListBox AccountActionLog;
        private System.Windows.Forms.GroupBox AccountActionsBox;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Button FreezeAccountButton;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.GroupBox NoteBox;
        private System.Windows.Forms.RichTextBox AccountNotesField;
        private System.Windows.Forms.Label AccountAssetsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumROSItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumDRMOItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrganizationField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AccountNumberField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InventoryDueField;
        private System.Windows.Forms.TextBox LastInventoryField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AccountStatusField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button UnfreezeAccountButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}