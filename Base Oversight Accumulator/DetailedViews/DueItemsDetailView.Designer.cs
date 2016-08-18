namespace Base_Oversight_Accumulator.DetailedViews
{
    partial class DueItemsDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DueItemsDetailView));
            this.AccountsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountsList
            // 
            this.AccountsList.FormattingEnabled = true;
            this.AccountsList.ItemHeight = 31;
            this.AccountsList.Location = new System.Drawing.Point(24, 105);
            this.AccountsList.Name = "AccountsList";
            this.AccountsList.Size = new System.Drawing.Size(1310, 562);
            this.AccountsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "The following accounts are due for inventory updates:\r\n\r\n";
            // 
            // ViewAccountButton
            // 
            this.ViewAccountButton.Location = new System.Drawing.Point(1184, 705);
            this.ViewAccountButton.Name = "ViewAccountButton";
            this.ViewAccountButton.Size = new System.Drawing.Size(150, 50);
            this.ViewAccountButton.TabIndex = 2;
            this.ViewAccountButton.Text = "View";
            this.ViewAccountButton.UseVisualStyleBackColor = true;
            this.ViewAccountButton.Click += new System.EventHandler(this.ViewAccountButton_Click);
            // 
            // DueItemsDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 808);
            this.Controls.Add(this.ViewAccountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DueItemsDetailView";
            this.Text = " Accounts Requiring Updates";
            this.Load += new System.EventHandler(this.DueItemsDetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AccountsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewAccountButton;
    }
}