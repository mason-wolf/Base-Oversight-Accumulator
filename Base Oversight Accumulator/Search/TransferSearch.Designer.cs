namespace Base_Oversight_Accumulator
{
    partial class TransferSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferSearch));
            this.TransferDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FromAccountField = new System.Windows.Forms.TextBox();
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
            this.TransferDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransferDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TransferDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TransferDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransferDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TransferDataView.Location = new System.Drawing.Point(-1, 66);
            this.TransferDataView.Name = "TransferDataView";
            this.TransferDataView.ReadOnly = true;
            this.TransferDataView.RowHeadersVisible = false;
            this.TransferDataView.RowHeadersWidth = 100;
            this.TransferDataView.RowTemplate.Height = 40;
            this.TransferDataView.Size = new System.Drawing.Size(1915, 1053);
            this.TransferDataView.TabIndex = 2;
            this.TransferDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransferDataView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "From Account:";
            // 
            // FromAccountField
            // 
            this.FromAccountField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.FromAccountField.Location = new System.Drawing.Point(249, 13);
            this.FromAccountField.Name = "FromAccountField";
            this.FromAccountField.Size = new System.Drawing.Size(200, 38);
            this.FromAccountField.TabIndex = 4;
            this.FromAccountField.TextChanged += new System.EventHandler(this.FromAccountField_TextChanged);
            // 
            // TransferSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1112);
            this.Controls.Add(this.FromAccountField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransferDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferSearch";
            this.Text = " Search Transfers";
            ((System.ComponentModel.ISupportInitialize)(this.TransferDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransferDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FromAccountField;
    }
}