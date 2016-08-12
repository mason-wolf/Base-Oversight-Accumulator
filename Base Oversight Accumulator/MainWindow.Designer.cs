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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ECEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECDSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountsTab = new System.Windows.Forms.TabPage();
            this.AccountDataView = new System.Windows.Forms.DataGridView();
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
            this.IssuedDataView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionLogTab = new System.Windows.Forms.TabPage();
            this.ActionLogDataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEquipmentCustodianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addITAMAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ModifyAssetValueButton = new System.Windows.Forms.ToolStripButton();
            this.DRMOButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionReportDataView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssetDataView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ECDataView)).BeginInit();
            this.AccountsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataView)).BeginInit();
            this.TransferTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDataView)).BeginInit();
            this.TemporaryIssueDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssuedDataView)).BeginInit();
            this.ActionLogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDataView)).BeginInit();
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
            this.ActionReportDataView.Controls.Add(this.ActionLogTab);
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
            this.AssetDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.ID.Width = 96;
            // 
            // AssetType
            // 
            this.AssetType.HeaderText = "Item";
            this.AssetType.Name = "AssetType";
            this.AssetType.ReadOnly = true;
            this.AssetType.Width = 123;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "Serial #";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Width = 166;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.Width = 236;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 147;
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "Acct#";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.ReadOnly = true;
            this.AccountNumber.Width = 140;
            // 
            // Organization
            // 
            this.Organization.HeaderText = "Org";
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            this.Organization.Width = 116;
            // 
            // EC
            // 
            this.EC.HeaderText = "ITEC";
            this.EC.Name = "EC";
            this.EC.ReadOnly = true;
            this.EC.Width = 132;
            // 
            // Building
            // 
            this.Building.HeaderText = "BLDG";
            this.Building.Name = "Building";
            this.Building.ReadOnly = true;
            this.Building.Width = 146;
            // 
            // Room
            // 
            this.Room.HeaderText = "RM";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 112;
            // 
            // EstimatedValue
            // 
            this.EstimatedValue.HeaderText = "Est. Value";
            this.EstimatedValue.Name = "EstimatedValue";
            this.EstimatedValue.ReadOnly = true;
            this.EstimatedValue.Width = 199;
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
            this.ECDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ECDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ECDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ECDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ECDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentCustodianID,
            this.ECLastName,
            this.ECFirstName,
            this.ECRank,
            this.ECAccountNum,
            this.ECEmail,
            this.ECDSN,
            this.ECOrg,
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
            this.EquipmentCustodianID.Width = 96;
            // 
            // ECLastName
            // 
            this.ECLastName.HeaderText = "Last Name";
            this.ECLastName.Name = "ECLastName";
            this.ECLastName.ReadOnly = true;
            this.ECLastName.Width = 205;
            // 
            // ECFirstName
            // 
            this.ECFirstName.HeaderText = "First Name";
            this.ECFirstName.Name = "ECFirstName";
            this.ECFirstName.ReadOnly = true;
            this.ECFirstName.Width = 206;
            // 
            // ECRank
            // 
            this.ECRank.HeaderText = "Rank";
            this.ECRank.Name = "ECRank";
            this.ECRank.ReadOnly = true;
            this.ECRank.Width = 135;
            // 
            // ECAccountNum
            // 
            this.ECAccountNum.HeaderText = "Acct#";
            this.ECAccountNum.Name = "ECAccountNum";
            this.ECAccountNum.ReadOnly = true;
            this.ECAccountNum.Width = 140;
            // 
            // ECEmail
            // 
            this.ECEmail.HeaderText = "Email";
            this.ECEmail.Name = "ECEmail";
            this.ECEmail.ReadOnly = true;
            this.ECEmail.Width = 141;
            // 
            // ECDSN
            // 
            this.ECDSN.HeaderText = "DSN";
            this.ECDSN.Name = "ECDSN";
            this.ECDSN.ReadOnly = true;
            this.ECDSN.Width = 128;
            // 
            // ECOrg
            // 
            this.ECOrg.HeaderText = "Org";
            this.ECOrg.Name = "ECOrg";
            this.ECOrg.ReadOnly = true;
            this.ECOrg.Width = 116;
            // 
            // ECLocation
            // 
            this.ECLocation.HeaderText = "Location";
            this.ECLocation.Name = "ECLocation";
            this.ECLocation.ReadOnly = true;
            this.ECLocation.Width = 178;
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
            this.AccountDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.AccountDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.AccountDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AccountDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountID,
            this.Account,
            this.AssignedEC,
            this.dra,
            this.Org,
            this.LastInventory,
            this.InventoryDue,
            this.Location,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AccountDataView.Location = new System.Drawing.Point(-10, 0);
            this.AccountDataView.Name = "AccountDataView";
            this.AccountDataView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AccountDataView.RowHeadersVisible = false;
            this.AccountDataView.RowHeadersWidth = 100;
            this.AccountDataView.RowTemplate.Height = 40;
            this.AccountDataView.Size = new System.Drawing.Size(1787, 1317);
            this.AccountDataView.TabIndex = 1;
            this.AccountDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDataView_CellDoubleClick);
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
            this.TransferDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.TransferDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TransferDataView.Location = new System.Drawing.Point(-10, 0);
            this.TransferDataView.Name = "TransferDataView";
            this.TransferDataView.ReadOnly = true;
            this.TransferDataView.RowHeadersVisible = false;
            this.TransferDataView.RowHeadersWidth = 100;
            this.TransferDataView.RowTemplate.Height = 40;
            this.TransferDataView.Size = new System.Drawing.Size(1784, 1316);
            this.TransferDataView.TabIndex = 2;
            this.TransferDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransferDataView_CellDoubleClick);
            // 
            // TransferID
            // 
            this.TransferID.HeaderText = "ID";
            this.TransferID.Name = "TransferID";
            this.TransferID.ReadOnly = true;
            this.TransferID.Width = 96;
            // 
            // TransferItem
            // 
            this.TransferItem.HeaderText = "Item";
            this.TransferItem.Name = "TransferItem";
            this.TransferItem.ReadOnly = true;
            this.TransferItem.Width = 123;
            // 
            // TransferedTo
            // 
            this.TransferedTo.HeaderText = "Transfered To";
            this.TransferedTo.Name = "TransferedTo";
            this.TransferedTo.ReadOnly = true;
            this.TransferedTo.Width = 226;
            // 
            // TransferedFrom
            // 
            this.TransferedFrom.HeaderText = "Transfered From";
            this.TransferedFrom.Name = "TransferedFrom";
            this.TransferedFrom.ReadOnly = true;
            this.TransferedFrom.Width = 255;
            // 
            // TransferDate
            // 
            this.TransferDate.HeaderText = "Date";
            this.TransferDate.Name = "TransferDate";
            this.TransferDate.ReadOnly = true;
            this.TransferDate.Width = 129;
            // 
            // TransferSN
            // 
            this.TransferSN.HeaderText = "SN";
            this.TransferSN.Name = "TransferSN";
            this.TransferSN.ReadOnly = true;
            this.TransferSN.Width = 108;
            // 
            // LosingAccount
            // 
            this.LosingAccount.HeaderText = "Losing Acct";
            this.LosingAccount.Name = "LosingAccount";
            this.LosingAccount.ReadOnly = true;
            this.LosingAccount.Width = 199;
            // 
            // GainingAccount
            // 
            this.GainingAccount.HeaderText = "Gaining Acct";
            this.GainingAccount.Name = "GainingAccount";
            this.GainingAccount.ReadOnly = true;
            this.GainingAccount.Width = 213;
            // 
            // TransferedBy
            // 
            this.TransferedBy.HeaderText = "Transfered By";
            this.TransferedBy.Name = "TransferedBy";
            this.TransferedBy.ReadOnly = true;
            this.TransferedBy.Width = 226;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 143;
            // 
            // TemporaryIssueDataView
            // 
            this.TemporaryIssueDataView.Controls.Add(this.IssuedDataView);
            this.TemporaryIssueDataView.Location = new System.Drawing.Point(10, 48);
            this.TemporaryIssueDataView.Name = "TemporaryIssueDataView";
            this.TemporaryIssueDataView.Padding = new System.Windows.Forms.Padding(3);
            this.TemporaryIssueDataView.Size = new System.Drawing.Size(1797, 1323);
            this.TemporaryIssueDataView.TabIndex = 4;
            this.TemporaryIssueDataView.Text = "Issued Items";
            this.TemporaryIssueDataView.UseVisualStyleBackColor = true;
            // 
            // IssuedDataView
            // 
            this.IssuedDataView.AllowUserToAddRows = false;
            this.IssuedDataView.AllowUserToDeleteRows = false;
            this.IssuedDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssuedDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.IssuedDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.IssuedDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IssuedDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuedDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.IssuedDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IssuedDataView.Location = new System.Drawing.Point(-10, 0);
            this.IssuedDataView.Name = "IssuedDataView";
            this.IssuedDataView.ReadOnly = true;
            this.IssuedDataView.RowHeadersVisible = false;
            this.IssuedDataView.RowHeadersWidth = 100;
            this.IssuedDataView.RowTemplate.Height = 40;
            this.IssuedDataView.Size = new System.Drawing.Size(1784, 1316);
            this.IssuedDataView.TabIndex = 3;
            this.IssuedDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssuedDataView_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Issued To";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 178;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Issued By";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 178;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Acct#";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Duty Phone";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date of Issue";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 215;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date of Return";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 232;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Items";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 137;
            // 
            // ActionLogTab
            // 
            this.ActionLogTab.Controls.Add(this.ActionLogDataView);
            this.ActionLogTab.Location = new System.Drawing.Point(10, 48);
            this.ActionLogTab.Name = "ActionLogTab";
            this.ActionLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActionLogTab.Size = new System.Drawing.Size(1797, 1323);
            this.ActionLogTab.TabIndex = 7;
            this.ActionLogTab.Text = "Action Log";
            this.ActionLogTab.UseVisualStyleBackColor = true;
            // 
            // ActionLogDataView
            // 
            this.ActionLogDataView.AllowUserToAddRows = false;
            this.ActionLogDataView.AllowUserToDeleteRows = false;
            this.ActionLogDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionLogDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ActionLogDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ActionLogDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ActionLogDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActionLogDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Date,
            this.ECLog,
            this.Action});
            this.ActionLogDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ActionLogDataView.Location = new System.Drawing.Point(-10, 0);
            this.ActionLogDataView.Name = "ActionLogDataView";
            this.ActionLogDataView.ReadOnly = true;
            this.ActionLogDataView.RowHeadersVisible = false;
            this.ActionLogDataView.RowHeadersWidth = 100;
            this.ActionLogDataView.RowTemplate.Height = 40;
            this.ActionLogDataView.Size = new System.Drawing.Size(1784, 1316);
            this.ActionLogDataView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 96;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 129;
            // 
            // ECLog
            // 
            this.ECLog.HeaderText = "EC";
            this.ECLog.Name = "ECLog";
            this.ECLog.ReadOnly = true;
            this.ECLog.Width = 108;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 149;
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
            this.toolStripMenuItem1,
            this.initiateReportOfSurveryToolStripMenuItem,
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(482, 46);
            this.toolStripMenuItem1.Text = "Modify Costs";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // initiateReportOfSurveryToolStripMenuItem
            // 
            this.initiateReportOfSurveryToolStripMenuItem.Name = "initiateReportOfSurveryToolStripMenuItem";
            this.initiateReportOfSurveryToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.initiateReportOfSurveryToolStripMenuItem.Text = "Report of Survey";
            this.initiateReportOfSurveryToolStripMenuItem.Click += new System.EventHandler(this.initiateReportOfSurveryToolStripMenuItem_Click);
            // 
            // assetDispositionbToolStripMenuItem
            // 
            this.assetDispositionbToolStripMenuItem.Name = "assetDispositionbToolStripMenuItem";
            this.assetDispositionbToolStripMenuItem.Size = new System.Drawing.Size(482, 46);
            this.assetDispositionbToolStripMenuItem.Text = "Asset Disposition";
            this.assetDispositionbToolStripMenuItem.Click += new System.EventHandler(this.assetDispositionbToolStripMenuItem_Click);
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
            this.ModifyAssetValueButton,
            this.DRMOButton,
            this.toolStripButton1,
            this.toolStripButton2});
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
            // TransferButton
            // 
            this.TransferButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TransferButton.Image = ((System.Drawing.Image)(resources.GetObject("TransferButton.Image")));
            this.TransferButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TransferButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(23, 36);
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
            this.TempIssueButton.Size = new System.Drawing.Size(23, 36);
            this.TempIssueButton.Text = "TempIssueButton";
            this.TempIssueButton.ToolTipText = "Temporarily issue item.\r\n";
            this.TempIssueButton.Click += new System.EventHandler(this.TempIssueButton_Click);
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
            this.ModifyAssetValueButton.Click += new System.EventHandler(this.ModifyAssetValueButton_Click);
            // 
            // DRMOButton
            // 
            this.DRMOButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DRMOButton.Image = ((System.Drawing.Image)(resources.GetObject("DRMOButton.Image")));
            this.DRMOButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DRMOButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DRMOButton.Name = "DRMOButton";
            this.DRMOButton.Size = new System.Drawing.Size(23, 36);
            this.DRMOButton.Text = "Initiate asset disposition or disposal for Defense Reutilization and Marketing Of" +
    "fice Reports.";
            this.DRMOButton.Click += new System.EventHandler(this.DRMOButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 36);
            this.toolStripButton1.Text = "Initiate Report of Survey for missing assets.";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 36);
            this.toolStripButton2.Text = "Search";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            // AccountID
            // 
            this.AccountID.HeaderText = "ID";
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            this.AccountID.Width = 96;
            // 
            // Account
            // 
            this.Account.HeaderText = "Acct#";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 140;
            // 
            // AssignedEC
            // 
            this.AssignedEC.HeaderText = "Equipment Custodian";
            this.AssignedEC.Name = "AssignedEC";
            this.AssignedEC.ReadOnly = true;
            this.AssignedEC.Width = 313;
            // 
            // dra
            // 
            this.dra.HeaderText = "DRA";
            this.dra.Name = "dra";
            this.dra.ReadOnly = true;
            this.dra.Width = 128;
            // 
            // Org
            // 
            this.Org.HeaderText = "Org";
            this.Org.Name = "Org";
            this.Org.ReadOnly = true;
            this.Org.Width = 116;
            // 
            // LastInventory
            // 
            this.LastInventory.HeaderText = "Last Inventory";
            this.LastInventory.Name = "LastInventory";
            this.LastInventory.ReadOnly = true;
            this.LastInventory.Width = 226;
            // 
            // InventoryDue
            // 
            this.InventoryDue.HeaderText = "Inventory Due";
            this.InventoryDue.Name = "InventoryDue";
            this.InventoryDue.ReadOnly = true;
            this.InventoryDue.Width = 224;
            // 
            // Location
            // 
            this.Location.HeaderText = "Notes";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 143;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Status";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = " Base Oversight Accumulator";
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
            this.TemporaryIssueDataView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IssuedDataView)).EndInit();
            this.ActionLogTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDataView)).EndInit();
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
        private System.Windows.Forms.TabPage ActionLogTab;
        private System.Windows.Forms.ToolStripButton TempIssueButton;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentCustodianID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECAccountNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECDSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLocation;
        public System.Windows.Forms.DataGridView IssuedDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ToolStripButton DRMOButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.DataGridView ActionLogDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Org;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryDue;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

