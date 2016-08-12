namespace Base_Oversight_Accumulator
{
    partial class TransferWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferWindow));
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
            ((System.ComponentModel.ISupportInitialize)(this.TransferDataView)).BeginInit();
            this.SuspendLayout();
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
            this.TransferDataView.Location = new System.Drawing.Point(-1, 0);
            this.TransferDataView.Name = "TransferDataView";
            this.TransferDataView.ReadOnly = true;
            this.TransferDataView.RowHeadersVisible = false;
            this.TransferDataView.RowHeadersWidth = 100;
            this.TransferDataView.RowTemplate.Height = 40;
            this.TransferDataView.Size = new System.Drawing.Size(2385, 1499);
            this.TransferDataView.TabIndex = 3;
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
            // TransferWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1468);
            this.Controls.Add(this.TransferDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferWindow";
            this.Text = "TransferWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransferWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransferDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}