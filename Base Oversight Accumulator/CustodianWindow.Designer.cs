namespace Base_Oversight_Accumulator
{
    partial class CustodianWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustodianWindow));
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
            ((System.ComponentModel.ISupportInitialize)(this.ECDataView)).BeginInit();
            this.SuspendLayout();
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
            this.ECDataView.Location = new System.Drawing.Point(-1, 0);
            this.ECDataView.Name = "ECDataView";
            this.ECDataView.ReadOnly = true;
            this.ECDataView.RowHeadersVisible = false;
            this.ECDataView.RowHeadersWidth = 100;
            this.ECDataView.RowTemplate.Height = 40;
            this.ECDataView.Size = new System.Drawing.Size(2385, 1499);
            this.ECDataView.TabIndex = 1;
            this.ECDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ECDataView_CellContentClick);
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
            // CustodianWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1468);
            this.Controls.Add(this.ECDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustodianWindow";
            this.Text = "CustodianWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ECDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ECDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentCustodianID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECAccountNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECDSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLocation;
    }
}