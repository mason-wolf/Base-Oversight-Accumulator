namespace Base_Oversight_Accumulator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ActionReportDataView = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.AssetDataView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ECDataView = new System.Windows.Forms.DataGridView();
            this.ECLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECDSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECAccountNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferDataView = new System.Windows.Forms.TabPage();
            this.DRMODataView = new System.Windows.Forms.TabPage();
            this.ActionReportTab = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.assetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentCustodianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentCustodiansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.NewAssetButton = new System.Windows.Forms.ToolStripButton();
            this.NewECButton = new System.Windows.Forms.ToolStripButton();
            this.NewAccountButton = new System.Windows.Forms.ToolStripButton();
            this.ActionReportDataView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssetDataView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ECDataView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionReportDataView
            // 
            this.ActionReportDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionReportDataView.Controls.Add(this.tabPage1);
            this.ActionReportDataView.Controls.Add(this.tabPage2);
            this.ActionReportDataView.Controls.Add(this.TransferDataView);
            this.ActionReportDataView.Controls.Add(this.DRMODataView);
            this.ActionReportDataView.Controls.Add(this.ActionReportTab);
            this.ActionReportDataView.Controls.Add(this.tabPage3);
            this.ActionReportDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ActionReportDataView.Location = new System.Drawing.Point(12, 149);
            this.ActionReportDataView.Name = "ActionReportDataView";
            this.ActionReportDataView.SelectedIndex = 0;
            this.ActionReportDataView.Size = new System.Drawing.Size(1817, 1394);
            this.ActionReportDataView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.AssetDataView);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1797, 1336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Assets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(3, 1311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1791, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // AssetDataView
            // 
            this.AssetDataView.AllowUserToAddRows = false;
            this.AssetDataView.AllowUserToDeleteRows = false;
            this.AssetDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssetDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssetDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.AssetDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AssetDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssetDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AssetType,
            this.SerialNumber,
            this.Manufacturer,
            this.Model,
            this.AccountNumber,
            this.Organization,
            this.EC,
            this.Building,
            this.Room,
            this.EstimatedValue});
            this.AssetDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AssetDataView.Location = new System.Drawing.Point(7, 7);
            this.AssetDataView.Name = "AssetDataView";
            this.AssetDataView.ReadOnly = true;
            this.AssetDataView.RowHeadersVisible = false;
            this.AssetDataView.RowHeadersWidth = 100;
            this.AssetDataView.RowTemplate.Height = 40;
            this.AssetDataView.Size = new System.Drawing.Size(1784, 1247);
            this.AssetDataView.TabIndex = 1;
            this.AssetDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssetDataView_CellContentClick);
            this.AssetDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssetDataView_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // AssetType
            // 
            this.AssetType.HeaderText = "Item";
            this.AssetType.Name = "AssetType";
            this.AssetType.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "Serial #";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "Acct#";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.ReadOnly = true;
            // 
            // Organization
            // 
            this.Organization.HeaderText = "Org";
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // EC
            // 
            this.EC.HeaderText = "ITEC";
            this.EC.Name = "EC";
            this.EC.ReadOnly = true;
            // 
            // Building
            // 
            this.Building.HeaderText = "BLDG";
            this.Building.Name = "Building";
            this.Building.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.HeaderText = "RM";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // EstimatedValue
            // 
            this.EstimatedValue.HeaderText = "Est. Value";
            this.EstimatedValue.Name = "EstimatedValue";
            this.EstimatedValue.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.ECDataView);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1797, 1336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Equipment Custodians";
            // 
            // ECDataView
            // 
            this.ECDataView.AllowUserToAddRows = false;
            this.ECDataView.AllowUserToDeleteRows = false;
            this.ECDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ECDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ECDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ECDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ECDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ECDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ECLastName,
            this.ECFirstName,
            this.ECRank,
            this.ECOrg,
            this.ECEmail,
            this.ECDSN,
            this.ECAccountNum,
            this.ECLocation});
            this.ECDataView.Location = new System.Drawing.Point(7, 7);
            this.ECDataView.Name = "ECDataView";
            this.ECDataView.ReadOnly = true;
            this.ECDataView.RowHeadersVisible = false;
            this.ECDataView.RowHeadersWidth = 100;
            this.ECDataView.RowTemplate.Height = 40;
            this.ECDataView.Size = new System.Drawing.Size(1787, 1330);
            this.ECDataView.TabIndex = 0;
            this.ECDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ECDataView_CellContentClick);
            // 
            // ECLastName
            // 
            this.ECLastName.HeaderText = "Last Name";
            this.ECLastName.Name = "ECLastName";
            this.ECLastName.ReadOnly = true;
            // 
            // ECFirstName
            // 
            this.ECFirstName.HeaderText = "First Name";
            this.ECFirstName.Name = "ECFirstName";
            this.ECFirstName.ReadOnly = true;
            // 
            // ECRank
            // 
            this.ECRank.HeaderText = "Rank";
            this.ECRank.Name = "ECRank";
            this.ECRank.ReadOnly = true;
            // 
            // ECOrg
            // 
            this.ECOrg.HeaderText = "Org";
            this.ECOrg.Name = "ECOrg";
            this.ECOrg.ReadOnly = true;
            // 
            // ECEmail
            // 
            this.ECEmail.HeaderText = "Email";
            this.ECEmail.Name = "ECEmail";
            this.ECEmail.ReadOnly = true;
            // 
            // ECDSN
            // 
            this.ECDSN.HeaderText = "DSN";
            this.ECDSN.Name = "ECDSN";
            this.ECDSN.ReadOnly = true;
            // 
            // ECAccountNum
            // 
            this.ECAccountNum.HeaderText = "Acct#";
            this.ECAccountNum.Name = "ECAccountNum";
            this.ECAccountNum.ReadOnly = true;
            // 
            // ECLocation
            // 
            this.ECLocation.HeaderText = "Location";
            this.ECLocation.Name = "ECLocation";
            this.ECLocation.ReadOnly = true;
            // 
            // TransferDataView
            // 
            this.TransferDataView.Location = new System.Drawing.Point(10, 48);
            this.TransferDataView.Name = "TransferDataView";
            this.TransferDataView.Padding = new System.Windows.Forms.Padding(3);
            this.TransferDataView.Size = new System.Drawing.Size(1797, 1336);
            this.TransferDataView.TabIndex = 2;
            this.TransferDataView.Text = "Accounts";
            this.TransferDataView.UseVisualStyleBackColor = true;
            // 
            // DRMODataView
            // 
            this.DRMODataView.Location = new System.Drawing.Point(10, 48);
            this.DRMODataView.Name = "DRMODataView";
            this.DRMODataView.Padding = new System.Windows.Forms.Padding(3);
            this.DRMODataView.Size = new System.Drawing.Size(1797, 1336);
            this.DRMODataView.TabIndex = 3;
            this.DRMODataView.Text = "Transfers";
            this.DRMODataView.UseVisualStyleBackColor = true;
            // 
            // ActionReportTab
            // 
            this.ActionReportTab.Location = new System.Drawing.Point(10, 48);
            this.ActionReportTab.Name = "ActionReportTab";
            this.ActionReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActionReportTab.Size = new System.Drawing.Size(1797, 1336);
            this.ActionReportTab.TabIndex = 4;
            this.ActionReportTab.Text = "DRMO";
            this.ActionReportTab.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1797, 1336);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Action Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1841, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 45);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetToolStripMenuItem,
            this.equipmentCustodianToolStripMenuItem,
            this.organizationToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(327, 46);
            this.toolStripMenuItem2.Text = "New";
            // 
            // assetToolStripMenuItem
            // 
            this.assetToolStripMenuItem.Name = "assetToolStripMenuItem";
            this.assetToolStripMenuItem.Size = new System.Drawing.Size(419, 46);
            this.assetToolStripMenuItem.Text = "Asset";
            this.assetToolStripMenuItem.Click += new System.EventHandler(this.assetToolStripMenuItem_Click);
            // 
            // equipmentCustodianToolStripMenuItem
            // 
            this.equipmentCustodianToolStripMenuItem.Name = "equipmentCustodianToolStripMenuItem";
            this.equipmentCustodianToolStripMenuItem.Size = new System.Drawing.Size(419, 46);
            this.equipmentCustodianToolStripMenuItem.Text = "Equipment Custodian";
            this.equipmentCustodianToolStripMenuItem.Click += new System.EventHandler(this.equipmentCustodianToolStripMenuItem_Click);
            // 
            // organizationToolStripMenuItem
            // 
            this.organizationToolStripMenuItem.Name = "organizationToolStripMenuItem";
            this.organizationToolStripMenuItem.Size = new System.Drawing.Size(419, 46);
            this.organizationToolStripMenuItem.Text = "ITAM Account";
            this.organizationToolStripMenuItem.Click += new System.EventHandler(this.organizationToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(419, 46);
            this.transferToolStripMenuItem.Text = "Transfer";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(327, 46);
            this.saveToolStripMenuItem1.Text = "Save Inventory";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.optionToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(99, 45);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.equipmentCustodiansToolStripMenuItem,
            this.organizationsToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(255, 46);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // equipmentCustodiansToolStripMenuItem
            // 
            this.equipmentCustodiansToolStripMenuItem.Name = "equipmentCustodiansToolStripMenuItem";
            this.equipmentCustodiansToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.equipmentCustodiansToolStripMenuItem.Text = "Equipment Custodians";
            // 
            // organizationsToolStripMenuItem
            // 
            this.organizationsToolStripMenuItem.Name = "organizationsToolStripMenuItem";
            this.organizationsToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.organizationsToolStripMenuItem.Text = "Organizations";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(132, 45);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(92, 45);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.NewAssetButton,
            this.NewECButton,
            this.NewAccountButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 49);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1841, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolBar_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 36);
            this.RefreshButton.Text = "RefreshButton";
            this.RefreshButton.ToolTipText = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // NewAssetButton
            // 
            this.NewAssetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewAssetButton.Image = ((System.Drawing.Image)(resources.GetObject("NewAssetButton.Image")));
            this.NewAssetButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewAssetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewAssetButton.Name = "NewAssetButton";
            this.NewAssetButton.Size = new System.Drawing.Size(23, 36);
            this.NewAssetButton.Text = "NewAssetButton";
            this.NewAssetButton.ToolTipText = "Add a new asset.\r\n";
            this.NewAssetButton.Click += new System.EventHandler(this.NewAssetButton_Click);
            // 
            // NewECButton
            // 
            this.NewECButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewECButton.Image = ((System.Drawing.Image)(resources.GetObject("NewECButton.Image")));
            this.NewECButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewECButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewECButton.Name = "NewECButton";
            this.NewECButton.Size = new System.Drawing.Size(36, 36);
            this.NewECButton.ToolTipText = "Add a new equipment custodian.\r\n";
            this.NewECButton.Click += new System.EventHandler(this.NewECButton_Click);
            // 
            // NewAccountButton
            // 
            this.NewAccountButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("NewAccountButton.Image")));
            this.NewAccountButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewAccountButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewAccountButton.Name = "NewAccountButton";
            this.NewAccountButton.Size = new System.Drawing.Size(23, 36);
            this.NewAccountButton.ToolTipText = "Create a new ITAM account.\r\n";
            this.NewAccountButton.Click += new System.EventHandler(this.NewAccountButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 1555);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ActionReportDataView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Base Oversight Accumulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ActionReportDataView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssetDataView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ECDataView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ActionReportDataView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabPage TransferDataView;
        private System.Windows.Forms.TabPage DRMODataView;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        public System.Windows.Forms.DataGridView AssetDataView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentCustodiansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentCustodianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage ActionReportTab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton NewAssetButton;
        private System.Windows.Forms.ToolStripButton NewECButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECDSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECAccountNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLocation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.DataGridView ECDataView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization;
        private System.Windows.Forms.DataGridViewTextBoxColumn EC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedValue;
        private System.Windows.Forms.ToolStripButton NewAccountButton;
    }
}

