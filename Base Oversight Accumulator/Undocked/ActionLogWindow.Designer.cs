namespace Base_Oversight_Accumulator
{
    partial class ActionLogWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionLogWindow));
            this.ActionLogDataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDataView)).BeginInit();
            this.SuspendLayout();
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
            this.ActionLogDataView.Location = new System.Drawing.Point(-1, 0);
            this.ActionLogDataView.Name = "ActionLogDataView";
            this.ActionLogDataView.ReadOnly = true;
            this.ActionLogDataView.RowHeadersVisible = false;
            this.ActionLogDataView.RowHeadersWidth = 100;
            this.ActionLogDataView.RowTemplate.Height = 40;
            this.ActionLogDataView.Size = new System.Drawing.Size(2385, 1499);
            this.ActionLogDataView.TabIndex = 5;
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
            // ActionLogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1468);
            this.Controls.Add(this.ActionLogDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActionLogWindow";
            this.Text = " Action Log";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView ActionLogDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}