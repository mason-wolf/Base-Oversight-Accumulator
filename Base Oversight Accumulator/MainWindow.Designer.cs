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
            this.EquipmentCustodianID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECAccountNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECDSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountsTab = new System.Windows.Forms.TabPage();
            this.AccountDataView = new System.Windows.Forms.DataGridView();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferTab = new System.Windows.Forms.TabPage();
            this.TransferDataView = new System.Windows.Forms.DataGridView();
            this.TransferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferedFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LosingAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GainingAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemporaryIssueDataView = new System.Windows.Forms.TabPage();
            this.DRMODataView = new System.Windows.Forms.TabPage();
            this.ROSDataView = new System.Windows.Forms.TabPage();
            this.ActionLogDataView = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEquipmentCustodianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addITAMAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initiateReportOfSurveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetDispositionbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.manageProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentCustodiansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transfersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOSReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.benchstockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentCustodiansToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transfersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dRMOReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOSReportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.NewAssetButton = new System.Windows.Forms.ToolStripButton();
            this.NewECButton = new System.Windows.Forms.ToolStripButton();
            this.NewAccountButton = new System.Windows.Forms.ToolStripButton();
            this.TransferButton = new System.Windows.Forms.ToolStripButton();
            this.TempIssueButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.ModifyAssetValueButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionReportDataView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssetDataView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ECDataView)).BeginInit();
            this.AccountsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataView)).BeginInit();
            this.TransferTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDataView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionReportDataView
            // 
            this.ActionReportDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionReportDataView.Controls.Add(this.tabPage1);
            this.ActionReportDataView.Controls.Add(this.tabPage2);
            this.ActionReportDataView.Controls.Add(this.AccountsTab);
            this.ActionReportDataView.Controls.Add(this.TransferTab);
            this.ActionReportDataView.Controls.Add(this.TemporaryIssueDataView);
            this.ActionReportDataView.Controls.Add(this.DRMODataView);
            this.ActionReportDataView.Controls.Add(this.ROSDataView);
            this.ActionReportDataView.Controls.Add(this.ActionLogDataView);
            this.ActionReportDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ActionReportDataView.Location = new System.Drawing.Point(12, 149);
            this.ActionReportDataView.Name = "ActionReportDataView";
            this.ActionReportDataView.SelectedIndex = 0;
            this.ActionReportDataView.Size = new System.Drawing.Size(1817, 1381);
            this.ActionReportDataView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AssetDataView);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1797, 1323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Assets";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.AssetDataView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.AssetDataView.Location = new System.Drawing.Point(-10, 0);
            this.AssetDataView.Name = "AssetDataView";
            this.AssetDataView.ReadOnly = true;
            this.AssetDataView.RowHeadersVisible = false;
            this.AssetDataView.RowHeadersWidth = 100;
            this.AssetDataView.RowTemplate.Height = 40;
            this.AssetDataView.Size = new System.Drawing.Size(1784, 1316);
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
            this.tabPage2.Size = new System.Drawing.Size(1797, 1323);
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
            this.EquipmentCustodianID,
            this.ECLastName,
            this.ECFirstName,
            this.ECRank,
            this.ECAccountNum,
            this.ECOrg,
            this.ECEmail,
            this.ECDSN,
            this.ECLocation});
            this.ECDataView.Location = new System.Drawing.Point(-10, 0);
            this.ECDataView.Name = "ECDataView";
            this.ECDataView.ReadOnly = true;
            this.ECDataView.RowHeadersVisible = false;
            this.ECDataView.RowHeadersWidth = 100;
            this.ECDataView.RowTemplate.Height = 40;
            this.ECDataView.Size = new System.Drawing.Size(1787, 1317);
            this.ECDataView.TabIndex = 0;
            this.ECDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ECDataView_CellDoubleClick);
            // 
            // EquipmentCustodianID
            // 
            this.EquipmentCustodianID.HeaderText = "ID";
            this.EquipmentCustodianID.Name = "EquipmentCustodianID";
            this.EquipmentCustodianID.ReadOnly = true;
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
            // ECAccountNum
            // 
            this.ECAccountNum.HeaderText = "Acct#";
            this.ECAccountNum.Name = "ECAccountNum";
            this.ECAccountNum.ReadOnly = true;
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
            // ECLocation
            // 
            this.ECLocation.HeaderText = "Location";
            this.ECLocation.Name = "ECLocation";
            this.ECLocation.ReadOnly = true;
            // 
            // AccountsTab
            // 
            this.AccountsTab.Controls.Add(this.AccountDataView);
            this.AccountsTab.Location = new System.Drawing.Point(10, 48);
            this.AccountsTab.Name = "AccountsTab";
            this.AccountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsTab.Size = new System.Drawing.Size(1797, 1323);
            this.AccountsTab.TabIndex = 2;
            this.AccountsTab.Text = "Accounts";
            this.AccountsTab.UseVisualStyleBackColor = true;
            // 
            // AccountDataView
            // 
            this.AccountDataView.AllowUserToAddRows = false;
            this.AccountDataView.AllowUserToDeleteRows = false;
            this.AccountDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.AccountDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AccountDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountID,
            this.Account,
            this.AssignedEC,
            this.dra,
            this.Org,
            this.LastInventory,
            this.InventoryDue,
            this.Location});
            this.AccountDataView.Location = new System.Drawing.Point(-10, 0);
            this.AccountDataView.Name = "AccountDataView";
            this.AccountDataView.ReadOnly = true;
            this.AccountDataView.RowHeadersVisible = false;
            this.AccountDataView.RowHeadersWidth = 100;
            this.AccountDataView.RowTemplate.Height = 40;
            this.AccountDataView.Size = new System.Drawing.Size(1787, 1317);
            this.AccountDataView.TabIndex = 1;
            this.AccountDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDataView_CellDoubleClick);
            // 
            // AccountID
            // 
            this.AccountID.HeaderText = "ID";
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.HeaderText = "Acct#";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // AssignedEC
            // 
            this.AssignedEC.HeaderText = "Equipment Custodian";
            this.AssignedEC.Name = "AssignedEC";
            this.AssignedEC.ReadOnly = true;
            // 
            // dra
            // 
            this.dra.HeaderText = "DRA";
            this.dra.Name = "dra";
            this.dra.ReadOnly = true;
            // 
            // Org
            // 
            this.Org.HeaderText = "Org";
            this.Org.Name = "Org";
            this.Org.ReadOnly = true;
            // 
            // LastInventory
            // 
            this.LastInventory.HeaderText = "Last Inventory";
            this.LastInventory.Name = "LastInventory";
            this.LastInventory.ReadOnly = true;
            // 
            // InventoryDue
            // 
            this.InventoryDue.HeaderText = "Inventory Due";
            this.InventoryDue.Name = "InventoryDue";
            this.InventoryDue.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // TransferTab
            // 
            this.TransferTab.Controls.Add(this.TransferDataView);
            this.TransferTab.Location = new System.Drawing.Point(10, 48);
            this.TransferTab.Name = "TransferTab";
            this.TransferTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransferTab.Size = new System.Drawing.Size(1797, 1323);
            this.TransferTab.TabIndex = 3;
            this.TransferTab.Text = "Transfers";
            this.TransferTab.UseVisualStyleBackColor = true;
            // 
            // TransferDataView
            // 
            this.TransferDataView.AllowUserToAddRows = false;
            this.TransferDataView.AllowUserToDeleteRows = false;
            this.TransferDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransferDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransferDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TransferDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TransferDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransferDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransferID,
            this.TransferItem,
            this.TransferedTo,
            this.TransferedFrom,
            this.TransferDate,
            this.TransferSN,
            this.LosingAccount,
            this.GainingAccount,
            this.TransferedBy,
            this.Notes});
            this.TransferDataView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TransferDataView.Location = new System.Drawing.Point(-10, 0);
            this.TransferDataView.Name = "TransferDataView";
            this.TransferDataView.ReadOnly = true;
            this.TransferDataView.RowHeadersVisible = false;
            this.TransferDataView.RowHeadersWidth = 100;
            this.TransferDataView.RowTemplate.Height = 40;
            this.TransferDataView.Size = new System.Drawing.Size(1784, 1316);
            this.TransferDataView.TabIndex = 2;
            // 
            // TransferID
            // 
            this.TransferID.HeaderText = "ID";
            this.TransferID.Name = "TransferID";
            this.TransferID.ReadOnly = true;
            // 
            // TransferItem
            // 
            this.TransferItem.HeaderText = "Item";
            this.TransferItem.Name = "TransferItem";
            this.TransferItem.ReadOnly = true;
            // 
            // TransferedTo
            // 
            this.TransferedTo.HeaderText = "Transfered To";
            this.TransferedTo.Name = "TransferedTo";
            this.TransferedTo.ReadOnly = true;
            // 
            // TransferedFrom
            // 
            this.TransferedFrom.HeaderText = "Transfered From";
            this.TransferedFrom.Name = "TransferedFrom";
            this.TransferedFrom.ReadOnly = true;
            // 
            // TransferDate
            // 
            this.TransferDate.HeaderText = "Date";
            this.TransferDate.Name = "TransferDate";
            this.TransferDate.ReadOnly = true;
            // 
            // TransferSN
            // 
            this.TransferSN.HeaderText = "SN";
            this.TransferSN.Name = "TransferSN";
            this.TransferSN.ReadOnly = true;
            // 
            // LosingAccount
            // 
            this.LosingAccount.HeaderText = "Losing Acct";
            this.LosingAccount.Name = "LosingAccount";
            this.LosingAccount.ReadOnly = true;
            // 
            // GainingAccount
            // 
            this.GainingAccount.HeaderText = "Gaining Acct";
            this.GainingAccount.Name = "GainingAccount";
            this.GainingAccount.ReadOnly = true;
            // 
            // TransferedBy
            // 
            this.TransferedBy.HeaderText = "Transfered By";
            this.TransferedBy.Name = "TransferedBy";
            this.TransferedBy.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // TemporaryIssueDataView
            // 
            this.TemporaryIssueDataView.Location = new System.Drawing.Point(10, 48);
            this.TemporaryIssueDataView.Name = "TemporaryIssueDataView";
            this.TemporaryIssueDataView.Padding = new System.Windows.Forms.Padding(3);
            this.TemporaryIssueDataView.Size = new System.Drawing.Size(1797, 1323);
            this.TemporaryIssueDataView.TabIndex = 4;
            this.TemporaryIssueDataView.Text = "Issued Items";
            this.TemporaryIssueDataView.UseVisualStyleBackColor = true;
            // 
            // DRMODataView
            // 
            this.DRMODataView.Location = new System.Drawing.Point(10, 48);
            this.DRMODataView.Name = "DRMODataView";
            this.DRMODataView.Padding = new System.Windows.Forms.Padding(3);
            this.DRMODataView.Size = new System.Drawing.Size(1797, 1323);
            this.DRMODataView.TabIndex = 5;
            this.DRMODataView.Text = "DRMO";
            this.DRMODataView.UseVisualStyleBackColor = true;
            // 
            // ROSDataView
            // 
            this.ROSDataView.Location = new System.Drawing.Point(10, 48);
            this.ROSDataView.Name = "ROSDataView";
            this.ROSDataView.Padding = new System.Windows.Forms.Padding(3);
            this.ROSDataView.Size = new System.Drawing.Size(1797, 1323);
            this.ROSDataView.TabIndex = 6;
            this.ROSDataView.Text = "ROS";
            this.ROSDataView.UseVisualStyleBackColor = true;
            // 
            // ActionLogDataView
            // 
            this.ActionLogDataView.Location = new System.Drawing.Point(10, 48);
            this.ActionLogDataView.Name = "ActionLogDataView";
            this.ActionLogDataView.Padding = new System.Windows.Forms.Padding(3);
            this.ActionLogDataView.Size = new System.Drawing.Size(1797, 1323);
            this.ActionLogDataView.TabIndex = 7;
            this.ActionLogDataView.Text = "Action Log";
            this.ActionLogDataView.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1841, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAssetToolStripMenuItem,
            this.addEquipmentCustodianToolStripMenuItem,
            this.addITAMAccountToolStripMenuItem,
            this.transferAssetToolStripMenuItem,
            this.initiateReportOfSurveryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.assetDispositionbToolStripMenuItem,
            this.toolStripSeparator1,
            this.manageProfilesToolStripMenuItem,
            this.refreshDatabaseToolStripMenuItem,
            this.eitToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(99, 45);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // addAssetToolStripMenuItem
            // 
            this.addAssetToolStripMenuItem.Name = "addAssetToolStripMenuItem";
            this.addAssetToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.addAssetToolStripMenuItem.Text = "Add Asset";
            this.addAssetToolStripMenuItem.Click += new System.EventHandler(this.addAssetToolStripMenuItem_Click);
            // 
            // addEquipmentCustodianToolStripMenuItem
            // 
            this.addEquipmentCustodianToolStripMenuItem.Name = "addEquipmentCustodianToolStripMenuItem";
            this.addEquipmentCustodianToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.addEquipmentCustodianToolStripMenuItem.Text = "Add Equipment Custodian";
            this.addEquipmentCustodianToolStripMenuItem.Click += new System.EventHandler(this.addEquipmentCustodianToolStripMenuItem_Click);
            // 
            // addITAMAccountToolStripMenuItem
            // 
            this.addITAMAccountToolStripMenuItem.Name = "addITAMAccountToolStripMenuItem";
            this.addITAMAccountToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.addITAMAccountToolStripMenuItem.Text = "Add ITAM Account";
            this.addITAMAccountToolStripMenuItem.Click += new System.EventHandler(this.addITAMAccountToolStripMenuItem_Click);
            // 
            // transferAssetToolStripMenuItem
            // 
            this.transferAssetToolStripMenuItem.Name = "transferAssetToolStripMenuItem";
            this.transferAssetToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.transferAssetToolStripMenuItem.Text = "Transfer Asset";
            this.transferAssetToolStripMenuItem.Click += new System.EventHandler(this.transferAssetToolStripMenuItem_Click);
            // 
            // initiateReportOfSurveryToolStripMenuItem
            // 
            this.initiateReportOfSurveryToolStripMenuItem.Name = "initiateReportOfSurveryToolStripMenuItem";
            this.initiateReportOfSurveryToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.initiateReportOfSurveryToolStripMenuItem.Text = "Report of Survey";
            // 
            // assetDispositionbToolStripMenuItem
            // 
            this.assetDispositionbToolStripMenuItem.Name = "assetDispositionbToolStripMenuItem";
            this.assetDispositionbToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.assetDispositionbToolStripMenuItem.Text = "Asset Disposition";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(479, 6);
            // 
            // manageProfilesToolStripMenuItem
            // 
            this.manageProfilesToolStripMenuItem.Name = "manageProfilesToolStripMenuItem";
            this.manageProfilesToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.manageProfilesToolStripMenuItem.Text = "Manage Profile";
            // 
            // refreshDatabaseToolStripMenuItem
            // 
            this.refreshDatabaseToolStripMenuItem.Name = "refreshDatabaseToolStripMenuItem";
            this.refreshDatabaseToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.refreshDatabaseToolStripMenuItem.Text = "Refresh Database";
            // 
            // eitToolStripMenuItem
            // 
            this.eitToolStripMenuItem.Name = "eitToolStripMenuItem";
            this.eitToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.eitToolStripMenuItem.Text = "Exit";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetsToolStripMenuItem,
            this.equipmentCustodiansToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.transfersToolStripMenuItem,
            this.dispositionsToolStripMenuItem,
            this.rOSReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(118, 45);
            this.reportsToolStripMenuItem.Text = "Search";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // assetsToolStripMenuItem
            // 
            this.assetsToolStripMenuItem.Name = "assetsToolStripMenuItem";
            this.assetsToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.assetsToolStripMenuItem.Text = "Assets";
            // 
            // equipmentCustodiansToolStripMenuItem
            // 
            this.equipmentCustodiansToolStripMenuItem.Name = "equipmentCustodiansToolStripMenuItem";
            this.equipmentCustodiansToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.equipmentCustodiansToolStripMenuItem.Text = "Accounts";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.accountsToolStripMenuItem.Text = "Equipment Custodians";
            // 
            // transfersToolStripMenuItem
            // 
            this.transfersToolStripMenuItem.Name = "transfersToolStripMenuItem";
            this.transfersToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.transfersToolStripMenuItem.Text = "Transfers";
            // 
            // dispositionsToolStripMenuItem
            // 
            this.dispositionsToolStripMenuItem.Name = "dispositionsToolStripMenuItem";
            this.dispositionsToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.dispositionsToolStripMenuItem.Text = "DRMO Records";
            // 
            // rOSReportsToolStripMenuItem
            // 
            this.rOSReportsToolStripMenuItem.Name = "rOSReportsToolStripMenuItem";
            this.rOSReportsToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.rOSReportsToolStripMenuItem.Text = "ROS Records";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetsToolStripMenuItem1,
            this.benchstockToolStripMenuItem,
            this.accountsToolStripMenuItem1,
            this.equipmentCustodiansToolStripMenuItem1,
            this.transfersToolStripMenuItem1,
            this.dRMOReportsToolStripMenuItem,
            this.rOSReportsToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(132, 45);
            this.helpToolStripMenuItem.Text = "Reports";
            // 
            // assetsToolStripMenuItem1
            // 
            this.assetsToolStripMenuItem1.Name = "assetsToolStripMenuItem1";
            this.assetsToolStripMenuItem1.Size = new System.Drawing.Size(432, 46);
            this.assetsToolStripMenuItem1.Text = "Inventories";
            // 
            // benchstockToolStripMenuItem
            // 
            this.benchstockToolStripMenuItem.Name = "benchstockToolStripMenuItem";
            this.benchstockToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.benchstockToolStripMenuItem.Text = "Benchstock";
            // 
            // accountsToolStripMenuItem1
            // 
            this.accountsToolStripMenuItem1.Name = "accountsToolStripMenuItem1";
            this.accountsToolStripMenuItem1.Size = new System.Drawing.Size(432, 46);
            this.accountsToolStripMenuItem1.Text = "Accounts";
            // 
            // equipmentCustodiansToolStripMenuItem1
            // 
            this.equipmentCustodiansToolStripMenuItem1.Name = "equipmentCustodiansToolStripMenuItem1";
            this.equipmentCustodiansToolStripMenuItem1.Size = new System.Drawing.Size(432, 46);
            this.equipmentCustodiansToolStripMenuItem1.Text = "Equipment Custodians";
            // 
            // transfersToolStripMenuItem1
            // 
            this.transfersToolStripMenuItem1.Name = "transfersToolStripMenuItem1";
            this.transfersToolStripMenuItem1.Size = new System.Drawing.Size(432, 46);
            this.transfersToolStripMenuItem1.Text = "Transfers";
            // 
            // dRMOReportsToolStripMenuItem
            // 
            this.dRMOReportsToolStripMenuItem.Name = "dRMOReportsToolStripMenuItem";
            this.dRMOReportsToolStripMenuItem.Size = new System.Drawing.Size(432, 46);
            this.dRMOReportsToolStripMenuItem.Text = "Disposed Items";
            // 
            // rOSReportsToolStripMenuItem1
            // 
            this.rOSReportsToolStripMenuItem1.Name = "rOSReportsToolStripMenuItem1";
            this.rOSReportsToolStripMenuItem1.Size = new System.Drawing.Size(432, 46);
            this.rOSReportsToolStripMenuItem1.Text = "Missing Items";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(92, 45);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.NewAssetButton,
            this.NewECButton,
            this.NewAccountButton,
            this.TransferButton,
            this.TempIssueButton,
            this.ModifyAssetValueButton});
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
            this.NewAssetButton.Size = new System.Drawing.Size(23, 45);
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
            this.NewECButton.Size = new System.Drawing.Size(36, 45);
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
            this.NewAccountButton.Size = new System.Drawing.Size(23, 45);
            this.NewAccountButton.ToolTipText = "Create a new ITAM account.\r\n";
            this.NewAccountButton.Click += new System.EventHandler(this.NewAccountButton_Click);
            // 
            // TransferButton
            // 
            this.TransferButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TransferButton.Image = ((System.Drawing.Image)(resources.GetObject("TransferButton.Image")));
            this.TransferButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TransferButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(23, 45);
            this.TransferButton.Text = "Transfer";
            this.TransferButton.ToolTipText = "Transfer asset from one account to another.\r\n\r\n";
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // TempIssueButton
            // 
            this.TempIssueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TempIssueButton.Image = ((System.Drawing.Image)(resources.GetObject("TempIssueButton.Image")));
            this.TempIssueButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TempIssueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TempIssueButton.Name = "TempIssueButton";
            this.TempIssueButton.Size = new System.Drawing.Size(23, 45);
            this.TempIssueButton.Text = "TempIssueButton";
            this.TempIssueButton.ToolTipText = "Temporarily issue item.\r\n";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1841, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // ModifyAssetValueButton
            // 
            this.ModifyAssetValueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModifyAssetValueButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifyAssetValueButton.Image")));
            this.ModifyAssetValueButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ModifyAssetValueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModifyAssetValueButton.Name = "ModifyAssetValueButton";
            this.ModifyAssetValueButton.Size = new System.Drawing.Size(36, 36);
            this.ModifyAssetValueButton.Text = "Modify cost of assets based on make and model.";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(482, 46);
            this.toolStripMenuItem1.Text = "Modify Cost of Asset";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 1555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ActionReportDataView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Base Oversight Accumulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ActionReportDataView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AssetDataView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ECDataView)).EndInit();
            this.AccountsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataView)).EndInit();
            this.TransferTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransferDataView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ActionReportDataView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage AccountsTab;
        private System.Windows.Forms.TabPage TransferTab;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        public System.Windows.Forms.DataGridView AssetDataView;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage TemporaryIssueDataView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton NewAssetButton;
        private System.Windows.Forms.ToolStripButton NewECButton;
        private System.Windows.Forms.DataGridView ECDataView;
        private System.Windows.Forms.TabPage DRMODataView;
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
        private System.Windows.Forms.DataGridView AccountDataView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Org;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryDue;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addAssetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEquipmentCustodianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addITAMAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferAssetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initiateReportOfSurveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetDispositionbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentCustodiansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transfersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispositionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOSReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem equipmentCustodiansToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transfersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dRMOReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOSReportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem manageProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benchstockToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton TransferButton;
        private System.Windows.Forms.TabPage ROSDataView;
        private System.Windows.Forms.TabPage ActionLogDataView;
        private System.Windows.Forms.ToolStripButton TempIssueButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentCustodianID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECAccountNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECDSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLocation;
        public System.Windows.Forms.DataGridView TransferDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferedFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LosingAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GainingAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.ToolStripButton ModifyAssetValueButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

