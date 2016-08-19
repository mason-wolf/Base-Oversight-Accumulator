namespace Base_Oversight_Accumulator.NewQueries
{
    partial class NewItemModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItemModification));
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
            this.ChangeItemButton = new System.Windows.Forms.Button();
            this.ChangeManufacturerButton = new System.Windows.Forms.Button();
            this.ChangeModelButton = new System.Windows.Forms.Button();
            this.ChangeLocationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.AssetDataView.Location = new System.Drawing.Point(-2, 176);
            this.AssetDataView.Name = "AssetDataView";
            this.AssetDataView.ReadOnly = true;
            this.AssetDataView.RowHeadersVisible = false;
            this.AssetDataView.RowHeadersWidth = 100;
            this.AssetDataView.RowTemplate.Height = 40;
            this.AssetDataView.Size = new System.Drawing.Size(2269, 1463);
            this.AssetDataView.TabIndex = 3;
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
            // ChangeItemButton
            // 
            this.ChangeItemButton.Location = new System.Drawing.Point(44, 89);
            this.ChangeItemButton.Name = "ChangeItemButton";
            this.ChangeItemButton.Size = new System.Drawing.Size(375, 50);
            this.ChangeItemButton.TabIndex = 4;
            this.ChangeItemButton.Text = "Change Item Type";
            this.ChangeItemButton.UseVisualStyleBackColor = true;
            this.ChangeItemButton.Click += new System.EventHandler(this.ChangeItemButton_Click);
            // 
            // ChangeManufacturerButton
            // 
            this.ChangeManufacturerButton.Location = new System.Drawing.Point(459, 89);
            this.ChangeManufacturerButton.Name = "ChangeManufacturerButton";
            this.ChangeManufacturerButton.Size = new System.Drawing.Size(375, 50);
            this.ChangeManufacturerButton.TabIndex = 5;
            this.ChangeManufacturerButton.Text = "Change Manufacturer";
            this.ChangeManufacturerButton.UseVisualStyleBackColor = true;
            this.ChangeManufacturerButton.Click += new System.EventHandler(this.ChangeManufacturerButton_Click);
            // 
            // ChangeModelButton
            // 
            this.ChangeModelButton.Location = new System.Drawing.Point(878, 89);
            this.ChangeModelButton.Name = "ChangeModelButton";
            this.ChangeModelButton.Size = new System.Drawing.Size(375, 50);
            this.ChangeModelButton.TabIndex = 6;
            this.ChangeModelButton.Text = "Change Model";
            this.ChangeModelButton.UseVisualStyleBackColor = true;
            this.ChangeModelButton.Click += new System.EventHandler(this.ChangeModelButton_Click);
            // 
            // ChangeLocationButton
            // 
            this.ChangeLocationButton.Location = new System.Drawing.Point(1306, 89);
            this.ChangeLocationButton.Name = "ChangeLocationButton";
            this.ChangeLocationButton.Size = new System.Drawing.Size(375, 50);
            this.ChangeLocationButton.TabIndex = 7;
            this.ChangeLocationButton.Text = "Change Location";
            this.ChangeLocationButton.UseVisualStyleBackColor = true;
            this.ChangeLocationButton.Click += new System.EventHandler(this.ChangeLocationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(852, 64);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the items you wish to modify. This action cannot be undone.\r\n\r\n";
            // 
            // NewItemModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeLocationButton);
            this.Controls.Add(this.ChangeModelButton);
            this.Controls.Add(this.ChangeManufacturerButton);
            this.Controls.Add(this.ChangeItemButton);
            this.Controls.Add(this.AssetDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewItemModification";
            this.Text = " Modify Assets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewItemModification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssetDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button ChangeItemButton;
        private System.Windows.Forms.Button ChangeManufacturerButton;
        private System.Windows.Forms.Button ChangeModelButton;
        private System.Windows.Forms.Button ChangeLocationButton;
        private System.Windows.Forms.Label label1;
    }
}