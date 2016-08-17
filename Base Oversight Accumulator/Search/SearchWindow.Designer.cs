namespace Base_Oversight_Accumulator
{
    partial class SearchWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchWindow));
            this.SearchTermLabel = new System.Windows.Forms.Label();
            this.SearchTerms = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchTermLabel
            // 
            this.SearchTermLabel.AutoSize = true;
            this.SearchTermLabel.Location = new System.Drawing.Point(46, 140);
            this.SearchTermLabel.Name = "SearchTermLabel";
            this.SearchTermLabel.Size = new System.Drawing.Size(93, 32);
            this.SearchTermLabel.TabIndex = 0;
            this.SearchTermLabel.Text = "label1";
            // 
            // SearchTerms
            // 
            this.SearchTerms.Location = new System.Drawing.Point(206, 134);
            this.SearchTerms.Name = "SearchTerms";
            this.SearchTerms.Size = new System.Drawing.Size(500, 38);
            this.SearchTerms.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(508, 218);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(198, 64);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(206, 78);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(93, 32);
            this.ErrorMessage.TabIndex = 3;
            this.ErrorMessage.Text = "label1";
            this.ErrorMessage.Visible = false;
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 341);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTerms);
            this.Controls.Add(this.SearchTermLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "SearchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchWindow";
            this.Load += new System.EventHandler(this.SearchWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchTermLabel;
        private System.Windows.Forms.TextBox SearchTerms;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ErrorMessage;
    }
}