namespace Base_Oversight_Accumulator
{
    partial class IssuedSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuedSearch));
            this.IssuedDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketNumberField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IssuedDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // IssuedDataView
            // 
            this.IssuedDataView.AllowUserToAddRows = false;
            this.IssuedDataView.AllowUserToDeleteRows = false;
            this.IssuedDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssuedDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IssuedDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.IssuedDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IssuedDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuedDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IssuedDataView.Location = new System.Drawing.Point(-1, 66);
            this.IssuedDataView.Name = "IssuedDataView";
            this.IssuedDataView.ReadOnly = true;
            this.IssuedDataView.RowHeadersVisible = false;
            this.IssuedDataView.RowHeadersWidth = 100;
            this.IssuedDataView.RowTemplate.Height = 40;
            this.IssuedDataView.Size = new System.Drawing.Size(1915, 1053);
            this.IssuedDataView.TabIndex = 3;
            this.IssuedDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssuedDataView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket #:";
            // 
            // TicketNumberField
            // 
            this.TicketNumberField.Location = new System.Drawing.Point(173, 13);
            this.TicketNumberField.Name = "TicketNumberField";
            this.TicketNumberField.Size = new System.Drawing.Size(200, 38);
            this.TicketNumberField.TabIndex = 5;
            this.TicketNumberField.TextChanged += new System.EventHandler(this.TicketNumberField_TextChanged);
            // 
            // IssuedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1112);
            this.Controls.Add(this.TicketNumberField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IssuedDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IssuedSearch";
            this.Text = " Search Issued Items";
            ((System.ComponentModel.ISupportInitialize)(this.IssuedDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IssuedDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TicketNumberField;
    }
}