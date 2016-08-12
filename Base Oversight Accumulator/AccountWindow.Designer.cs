namespace Base_Oversight_Accumulator
{
    partial class AccountWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountWindow));
            this.AccountDataView = new System.Windows.Forms.DataGridView();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataView)).BeginInit();
            this.SuspendLayout();
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
            this.AccountDataView.Location = new System.Drawing.Point(-1, 0);
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
            this.AccountDataView.Size = new System.Drawing.Size(2262, 1468);
            this.AccountDataView.TabIndex = 2;
            this.AccountDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDataView_CellDoubleClick);
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
            // AccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1468);
            this.Controls.Add(this.AccountDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountWindow";
            this.Text = "AccountWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccountWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountDataView;
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