namespace Base_Oversight_Accumulator.NewQueries
{
    partial class UpdateItemManufacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemManufacturer));
            this.label1 = new System.Windows.Forms.Label();
            this.ManufacturerField = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manufacturer:";
            // 
            // ManufacturerField
            // 
            this.ManufacturerField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ManufacturerField.Location = new System.Drawing.Point(329, 124);
            this.ManufacturerField.Name = "ManufacturerField";
            this.ManufacturerField.Size = new System.Drawing.Size(300, 38);
            this.ManufacturerField.TabIndex = 5;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(660, 124);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(150, 50);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // UpdateItemManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 284);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ManufacturerField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateItemManufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Update Item Manufacturer";
            this.Load += new System.EventHandler(this.UpdateItemManufacturer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ManufacturerField;
        private System.Windows.Forms.Button ApplyButton;
    }
}