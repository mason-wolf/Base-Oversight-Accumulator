namespace Base_Oversight_Accumulator
{
    partial class NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            this.DRALabel = new System.Windows.Forms.Label();
            this.DRAField = new System.Windows.Forms.TextBox();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.AccountNumberField = new System.Windows.Forms.TextBox();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.OrganizationField = new System.Windows.Forms.TextBox();
            this.NewAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DRALabel
            // 
            this.DRALabel.AutoSize = true;
            this.DRALabel.Location = new System.Drawing.Point(104, 53);
            this.DRALabel.Name = "DRALabel";
            this.DRALabel.Size = new System.Drawing.Size(82, 32);
            this.DRALabel.TabIndex = 0;
            this.DRALabel.Text = "DRA:";
            // 
            // DRAField
            // 
            this.DRAField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DRAField.Location = new System.Drawing.Point(255, 47);
            this.DRAField.Name = "DRAField";
            this.DRAField.Size = new System.Drawing.Size(100, 38);
            this.DRAField.TabIndex = 1;
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.Location = new System.Drawing.Point(85, 123);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(101, 32);
            this.AccountNumberLabel.TabIndex = 2;
            this.AccountNumberLabel.Text = "Acct #:";
            // 
            // AccountNumberField
            // 
            this.AccountNumberField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AccountNumberField.Location = new System.Drawing.Point(255, 116);
            this.AccountNumberField.Name = "AccountNumberField";
            this.AccountNumberField.Size = new System.Drawing.Size(100, 38);
            this.AccountNumberField.TabIndex = 3;
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Location = new System.Drawing.Point(92, 189);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(70, 32);
            this.OrganizationLabel.TabIndex = 4;
            this.OrganizationLabel.Text = "Org:";
            // 
            // OrganizationField
            // 
            this.OrganizationField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OrganizationField.Location = new System.Drawing.Point(255, 182);
            this.OrganizationField.Name = "OrganizationField";
            this.OrganizationField.Size = new System.Drawing.Size(300, 38);
            this.OrganizationField.TabIndex = 5;
            // 
            // NewAccountButton
            // 
            this.NewAccountButton.Location = new System.Drawing.Point(255, 253);
            this.NewAccountButton.Name = "NewAccountButton";
            this.NewAccountButton.Size = new System.Drawing.Size(150, 50);
            this.NewAccountButton.TabIndex = 6;
            this.NewAccountButton.Text = "Create";
            this.NewAccountButton.UseVisualStyleBackColor = true;
            this.NewAccountButton.Click += new System.EventHandler(this.NewAccountButton_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 315);
            this.Controls.Add(this.NewAccountButton);
            this.Controls.Add(this.OrganizationField);
            this.Controls.Add(this.OrganizationLabel);
            this.Controls.Add(this.AccountNumberField);
            this.Controls.Add(this.AccountNumberLabel);
            this.Controls.Add(this.DRAField);
            this.Controls.Add(this.DRALabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " New ITAM Account";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DRALabel;
        private System.Windows.Forms.TextBox DRAField;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.TextBox AccountNumberField;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.TextBox OrganizationField;
        private System.Windows.Forms.Button NewAccountButton;
    }
}