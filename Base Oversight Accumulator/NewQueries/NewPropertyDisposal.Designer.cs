namespace Base_Oversight_Accumulator
{
    partial class NewPropertyDisposal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPropertyDisposal));
            this.AssetsField = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountField = new System.Windows.Forms.TextBox();
            this.CreateReportButton = new System.Windows.Forms.Button();
            this.AddAssetButton = new System.Windows.Forms.Button();
            this.RemoveAssetButton = new System.Windows.Forms.Button();
            this.ItemField = new System.Windows.Forms.TextBox();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.AddedItemsField = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.AssetsField)).BeginInit();
            this.SuspendLayout();
            // 
            // AssetsField
            // 
            this.AssetsField.AllowUserToAddRows = false;
            this.AssetsField.AllowUserToDeleteRows = false;
            this.AssetsField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssetsField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssetsField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AssetsField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssetsField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AssetsField.Location = new System.Drawing.Point(91, 185);
            this.AssetsField.Name = "AssetsField";
            this.AssetsField.ReadOnly = true;
            this.AssetsField.RowHeadersVisible = false;
            this.AssetsField.RowHeadersWidth = 100;
            this.AssetsField.RowTemplate.Height = 40;
            this.AssetsField.Size = new System.Drawing.Size(518, 620);
            this.AssetsField.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item:";
            // 
            // AccountField
            // 
            this.AccountField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AccountField.Location = new System.Drawing.Point(209, 40);
            this.AccountField.Name = "AccountField";
            this.AccountField.Size = new System.Drawing.Size(100, 38);
            this.AccountField.TabIndex = 1;
            // 
            // CreateReportButton
            // 
            this.CreateReportButton.Location = new System.Drawing.Point(1115, 740);
            this.CreateReportButton.Name = "CreateReportButton";
            this.CreateReportButton.Size = new System.Drawing.Size(235, 65);
            this.CreateReportButton.TabIndex = 5;
            this.CreateReportButton.Text = "Create Report";
            this.CreateReportButton.UseVisualStyleBackColor = true;
            this.CreateReportButton.Click += new System.EventHandler(this.CreateReportButton_Click);
            // 
            // AddAssetButton
            // 
            this.AddAssetButton.Location = new System.Drawing.Point(636, 185);
            this.AddAssetButton.Name = "AddAssetButton";
            this.AddAssetButton.Size = new System.Drawing.Size(153, 54);
            this.AddAssetButton.TabIndex = 3;
            this.AddAssetButton.Text = "Add";
            this.AddAssetButton.UseVisualStyleBackColor = true;
            this.AddAssetButton.Click += new System.EventHandler(this.AddAssetButton_Click);
            // 
            // RemoveAssetButton
            // 
            this.RemoveAssetButton.Location = new System.Drawing.Point(636, 251);
            this.RemoveAssetButton.Name = "RemoveAssetButton";
            this.RemoveAssetButton.Size = new System.Drawing.Size(158, 57);
            this.RemoveAssetButton.TabIndex = 4;
            this.RemoveAssetButton.Text = "Remove";
            this.RemoveAssetButton.UseVisualStyleBackColor = true;
            this.RemoveAssetButton.Click += new System.EventHandler(this.RemoveAssetButton_Click);
            // 
            // ItemField
            // 
            this.ItemField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ItemField.Location = new System.Drawing.Point(209, 112);
            this.ItemField.Name = "ItemField";
            this.ItemField.Size = new System.Drawing.Size(400, 38);
            this.ItemField.TabIndex = 2;
            this.ItemField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(650, 118);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(252, 32);
            this.ErrorMessage.TabIndex = 13;
            this.ErrorMessage.Text = "Account not found.";
            this.ErrorMessage.Visible = false;
            // 
            // AddedItemsField
            // 
            this.AddedItemsField.FormattingEnabled = true;
            this.AddedItemsField.ItemHeight = 31;
            this.AddedItemsField.Location = new System.Drawing.Point(822, 185);
            this.AddedItemsField.Name = "AddedItemsField";
            this.AddedItemsField.Size = new System.Drawing.Size(528, 500);
            this.AddedItemsField.TabIndex = 7;
            // 
            // NewPropertyDisposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 844);
            this.Controls.Add(this.AddedItemsField);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.ItemField);
            this.Controls.Add(this.RemoveAssetButton);
            this.Controls.Add(this.AddAssetButton);
            this.Controls.Add(this.CreateReportButton);
            this.Controls.Add(this.AccountField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssetsField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPropertyDisposal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Property Disposal Report";
            this.Load += new System.EventHandler(this.PropertyDisposal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssetsField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AssetsField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountField;
        private System.Windows.Forms.Button CreateReportButton;
        private System.Windows.Forms.Button AddAssetButton;
        private System.Windows.Forms.Button RemoveAssetButton;
        private System.Windows.Forms.TextBox ItemField;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.ListBox AddedItemsField;
    }
}