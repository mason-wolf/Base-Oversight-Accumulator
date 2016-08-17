namespace Base_Oversight_Accumulator.Search
{
    partial class SlotNumberSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotNumberSearch));
            this.SlotNumberDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MakeModelField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SlotNumberDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // SlotNumberDataView
            // 
            this.SlotNumberDataView.AllowUserToAddRows = false;
            this.SlotNumberDataView.AllowUserToDeleteRows = false;
            this.SlotNumberDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SlotNumberDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SlotNumberDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SlotNumberDataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SlotNumberDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SlotNumberDataView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SlotNumberDataView.Location = new System.Drawing.Point(-1, 66);
            this.SlotNumberDataView.Name = "SlotNumberDataView";
            this.SlotNumberDataView.ReadOnly = true;
            this.SlotNumberDataView.RowHeadersVisible = false;
            this.SlotNumberDataView.RowHeadersWidth = 100;
            this.SlotNumberDataView.RowTemplate.Height = 40;
            this.SlotNumberDataView.Size = new System.Drawing.Size(1794, 1053);
            this.SlotNumberDataView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Make/Model:";
            // 
            // MakeModelField
            // 
            this.MakeModelField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MakeModelField.Location = new System.Drawing.Point(196, 14);
            this.MakeModelField.Name = "MakeModelField";
            this.MakeModelField.Size = new System.Drawing.Size(500, 38);
            this.MakeModelField.TabIndex = 5;
            this.MakeModelField.TextChanged += new System.EventHandler(this.MakeModelField_TextChanged);
            // 
            // SlotNumberSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 705);
            this.Controls.Add(this.MakeModelField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SlotNumberDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SlotNumberSearch";
            this.Text = " Search National Slot Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.SlotNumberDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SlotNumberDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MakeModelField;
    }
}