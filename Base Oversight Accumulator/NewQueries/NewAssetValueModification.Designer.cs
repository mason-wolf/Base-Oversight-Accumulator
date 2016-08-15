namespace Base_Oversight_Accumulator
{
    partial class NewAssetValueModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAssetValueModification));
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManufacturerField = new System.Windows.Forms.TextBox();
            this.ModelField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AssignValueButton = new System.Windows.Forms.Button();
            this.ValueField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(127, 78);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(190, 32);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(216, 154);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(101, 32);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estimated Value:";
            // 
            // ManufacturerField
            // 
            this.ManufacturerField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ManufacturerField.Location = new System.Drawing.Point(358, 71);
            this.ManufacturerField.Name = "ManufacturerField";
            this.ManufacturerField.Size = new System.Drawing.Size(250, 38);
            this.ManufacturerField.TabIndex = 1;
            // 
            // ModelField
            // 
            this.ModelField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ModelField.Location = new System.Drawing.Point(358, 148);
            this.ModelField.Name = "ModelField";
            this.ModelField.Size = new System.Drawing.Size(250, 38);
            this.ModelField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "$";
            // 
            // AssignValueButton
            // 
            this.AssignValueButton.Location = new System.Drawing.Point(367, 295);
            this.AssignValueButton.Name = "AssignValueButton";
            this.AssignValueButton.Size = new System.Drawing.Size(323, 55);
            this.AssignValueButton.TabIndex = 4;
            this.AssignValueButton.Text = "Assign Asset Value";
            this.AssignValueButton.UseVisualStyleBackColor = true;
            this.AssignValueButton.Click += new System.EventHandler(this.AssignValueButton_Click);
            // 
            // ValueField
            // 
            this.ValueField.Location = new System.Drawing.Point(358, 220);
            this.ValueField.Name = "ValueField";
            this.ValueField.Size = new System.Drawing.Size(250, 38);
            this.ValueField.TabIndex = 3;
            // 
            // ModifyAssetValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 389);
            this.Controls.Add(this.ValueField);
            this.Controls.Add(this.AssignValueButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModelField);
            this.Controls.Add(this.ManufacturerField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyAssetValue";
            this.Text = " Asset Value";
            this.Load += new System.EventHandler(this.ModifyAssetValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ManufacturerField;
        private System.Windows.Forms.TextBox ModelField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AssignValueButton;
        private System.Windows.Forms.TextBox ValueField;
    }
}