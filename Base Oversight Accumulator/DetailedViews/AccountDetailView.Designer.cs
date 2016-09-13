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
            this.RefreshButton = new System.Windows.Forms.Button();
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
            this.AccountDetailsBox.Location = new System.Drawing.Point(30, 29);
            this.AccountDetailsBox.Margin = new System.Windows.Forms.Padding(2);
            this.AccountDetailsBox.Name = "AccountDetailsBox";
            this.AccountDetailsBox.Padding = new System.Windows.Forms.Padding(2);
            this.AccountDetailsBox.Size = new System.Drawing.Size(680, 694);
            this.AccountDetailsBox.TabIndex = 0;
            this.AccountDetailsBox.TabStop = false;
            this.AccountDetailsBox.Text = "Account Details";
            this.AccountDetailsBox.Enter += new System.EventHandler(this.AccountDetailsBox_Enter);
            // 
            // UnfreezeAccountButton
            // 
            this.UnfreezeAccountButton.Location = new System.Drawing.Point(400, 624);
            this.UnfreezeAccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.UnfreezeAccountButton.Name = "UnfreezeAccountButton";
            this.UnfreezeAccountButton.Size = new System.Drawing.Size(152, 43);
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
            this.AccountStatusField.Location = new System.Drawing.Point(284, 634);
            this.AccountStatusField.Margin = new System.Windows.Forms.Padding(2);
            this.AccountStatusField.Name = "AccountStatusField";
            this.AccountStatusField.ReadOnly = true;
            this.AccountStatusField.Size = new System.Drawing.Size(94, 24);
            this.AccountStatusField.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 633);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Account Status:";
            // 
            // InventoryDueField
            // 
            this.InventoryDueField.BackColor = System.Drawing.SystemColors.Control;
            this.InventoryDueField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryDueField.Location = new System.Drawing.Point(284, 579);
            this.InventoryDueField.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryDueField.Name = "InventoryDueField";
            this.InventoryDueField.ReadOnly = true;
            this.InventoryDueField.Size = new System.Drawing.Size(300, 24);
            this.InventoryDueField.TabIndex = 17;
            this.InventoryDueField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastInventoryField
            // 
            this.LastInventoryField.BackColor = System.Drawing.SystemColors.Control;
            this.LastInventoryField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastInventoryField.Location = new System.Drawing.Point(284, 515);
            this.LastInventoryField.Margin = new System.Windows.Forms.Padding(2);
            this.LastInventoryField.Name = "LastInventoryField";
            this.LastInventoryField.ReadOnly = true;
            this.LastInventoryField.Size = new System.Drawing.Size(300, 24);
            this.LastInventoryField.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 579);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Inventory Due:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 515);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Inventory:";
            // 
            // OrganizationField
            // 
            this.OrganizationField.BackColor = System.Drawing.SystemColors.Control;
            this.OrganizationField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrganizationField.Location = new System.Drawing.Point(284, 458);
            this.OrganizationField.Margin = new System.Windows.Forms.Padding(2);
            this.OrganizationField.Name = "OrganizationField";
            this.OrganizationField.ReadOnly = true;
            this.OrganizationField.Size = new System.Drawing.Size(300, 24);
            this.OrganizationField.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 457);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Organization:";
            // 
            // AccountNumberField
            // 
            this.AccountNumberField.BackColor = System.Drawing.SystemColors.Control;
            this.AccountNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountNumberField.Location = new System.Drawing.Point(284, 398);
            this.AccountNumberField.Margin = new System.Windows.Forms.Padding(2);
            this.AccountNumberField.Name = "AccountNumberField";
            this.AccountNumberField.ReadOnly = true;
            this.AccountNumberField.Size = new System.Drawing.Size(300, 24);
            this.AccountNumberField.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 398);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Acct#:";
            // 
            // NumROSItems
            // 
            this.NumROSItems.BackColor = System.Drawing.SystemColors.Control;
            this.NumROSItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumROSItems.Location = new System.Drawing.Point(284, 335);
            this.NumROSItems.Margin = new System.Windows.Forms.Padding(2);
            this.NumROSItems.Name = "NumROSItems";
            this.NumROSItems.ReadOnly = true;
            this.NumROSItems.Size = new System.Drawing.Size(300, 24);
            this.NumROSItems.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of ROS Items:";
            // 
            // NumDRMOItems
            // 
            this.NumDRMOItems.BackColor = System.Drawing.SystemColors.Control;
            this.NumDRMOItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumDRMOItems.Location = new System.Drawing.Point(284, 277);
            this.NumDRMOItems.Margin = new System.Windows.Forms.Padding(2);
            this.NumDRMOItems.Name = "NumDRMOItems";
            this.NumDRMOItems.ReadOnly = true;
            this.NumDRMOItems.Size = new System.Drawing.Size(300, 24);
            this.NumDRMOItems.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of DRMO Items:";
            // 
            // ECField
            // 
            this.ECField.BackColor = System.Drawing.SystemColors.Control;
            this.ECField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ECField.Location = new System.Drawing.Point(284, 215);
            this.ECField.Margin = new System.Windows.Forms.Padding(2);
            this.ECField.Name = "ECField";
            this.ECField.ReadOnly = true;
            this.ECField.Size = new System.Drawing.Size(300, 24);
            this.ECField.TabIndex = 5;
            this.ECField.TextChanged += new System.EventHandler(this.ECField_TextChanged);
            // 
            // EquipmentCustodianLabel
            // 
            this.EquipmentCustodianLabel.AutoSize = true;
            this.EquipmentCustodianLabel.Location = new System.Drawing.Point(32, 215);
            this.EquipmentCustodianLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EquipmentCustodianLabel.Name = "EquipmentCustodianLabel";
            this.EquipmentCustodianLabel.Size = new System.Drawing.Size(223, 25);
            this.EquipmentCustodianLabel.TabIndex = 4;
            this.EquipmentCustodianLabel.Text = "Equipment Custodian:";
            // 
            // TotalValueField
            // 
            this.TotalValueField.BackColor = System.Drawing.SystemColors.Control;
            this.TotalValueField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalValueField.Location = new System.Drawing.Point(284, 150);
            this.TotalValueField.Margin = new System.Windows.Forms.Padding(2);
            this.TotalValueField.Name = "TotalValueField";
            this.TotalValueField.ReadOnly = true;
            this.TotalValueField.Size = new System.Drawing.Size(300, 24);
            this.TotalValueField.TabIndex = 3;
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Location = new System.Drawing.Point(17, 150);
            this.TotalValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(240, 25);
            this.TotalValueLabel.TabIndex = 2;
            this.TotalValueLabel.Text = "Total Value (estimated):";
            // 
            // TotalAssetsField
            // 
            this.TotalAssetsField.BackColor = System.Drawing.SystemColors.Control;
            this.TotalAssetsField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalAssetsField.Location = new System.Drawing.Point(284, 90);
            this.TotalAssetsField.Margin = new System.Windows.Forms.Padding(2);
            this.TotalAssetsField.Name = "TotalAssetsField";
            this.TotalAssetsField.ReadOnly = true;
            this.TotalAssetsField.Size = new System.Drawing.Size(300, 24);
            this.TotalAssetsField.TabIndex = 1;
            // 
            // TotalAssetsLabel
            // 
            this.TotalAssetsLabel.AutoSize = true;
            this.TotalAssetsLabel.Location = new System.Drawing.Point(120, 90);
            this.TotalAssetsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalAssetsLabel.Name = "TotalAssetsLabel";
            this.TotalAssetsLabel.Size = new System.Drawing.Size(137, 25);
            this.TotalAssetsLabel.TabIndex = 0;
            this.TotalAssetsLabel.Text = "Total Assets:";
            // 
            // AccountAssets
            // 
            this.AccountAssets.FormattingEnabled = true;
            this.AccountAssets.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AccountAssets.ItemHeight = 25;
            this.AccountAssets.Location = new System.Drawing.Point(30, 798);
            this.AccountAssets.Margin = new System.Windows.Forms.Padding(2);
            this.AccountAssets.Name = "AccountAssets";
            this.AccountAssets.Size = new System.Drawing.Size(464, 629);
            this.AccountAssets.TabIndex = 1;
            this.AccountAssets.DoubleClick += new System.EventHandler(this.AccountAssets_DoubleClick);
            // 
            // AccountDRMO
            // 
            this.AccountDRMO.FormattingEnabled = true;
            this.AccountDRMO.ItemHeight = 25;
            this.AccountDRMO.Location = new System.Drawing.Point(512, 798);
            this.AccountDRMO.Margin = new System.Windows.Forms.Padding(2);
            this.AccountDRMO.Name = "AccountDRMO";
            this.AccountDRMO.Size = new System.Drawing.Size(390, 629);
            this.AccountDRMO.TabIndex = 2;
            // 
            // AccountROS
            // 
            this.AccountROS.FormattingEnabled = true;
            this.AccountROS.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AccountROS.ItemHeight = 25;
            this.AccountROS.Location = new System.Drawing.Point(922, 798);
            this.AccountROS.Margin = new System.Windows.Forms.Padding(2);
            this.AccountROS.Name = "AccountROS";
            this.AccountROS.Size = new System.Drawing.Size(660, 629);
            this.AccountROS.TabIndex = 3;
            this.AccountROS.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // AccountActionLog
            // 
            this.AccountActionLog.FormattingEnabled = true;
            this.AccountActionLog.ItemHeight = 25;
            this.AccountActionLog.Location = new System.Drawing.Point(15, 30);
            this.AccountActionLog.Margin = new System.Windows.Forms.Padding(2);
            this.AccountActionLog.Name = "AccountActionLog";
            this.AccountActionLog.Size = new System.Drawing.Size(1343, 304);
            this.AccountActionLog.TabIndex = 4;
            // 
            // AccountActionsBox
            // 
            this.AccountActionsBox.Controls.Add(this.button2);
            this.AccountActionsBox.Controls.Add(this.button1);
            this.AccountActionsBox.Controls.Add(this.DeleteAccountButton);
            this.AccountActionsBox.Controls.Add(this.FreezeAccountButton);
            this.AccountActionsBox.Controls.Add(this.GenerateReportButton);
            this.AccountActionsBox.Location = new System.Drawing.Point(1604, 785);
            this.AccountActionsBox.Margin = new System.Windows.Forms.Padding(2);
            this.AccountActionsBox.Name = "AccountActionsBox";
            this.AccountActionsBox.Padding = new System.Windows.Forms.Padding(2);
            this.AccountActionsBox.Size = new System.Drawing.Size(525, 642);
            this.AccountActionsBox.TabIndex = 5;
            this.AccountActionsBox.TabStop = false;
            this.AccountActionsBox.Text = "Account Actions";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 173);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(472, 62);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add Note";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 519);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(22, 401);
            this.DeleteAccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(472, 62);
            this.DeleteAccountButton.TabIndex = 7;
            this.DeleteAccountButton.Text = "Delete Account";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // FreezeAccountButton
            // 
            this.FreezeAccountButton.Location = new System.Drawing.Point(22, 286);
            this.FreezeAccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.FreezeAccountButton.Name = "FreezeAccountButton";
            this.FreezeAccountButton.Size = new System.Drawing.Size(472, 60);
            this.FreezeAccountButton.TabIndex = 6;
            this.FreezeAccountButton.Text = "Freeze";
            this.FreezeAccountButton.UseVisualStyleBackColor = true;
            this.FreezeAccountButton.Click += new System.EventHandler(this.FreezeAccountButton_Click);
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(22, 73);
            this.GenerateReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(472, 57);
            this.GenerateReportButton.TabIndex = 0;
            this.GenerateReportButton.Text = "Inventory Report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // NoteBox
            // 
            this.NoteBox.Controls.Add(this.AccountNotesField);
            this.NoteBox.Location = new System.Drawing.Point(748, 394);
            this.NoteBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Padding = new System.Windows.Forms.Padding(2);
            this.NoteBox.Size = new System.Drawing.Size(1381, 361);
            this.NoteBox.TabIndex = 6;
            this.NoteBox.TabStop = false;
            this.NoteBox.Text = "Notes";
            // 
            // AccountNotesField
            // 
            this.AccountNotesField.Location = new System.Drawing.Point(20, 31);
            this.AccountNotesField.Margin = new System.Windows.Forms.Padding(2);
            this.AccountNotesField.Name = "AccountNotesField";
            this.AccountNotesField.Size = new System.Drawing.Size(1338, 316);
            this.AccountNotesField.TabIndex = 0;
            this.AccountNotesField.Text = "";
            // 
            // AccountAssetsLabel
            // 
            this.AccountAssetsLabel.AutoSize = true;
            this.AccountAssetsLabel.Location = new System.Drawing.Point(26, 770);
            this.AccountAssetsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccountAssetsLabel.Name = "AccountAssetsLabel";
            this.AccountAssetsLabel.Size = new System.Drawing.Size(83, 25);
            this.AccountAssetsLabel.TabIndex = 7;
            this.AccountAssetsLabel.Text = "Assets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 770);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "DRMO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(917, 770);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ROS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AccountActionLog);
            this.groupBox1.Location = new System.Drawing.Point(748, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1381, 360);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action Log:";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.Location = new System.Drawing.Point(2090, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(39, 34);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AccountDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2410, 1489);
            this.Controls.Add(this.RefreshButton);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountDetailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button RefreshButton;
    }
}