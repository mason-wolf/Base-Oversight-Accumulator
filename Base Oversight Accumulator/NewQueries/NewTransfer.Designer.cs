namespace Base_Oversight_Accumulator
{
    partial class NewTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTransfer));
            this.LosingAccount = new System.Windows.Forms.Label();
            this.GainingAccount = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.Label();
            this.LosingAccountField = new System.Windows.Forms.TextBox();
            this.GainingAccountField = new System.Windows.Forms.TextBox();
            this.SerialNumberField = new System.Windows.Forms.TextBox();
            this.SearchAssetButton = new System.Windows.Forms.Button();
            this.TransferRequest = new System.Windows.Forms.GroupBox();
            this.TransferNotesField = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TransferDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SerialNumberDetail = new System.Windows.Forms.TextBox();
            this.AssetDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GainingECDetail = new System.Windows.Forms.TextBox();
            this.GainingOrganizationDetail = new System.Windows.Forms.TextBox();
            this.GainingAccountDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GainingAccountLabel = new System.Windows.Forms.Label();
            this.LosingECDetail = new System.Windows.Forms.TextBox();
            this.LosingOrgDetail = new System.Windows.Forms.TextBox();
            this.LosingEC = new System.Windows.Forms.Label();
            this.LosingOrganization = new System.Windows.Forms.Label();
            this.LosingAccountDetail = new System.Windows.Forms.TextBox();
            this.LosingAccountLabel = new System.Windows.Forms.Label();
            this.TransferButton = new System.Windows.Forms.Button();
            this.TransferRequest.SuspendLayout();
            this.TransferDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // LosingAccount
            // 
            this.LosingAccount.AutoSize = true;
            this.LosingAccount.Location = new System.Drawing.Point(32, 59);
            this.LosingAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LosingAccount.Name = "LosingAccount";
            this.LosingAccount.Size = new System.Drawing.Size(166, 25);
            this.LosingAccount.TabIndex = 0;
            this.LosingAccount.Text = "Losing Account:";
            // 
            // GainingAccount
            // 
            this.GainingAccount.AutoSize = true;
            this.GainingAccount.Location = new System.Drawing.Point(20, 109);
            this.GainingAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GainingAccount.Name = "GainingAccount";
            this.GainingAccount.Size = new System.Drawing.Size(176, 25);
            this.GainingAccount.TabIndex = 2;
            this.GainingAccount.Text = "Gaining Account:";
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSize = true;
            this.SerialNumber.Location = new System.Drawing.Point(42, 159);
            this.SerialNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(154, 25);
            this.SerialNumber.TabIndex = 4;
            this.SerialNumber.Text = "Serial Number:";
            // 
            // LosingAccountField
            // 
            this.LosingAccountField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LosingAccountField.Location = new System.Drawing.Point(208, 54);
            this.LosingAccountField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LosingAccountField.Name = "LosingAccountField";
            this.LosingAccountField.Size = new System.Drawing.Size(76, 31);
            this.LosingAccountField.TabIndex = 5;
            // 
            // GainingAccountField
            // 
            this.GainingAccountField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GainingAccountField.Location = new System.Drawing.Point(208, 104);
            this.GainingAccountField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GainingAccountField.Name = "GainingAccountField";
            this.GainingAccountField.Size = new System.Drawing.Size(76, 31);
            this.GainingAccountField.TabIndex = 7;
            // 
            // SerialNumberField
            // 
            this.SerialNumberField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SerialNumberField.Location = new System.Drawing.Point(208, 154);
            this.SerialNumberField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialNumberField.Name = "SerialNumberField";
            this.SerialNumberField.Size = new System.Drawing.Size(226, 31);
            this.SerialNumberField.TabIndex = 9;
            // 
            // SearchAssetButton
            // 
            this.SearchAssetButton.Location = new System.Drawing.Point(246, 214);
            this.SearchAssetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchAssetButton.Name = "SearchAssetButton";
            this.SearchAssetButton.Size = new System.Drawing.Size(188, 40);
            this.SearchAssetButton.TabIndex = 10;
            this.SearchAssetButton.Text = "Search";
            this.SearchAssetButton.UseVisualStyleBackColor = true;
            this.SearchAssetButton.Click += new System.EventHandler(this.TransferAssetButton_Click);
            // 
            // TransferRequest
            // 
            this.TransferRequest.Controls.Add(this.TransferNotesField);
            this.TransferRequest.Controls.Add(this.label5);
            this.TransferRequest.Controls.Add(this.LosingAccount);
            this.TransferRequest.Controls.Add(this.SearchAssetButton);
            this.TransferRequest.Controls.Add(this.LosingAccountField);
            this.TransferRequest.Controls.Add(this.SerialNumberField);
            this.TransferRequest.Controls.Add(this.GainingAccount);
            this.TransferRequest.Controls.Add(this.SerialNumber);
            this.TransferRequest.Controls.Add(this.GainingAccountField);
            this.TransferRequest.Location = new System.Drawing.Point(25, 34);
            this.TransferRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransferRequest.Name = "TransferRequest";
            this.TransferRequest.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransferRequest.Size = new System.Drawing.Size(532, 538);
            this.TransferRequest.TabIndex = 11;
            this.TransferRequest.TabStop = false;
            this.TransferRequest.Text = "Transfer Request";
            // 
            // TransferNotesField
            // 
            this.TransferNotesField.Location = new System.Drawing.Point(25, 352);
            this.TransferNotesField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransferNotesField.Name = "TransferNotesField";
            this.TransferNotesField.Size = new System.Drawing.Size(488, 170);
            this.TransferNotesField.TabIndex = 12;
            this.TransferNotesField.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Notes:";
            // 
            // TransferDetails
            // 
            this.TransferDetails.Controls.Add(this.label4);
            this.TransferDetails.Controls.Add(this.SerialNumberDetail);
            this.TransferDetails.Controls.Add(this.AssetDetail);
            this.TransferDetails.Controls.Add(this.label3);
            this.TransferDetails.Controls.Add(this.GainingECDetail);
            this.TransferDetails.Controls.Add(this.GainingOrganizationDetail);
            this.TransferDetails.Controls.Add(this.GainingAccountDetail);
            this.TransferDetails.Controls.Add(this.label2);
            this.TransferDetails.Controls.Add(this.label1);
            this.TransferDetails.Controls.Add(this.GainingAccountLabel);
            this.TransferDetails.Controls.Add(this.LosingECDetail);
            this.TransferDetails.Controls.Add(this.LosingOrgDetail);
            this.TransferDetails.Controls.Add(this.LosingEC);
            this.TransferDetails.Controls.Add(this.LosingOrganization);
            this.TransferDetails.Controls.Add(this.LosingAccountDetail);
            this.TransferDetails.Controls.Add(this.LosingAccountLabel);
            this.TransferDetails.Location = new System.Drawing.Point(583, 34);
            this.TransferDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransferDetails.Name = "TransferDetails";
            this.TransferDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransferDetails.Size = new System.Drawing.Size(762, 538);
            this.TransferDetails.TabIndex = 12;
            this.TransferDetails.TabStop = false;
            this.TransferDetails.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 479);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "SN#:";
            // 
            // SerialNumberDetail
            // 
            this.SerialNumberDetail.BackColor = System.Drawing.SystemColors.Control;
            this.SerialNumberDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialNumberDetail.Location = new System.Drawing.Point(127, 479);
            this.SerialNumberDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialNumberDetail.Name = "SerialNumberDetail";
            this.SerialNumberDetail.Size = new System.Drawing.Size(450, 24);
            this.SerialNumberDetail.TabIndex = 14;
            // 
            // AssetDetail
            // 
            this.AssetDetail.BackColor = System.Drawing.SystemColors.Control;
            this.AssetDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AssetDetail.Location = new System.Drawing.Point(127, 420);
            this.AssetDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AssetDetail.Name = "AssetDetail";
            this.AssetDetail.Size = new System.Drawing.Size(450, 24);
            this.AssetDetail.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Asset:";
            // 
            // GainingECDetail
            // 
            this.GainingECDetail.BackColor = System.Drawing.SystemColors.Control;
            this.GainingECDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GainingECDetail.Location = new System.Drawing.Point(272, 318);
            this.GainingECDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GainingECDetail.Name = "GainingECDetail";
            this.GainingECDetail.Size = new System.Drawing.Size(450, 24);
            this.GainingECDetail.TabIndex = 11;
            // 
            // GainingOrganizationDetail
            // 
            this.GainingOrganizationDetail.BackColor = System.Drawing.SystemColors.Control;
            this.GainingOrganizationDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GainingOrganizationDetail.Location = new System.Drawing.Point(272, 273);
            this.GainingOrganizationDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GainingOrganizationDetail.Name = "GainingOrganizationDetail";
            this.GainingOrganizationDetail.Size = new System.Drawing.Size(225, 24);
            this.GainingOrganizationDetail.TabIndex = 10;
            // 
            // GainingAccountDetail
            // 
            this.GainingAccountDetail.BackColor = System.Drawing.SystemColors.Control;
            this.GainingAccountDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GainingAccountDetail.Location = new System.Drawing.Point(272, 222);
            this.GainingAccountDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GainingAccountDetail.Name = "GainingAccountDetail";
            this.GainingAccountDetail.Size = new System.Drawing.Size(225, 24);
            this.GainingAccountDetail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gaining EC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Organization:";
            // 
            // GainingAccountLabel
            // 
            this.GainingAccountLabel.AutoSize = true;
            this.GainingAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GainingAccountLabel.Location = new System.Drawing.Point(44, 222);
            this.GainingAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GainingAccountLabel.Name = "GainingAccountLabel";
            this.GainingAccountLabel.Size = new System.Drawing.Size(194, 26);
            this.GainingAccountLabel.TabIndex = 6;
            this.GainingAccountLabel.Text = "Gaining Account:";
            // 
            // LosingECDetail
            // 
            this.LosingECDetail.BackColor = System.Drawing.SystemColors.Control;
            this.LosingECDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LosingECDetail.Location = new System.Drawing.Point(272, 156);
            this.LosingECDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LosingECDetail.Name = "LosingECDetail";
            this.LosingECDetail.Size = new System.Drawing.Size(450, 24);
            this.LosingECDetail.TabIndex = 5;
            // 
            // LosingOrgDetail
            // 
            this.LosingOrgDetail.BackColor = System.Drawing.SystemColors.Control;
            this.LosingOrgDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LosingOrgDetail.Location = new System.Drawing.Point(272, 110);
            this.LosingOrgDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LosingOrgDetail.Name = "LosingOrgDetail";
            this.LosingOrgDetail.Size = new System.Drawing.Size(225, 24);
            this.LosingOrgDetail.TabIndex = 4;
            // 
            // LosingEC
            // 
            this.LosingEC.AutoSize = true;
            this.LosingEC.Location = new System.Drawing.Point(92, 154);
            this.LosingEC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LosingEC.Name = "LosingEC";
            this.LosingEC.Size = new System.Drawing.Size(117, 25);
            this.LosingEC.TabIndex = 3;
            this.LosingEC.Text = "Losing EC:";
            // 
            // LosingOrganization
            // 
            this.LosingOrganization.AutoSize = true;
            this.LosingOrganization.Location = new System.Drawing.Point(68, 106);
            this.LosingOrganization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LosingOrganization.Name = "LosingOrganization";
            this.LosingOrganization.Size = new System.Drawing.Size(140, 25);
            this.LosingOrganization.TabIndex = 2;
            this.LosingOrganization.Text = "Organization:";
            // 
            // LosingAccountDetail
            // 
            this.LosingAccountDetail.BackColor = System.Drawing.SystemColors.Control;
            this.LosingAccountDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LosingAccountDetail.Location = new System.Drawing.Point(272, 59);
            this.LosingAccountDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LosingAccountDetail.Name = "LosingAccountDetail";
            this.LosingAccountDetail.Size = new System.Drawing.Size(75, 24);
            this.LosingAccountDetail.TabIndex = 1;
            // 
            // LosingAccountLabel
            // 
            this.LosingAccountLabel.AutoSize = true;
            this.LosingAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LosingAccountLabel.Location = new System.Drawing.Point(44, 59);
            this.LosingAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LosingAccountLabel.Name = "LosingAccountLabel";
            this.LosingAccountLabel.Size = new System.Drawing.Size(182, 26);
            this.LosingAccountLabel.TabIndex = 0;
            this.LosingAccountLabel.Text = "Losing Account:";
            // 
            // TransferButton
            // 
            this.TransferButton.Enabled = false;
            this.TransferButton.Location = new System.Drawing.Point(964, 603);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(150, 60);
            this.TransferButton.TabIndex = 13;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // NewTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 690);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.TransferDetails);
            this.Controls.Add(this.TransferRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Transfer Asset";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.TransferRequest.ResumeLayout(false);
            this.TransferRequest.PerformLayout();
            this.TransferDetails.ResumeLayout(false);
            this.TransferDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LosingAccount;
        private System.Windows.Forms.Label GainingAccount;
        private System.Windows.Forms.Label SerialNumber;
        private System.Windows.Forms.TextBox GainingAccountField;
        private System.Windows.Forms.Button SearchAssetButton;
        private System.Windows.Forms.GroupBox TransferRequest;
        private System.Windows.Forms.GroupBox TransferDetails;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.TextBox LosingECDetail;
        private System.Windows.Forms.TextBox LosingOrgDetail;
        private System.Windows.Forms.Label LosingEC;
        private System.Windows.Forms.Label LosingOrganization;
        private System.Windows.Forms.TextBox LosingAccountDetail;
        private System.Windows.Forms.Label LosingAccountLabel;
        private System.Windows.Forms.TextBox GainingECDetail;
        private System.Windows.Forms.TextBox GainingOrganizationDetail;
        private System.Windows.Forms.TextBox GainingAccountDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GainingAccountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SerialNumberDetail;
        private System.Windows.Forms.TextBox AssetDetail;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox LosingAccountField;
        public System.Windows.Forms.TextBox SerialNumberField;
        private System.Windows.Forms.RichTextBox TransferNotesField;
        private System.Windows.Forms.Label label5;
    }
}