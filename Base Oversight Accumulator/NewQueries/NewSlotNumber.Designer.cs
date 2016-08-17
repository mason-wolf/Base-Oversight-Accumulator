namespace Base_Oversight_Accumulator.NewQueries
{
    partial class NewSlotNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSlotNumber));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MakeModelField = new System.Windows.Forms.TextBox();
            this.SlotNumberField = new System.Windows.Forms.TextBox();
            this.AddSlotNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make/Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "NSN:";
            // 
            // MakeModelField
            // 
            this.MakeModelField.Location = new System.Drawing.Point(300, 61);
            this.MakeModelField.Name = "MakeModelField";
            this.MakeModelField.Size = new System.Drawing.Size(500, 38);
            this.MakeModelField.TabIndex = 2;
            // 
            // SlotNumberField
            // 
            this.SlotNumberField.Location = new System.Drawing.Point(300, 146);
            this.SlotNumberField.Name = "SlotNumberField";
            this.SlotNumberField.Size = new System.Drawing.Size(500, 38);
            this.SlotNumberField.TabIndex = 3;
            // 
            // AddSlotNumberButton
            // 
            this.AddSlotNumberButton.Location = new System.Drawing.Point(650, 221);
            this.AddSlotNumberButton.Name = "AddSlotNumberButton";
            this.AddSlotNumberButton.Size = new System.Drawing.Size(150, 50);
            this.AddSlotNumberButton.TabIndex = 4;
            this.AddSlotNumberButton.Text = "Add";
            this.AddSlotNumberButton.UseVisualStyleBackColor = true;
            this.AddSlotNumberButton.Click += new System.EventHandler(this.AddSlotNumberButton_Click);
            // 
            // NewSlotNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 305);
            this.Controls.Add(this.AddSlotNumberButton);
            this.Controls.Add(this.SlotNumberField);
            this.Controls.Add(this.MakeModelField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewSlotNumber";
            this.Text = " Create National Slot Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MakeModelField;
        private System.Windows.Forms.TextBox SlotNumberField;
        private System.Windows.Forms.Button AddSlotNumberButton;
    }
}