namespace Base_Oversight_Accumulator.Launch
{
    partial class ErrorDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorDetailView));
            this.ErrorMessageLable = new System.Windows.Forms.Label();
            this.ErrorDetailsField = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorMessageLable
            // 
            this.ErrorMessageLable.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLable.Location = new System.Drawing.Point(47, 48);
            this.ErrorMessageLable.Name = "ErrorMessageLable";
            this.ErrorMessageLable.Size = new System.Drawing.Size(1000, 32);
            this.ErrorMessageLable.TabIndex = 0;
            this.ErrorMessageLable.Text = "ErrorMessageLabel";
            // 
            // ErrorDetailsField
            // 
            this.ErrorDetailsField.Location = new System.Drawing.Point(53, 145);
            this.ErrorDetailsField.Name = "ErrorDetailsField";
            this.ErrorDetailsField.Size = new System.Drawing.Size(1004, 465);
            this.ErrorDetailsField.TabIndex = 1;
            this.ErrorDetailsField.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(907, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Details:";
            // 
            // ErrorDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrorDetailsField);
            this.Controls.Add(this.ErrorMessageLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorDetailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Error Details";
            this.Load += new System.EventHandler(this.ErrorDetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorMessageLable;
        private System.Windows.Forms.RichTextBox ErrorDetailsField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}