namespace Base_Oversight_Accumulator
{
    partial class AssetsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetsWindow));
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
            ((System.ComponentModel.ISupportInitialize)(this.AssetDataView)).BeginInit();
            this.SuspendLayout();
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
            this.AssetDataView.Location = new System.Drawing.Point(-1, 0);
            this.AssetDataView.Name = "AssetDataView";
            this.AssetDataView.ReadOnly = true;
            this.AssetDataView.RowHeadersVisible = false;
            this.AssetDataView.RowHeadersWidth = 100;
            this.AssetDataView.RowTemplate.Height = 40;
            this.AssetDataView.Size = new System.Drawing.Size(2269, 1463);
            this.AssetDataView.TabIndex = 2;
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
            // AssetsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1468);
            this.Controls.Add(this.AssetDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssetsWindow";
            this.Text = " Assets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.AssetDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView AssetDataView;
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
    }
}