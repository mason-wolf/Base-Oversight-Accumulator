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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAssetBatch));
            this.AssetBatchInput = new System.Windows.Forms.RichTextBox();
            this.AddBatchButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AssetBatchError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AssetBatchInput
            // 
            this.AssetBatchInput.Location = new System.Drawing.Point(49, 54);
            this.AssetBatchInput.Margin = new System.Windows.Forms.Padding(2);
            this.AssetBatchInput.Name = "AssetBatchInput";
            this.AssetBatchInput.Size = new System.Drawing.Size(636, 523);
            this.AssetBatchInput.TabIndex = 0;
            this.AssetBatchInput.Text = "";
            // 
            // AddBatchButton
            // 
            this.AddBatchButton.Location = new System.Drawing.Point(321, 610);
            this.AddBatchButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddBatchButton.Name = "AddBatchButton";
            this.AddBatchButton.Size = new System.Drawing.Size(164, 40);
            this.AddBatchButton.TabIndex = 1;
            this.AddBatchButton.Text = "Add Assets";
            this.AddBatchButton.UseVisualStyleBackColor = true;
            this.AddBatchButton.Click += new System.EventHandler(this.AddBatchButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(521, 610);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(164, 40);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AssetBatchError
            // 
            this.AssetBatchError.AutoSize = true;
            this.AssetBatchError.ForeColor = System.Drawing.Color.Red;
            this.AssetBatchError.Location = new System.Drawing.Point(44, 9);
            this.AssetBatchError.Name = "AssetBatchError";
            this.AssetBatchError.Size = new System.Drawing.Size(0, 25);
            this.AssetBatchError.TabIndex = 3;
            this.AssetBatchError.Visible = false;
            // 
            // NewAssetBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 692);
            this.Controls.Add(this.AssetBatchError);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddBatchButton);
            this.Controls.Add(this.AssetBatchInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewAssetBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Enter Serial Numbers:";
            this.Load += new System.EventHandler(this.NewAssetBatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox AssetBatchInput;
        private System.Windows.Forms.Button AddBatchButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label AssetBatchError;
    }
}