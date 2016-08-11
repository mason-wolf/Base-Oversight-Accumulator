namespace Base_Oversight_Accumulator
{
    partial class CustodianSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustodianSelection));
            this.ECDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ECKeyWords = new System.Windows.Forms.TextBox();
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
            this.ECDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ECDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ECDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ECDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ECDataView.Location = new System.Drawing.Point(-3, 66);
            this.ECDataView.Name = "ECDataView";
            this.ECDataView.ReadOnly = true;
            this.ECDataView.RowHeadersVisible = false;
            this.ECDataView.RowHeadersWidth = 100;
            this.ECDataView.RowTemplate.Height = 40;
            this.ECDataView.Size = new System.Drawing.Size(1915, 1053);
            this.ECDataView.TabIndex = 1;
            this.ECDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ECDataView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // ECKeyWords
            // 
            this.ECKeyWords.Location = new System.Drawing.Point(147, 13);
            this.ECKeyWords.Name = "ECKeyWords";
            this.ECKeyWords.Size = new System.Drawing.Size(300, 38);
            this.ECKeyWords.TabIndex = 3;
            this.ECKeyWords.TextChanged += new System.EventHandler(this.ECKeyWords_TextChanged);
            // 
            // CustodianSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1112);
            this.Controls.Add(this.ECKeyWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ECDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CustodianSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Select Custodian..";
            this.Load += new System.EventHandler(this.CustodianSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ECDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ECDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ECKeyWords;
    }
}