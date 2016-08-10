namespace Base_Oversight_Accumulator
{
    partial class NewAssetBatch
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
            this.AssetBatchInput = new System.Windows.Forms.RichTextBox();
            this.AddBatchButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssetBatchInput
            // 
            this.AssetBatchInput.Location = new System.Drawing.Point(65, 67);
            this.AssetBatchInput.Name = "AssetBatchInput";
            this.AssetBatchInput.Size = new System.Drawing.Size(735, 648);
            this.AssetBatchInput.TabIndex = 0;
            this.AssetBatchInput.Text = "";
            // 
            // AddBatchButton
            // 
            this.AddBatchButton.Location = new System.Drawing.Point(327, 756);
            this.AddBatchButton.Name = "AddBatchButton";
            this.AddBatchButton.Size = new System.Drawing.Size(218, 50);
            this.AddBatchButton.TabIndex = 1;
            this.AddBatchButton.Text = "Add Assets";
            this.AddBatchButton.UseVisualStyleBackColor = true;
            this.AddBatchButton.Click += new System.EventHandler(this.AddBatchButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(582, 756);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(218, 50);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewAssetBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 858);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddBatchButton);
            this.Controls.Add(this.AssetBatchInput);
            this.Name = "NewAssetBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Serial Numbers:";
            this.Load += new System.EventHandler(this.NewAssetBatch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AssetBatchInput;
        private System.Windows.Forms.Button AddBatchButton;
        private System.Windows.Forms.Button CancelButton;
    }
}