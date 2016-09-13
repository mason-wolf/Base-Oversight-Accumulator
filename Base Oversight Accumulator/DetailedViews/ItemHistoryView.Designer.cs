namespace Base_Oversight_Accumulator.DetailedViews
{
    partial class ItemHistoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemHistoryView));
            this.ItemHistory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ItemHistory
            // 
            this.ItemHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemHistory.BackColor = System.Drawing.SystemColors.Control;
            this.ItemHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemHistory.Location = new System.Drawing.Point(13, 13);
            this.ItemHistory.Name = "ItemHistory";
            this.ItemHistory.ReadOnly = true;
            this.ItemHistory.Size = new System.Drawing.Size(2201, 634);
            this.ItemHistory.TabIndex = 0;
            this.ItemHistory.Text = "";
            // 
            // ItemHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2226, 659);
            this.Controls.Add(this.ItemHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemHistoryView";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ItemHistoryView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ItemHistory;
    }
}