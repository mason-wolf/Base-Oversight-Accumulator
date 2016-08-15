namespace Base_Oversight_Accumulator
{
    partial class SaveDataGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveDataGridView));
            this.AssetsButton = new System.Windows.Forms.RadioButton();
            this.ECButton = new System.Windows.Forms.RadioButton();
            this.AccountsButton = new System.Windows.Forms.RadioButton();
            this.TransfersButton = new System.Windows.Forms.RadioButton();
            this.IssuedItemsButton = new System.Windows.Forms.RadioButton();
            this.ActionLogButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssetsButton
            // 
            this.AssetsButton.AutoSize = true;
            this.AssetsButton.Location = new System.Drawing.Point(169, 42);
            this.AssetsButton.Name = "AssetsButton";
            this.AssetsButton.Size = new System.Drawing.Size(137, 36);
            this.AssetsButton.TabIndex = 0;
            this.AssetsButton.TabStop = true;
            this.AssetsButton.Tag = "assets";
            this.AssetsButton.Text = "Assets";
            this.AssetsButton.UseVisualStyleBackColor = true;
            this.AssetsButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ECButton
            // 
            this.ECButton.AutoSize = true;
            this.ECButton.Location = new System.Drawing.Point(169, 100);
            this.ECButton.Name = "ECButton";
            this.ECButton.Size = new System.Drawing.Size(339, 36);
            this.ECButton.TabIndex = 1;
            this.ECButton.TabStop = true;
            this.ECButton.Tag = "ec";
            this.ECButton.Text = "Equipment Custodians";
            this.ECButton.UseVisualStyleBackColor = true;
            this.ECButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // AccountsButton
            // 
            this.AccountsButton.AutoSize = true;
            this.AccountsButton.Location = new System.Drawing.Point(169, 157);
            this.AccountsButton.Name = "AccountsButton";
            this.AccountsButton.Size = new System.Drawing.Size(169, 36);
            this.AccountsButton.TabIndex = 2;
            this.AccountsButton.TabStop = true;
            this.AccountsButton.Tag = "accounts";
            this.AccountsButton.Text = "Accounts";
            this.AccountsButton.UseVisualStyleBackColor = true;
            this.AccountsButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // TransfersButton
            // 
            this.TransfersButton.AutoSize = true;
            this.TransfersButton.Location = new System.Drawing.Point(169, 213);
            this.TransfersButton.Name = "TransfersButton";
            this.TransfersButton.Size = new System.Drawing.Size(171, 36);
            this.TransfersButton.TabIndex = 3;
            this.TransfersButton.TabStop = true;
            this.TransfersButton.Tag = "transfers";
            this.TransfersButton.Text = "Transfers";
            this.TransfersButton.UseVisualStyleBackColor = true;
            this.TransfersButton.CheckedChanged += new System.EventHandler(this.TransfersButton_CheckedChanged);
            // 
            // IssuedItemsButton
            // 
            this.IssuedItemsButton.AutoSize = true;
            this.IssuedItemsButton.Location = new System.Drawing.Point(169, 266);
            this.IssuedItemsButton.Name = "IssuedItemsButton";
            this.IssuedItemsButton.Size = new System.Drawing.Size(210, 36);
            this.IssuedItemsButton.TabIndex = 4;
            this.IssuedItemsButton.TabStop = true;
            this.IssuedItemsButton.Tag = "issueditems";
            this.IssuedItemsButton.Text = "Issued Items";
            this.IssuedItemsButton.UseVisualStyleBackColor = true;
            this.IssuedItemsButton.CheckedChanged += new System.EventHandler(this.IssuedItemsButton_CheckedChanged);
            // 
            // ActionLogButton
            // 
            this.ActionLogButton.AutoSize = true;
            this.ActionLogButton.Location = new System.Drawing.Point(169, 326);
            this.ActionLogButton.Name = "ActionLogButton";
            this.ActionLogButton.Size = new System.Drawing.Size(187, 36);
            this.ActionLogButton.TabIndex = 5;
            this.ActionLogButton.TabStop = true;
            this.ActionLogButton.Tag = "actionlog";
            this.ActionLogButton.Text = "Action Log";
            this.ActionLogButton.UseVisualStyleBackColor = true;
            this.ActionLogButton.CheckedChanged += new System.EventHandler(this.ActionLogButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ActionLogButton);
            this.Controls.Add(this.IssuedItemsButton);
            this.Controls.Add(this.TransfersButton);
            this.Controls.Add(this.AccountsButton);
            this.Controls.Add(this.ECButton);
            this.Controls.Add(this.AssetsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaveDataGridView";
            this.Text = " Select dataset to save..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AssetsButton;
        private System.Windows.Forms.RadioButton ECButton;
        private System.Windows.Forms.RadioButton AccountsButton;
        private System.Windows.Forms.RadioButton TransfersButton;
        private System.Windows.Forms.RadioButton IssuedItemsButton;
        private System.Windows.Forms.RadioButton ActionLogButton;
        private System.Windows.Forms.Button button1;
    }
}