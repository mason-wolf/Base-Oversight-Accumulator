namespace Base_Oversight_Accumulator
{
    partial class NewAssetWindow
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
            this.components = new System.ComponentModel.Container();
            this.Item = new System.Windows.Forms.Label();
            this.NewItemType = new System.Windows.Forms.ComboBox();
            this.NewItemManufacturer = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.Label();
            this.NewItemSerialNumber = new System.Windows.Forms.TextBox();
            this.AccountNumber = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.NewItemModel = new System.Windows.Forms.TextBox();
            this.Organization = new System.Windows.Forms.Label();
            this.AddAssetButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NewItemOwner = new System.Windows.Forms.TextBox();
            this.NewItemOrganization = new System.Windows.Forms.TextBox();
            this.EC = new System.Windows.Forms.Label();
            this.NewEC = new System.Windows.Forms.TextBox();
            this.Building = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.Label();
            this.NewBuilding = new System.Windows.Forms.TextBox();
            this.NewRoom = new System.Windows.Forms.TextBox();
            this.EstimatedValue = new System.Windows.Forms.Label();
            this.NewEstimatedValue = new System.Windows.Forms.TextBox();
            this.ECSelectionButton = new System.Windows.Forms.Button();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NewAssetNotes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(140, 56);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(77, 32);
            this.Item.TabIndex = 0;
            this.Item.Text = "Item:";
            this.Item.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewItemType
            // 
            this.NewItemType.FormattingEnabled = true;
            this.NewItemType.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Printer",
            "Scanner",
            "Phone",
            "Keyboard",
            "Mouse",
            "CAC Reader",
            "UPS",
            "KVM Switch",
            "Other"});
            this.NewItemType.Location = new System.Drawing.Point(274, 49);
            this.NewItemType.Name = "NewItemType";
            this.NewItemType.Size = new System.Drawing.Size(200, 39);
            this.NewItemType.TabIndex = 1;
            this.NewItemType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // NewItemManufacturer
            // 
            this.NewItemManufacturer.Location = new System.Drawing.Point(274, 465);
            this.NewItemManufacturer.Name = "NewItemManufacturer";
            this.NewItemManufacturer.Size = new System.Drawing.Size(250, 38);
            this.NewItemManufacturer.TabIndex = 4;
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Location = new System.Drawing.Point(27, 465);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(190, 32);
            this.Manufacturer.TabIndex = 5;
            this.Manufacturer.Text = "Manufacturer:";
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSize = true;
            this.SerialNumber.Location = new System.Drawing.Point(13, 258);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(204, 32);
            this.SerialNumber.TabIndex = 6;
            this.SerialNumber.Text = "Serial Number:";
            // 
            // NewItemSerialNumber
            // 
            this.NewItemSerialNumber.Location = new System.Drawing.Point(274, 258);
            this.NewItemSerialNumber.Name = "NewItemSerialNumber";
            this.NewItemSerialNumber.Size = new System.Drawing.Size(275, 38);
            this.NewItemSerialNumber.TabIndex = 7;
            // 
            // AccountNumber
            // 
            this.AccountNumber.AutoSize = true;
            this.AccountNumber.Location = new System.Drawing.Point(111, 322);
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(94, 32);
            this.AccountNumber.TabIndex = 8;
            this.AccountNumber.Text = "Acct#:";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(116, 188);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(101, 32);
            this.Model.TabIndex = 10;
            this.Model.Text = "Model:";
            // 
            // NewItemModel
            // 
            this.NewItemModel.Location = new System.Drawing.Point(274, 188);
            this.NewItemModel.Name = "NewItemModel";
            this.NewItemModel.Size = new System.Drawing.Size(250, 38);
            this.NewItemModel.TabIndex = 11;
            // 
            // Organization
            // 
            this.Organization.AutoSize = true;
            this.Organization.Location = new System.Drawing.Point(24, 390);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(193, 32);
            this.Organization.TabIndex = 14;
            this.Organization.Text = "Organiziation:";
            // 
            // AddAssetButton
            // 
            this.AddAssetButton.Location = new System.Drawing.Point(274, 762);
            this.AddAssetButton.Name = "AddAssetButton";
            this.AddAssetButton.Size = new System.Drawing.Size(150, 52);
            this.AddAssetButton.TabIndex = 15;
            this.AddAssetButton.Text = "Add";
            this.AddAssetButton.UseVisualStyleBackColor = true;
            this.AddAssetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewItemOwner
            // 
            this.NewItemOwner.Location = new System.Drawing.Point(274, 322);
            this.NewItemOwner.Name = "NewItemOwner";
            this.NewItemOwner.Size = new System.Drawing.Size(100, 38);
            this.NewItemOwner.TabIndex = 17;
            // 
            // NewItemOrganization
            // 
            this.NewItemOrganization.Location = new System.Drawing.Point(274, 390);
            this.NewItemOrganization.Name = "NewItemOrganization";
            this.NewItemOrganization.Size = new System.Drawing.Size(200, 38);
            this.NewItemOrganization.TabIndex = 18;
            // 
            // EC
            // 
            this.EC.AutoSize = true;
            this.EC.Location = new System.Drawing.Point(143, 128);
            this.EC.Name = "EC";
            this.EC.Size = new System.Drawing.Size(62, 32);
            this.EC.TabIndex = 19;
            this.EC.Text = "EC:";
            // 
            // NewEC
            // 
            this.NewEC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewEC.Location = new System.Drawing.Point(274, 122);
            this.NewEC.Name = "NewEC";
            this.NewEC.ReadOnly = true;
            this.NewEC.Size = new System.Drawing.Size(350, 38);
            this.NewEC.TabIndex = 20;
            // 
            // Building
            // 
            this.Building.AutoSize = true;
            this.Building.Location = new System.Drawing.Point(90, 543);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(127, 32);
            this.Building.TabIndex = 21;
            this.Building.Text = "Building:";
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Location = new System.Drawing.Point(119, 614);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(98, 32);
            this.Room.TabIndex = 22;
            this.Room.Text = "Room:";
            // 
            // NewBuilding
            // 
            this.NewBuilding.Location = new System.Drawing.Point(274, 536);
            this.NewBuilding.Name = "NewBuilding";
            this.NewBuilding.Size = new System.Drawing.Size(100, 38);
            this.NewBuilding.TabIndex = 23;
            // 
            // NewRoom
            // 
            this.NewRoom.Location = new System.Drawing.Point(274, 607);
            this.NewRoom.Name = "NewRoom";
            this.NewRoom.Size = new System.Drawing.Size(100, 38);
            this.NewRoom.TabIndex = 24;
            // 
            // EstimatedValue
            // 
            this.EstimatedValue.AutoSize = true;
            this.EstimatedValue.Location = new System.Drawing.Point(64, 686);
            this.EstimatedValue.Name = "EstimatedValue";
            this.EstimatedValue.Size = new System.Drawing.Size(153, 32);
            this.EstimatedValue.TabIndex = 25;
            this.EstimatedValue.Text = "Est. Value:";
            // 
            // NewEstimatedValue
            // 
            this.NewEstimatedValue.Location = new System.Drawing.Point(274, 686);
            this.NewEstimatedValue.Name = "NewEstimatedValue";
            this.NewEstimatedValue.Size = new System.Drawing.Size(100, 38);
            this.NewEstimatedValue.TabIndex = 26;
            // 
            // ECSelectionButton
            // 
            this.ECSelectionButton.Location = new System.Drawing.Point(642, 117);
            this.ECSelectionButton.Name = "ECSelectionButton";
            this.ECSelectionButton.Size = new System.Drawing.Size(150, 52);
            this.ECSelectionButton.TabIndex = 27;
            this.ECSelectionButton.Text = "Select";
            this.ECSelectionButton.UseVisualStyleBackColor = true;
            this.ECSelectionButton.Click += new System.EventHandler(this.ECSelectionButton_Click);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(865, 49);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(97, 32);
            this.NotesLabel.TabIndex = 28;
            this.NotesLabel.Text = "Notes:";
            // 
            // NewAssetNotes
            // 
            this.NewAssetNotes.Location = new System.Drawing.Point(871, 99);
            this.NewAssetNotes.Name = "NewAssetNotes";
            this.NewAssetNotes.Size = new System.Drawing.Size(539, 698);
            this.NewAssetNotes.TabIndex = 29;
            this.NewAssetNotes.Text = "";
            // 
            // NewAssetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 902);
            this.Controls.Add(this.NewAssetNotes);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.ECSelectionButton);
            this.Controls.Add(this.NewEstimatedValue);
            this.Controls.Add(this.EstimatedValue);
            this.Controls.Add(this.NewRoom);
            this.Controls.Add(this.NewBuilding);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.Building);
            this.Controls.Add(this.NewEC);
            this.Controls.Add(this.EC);
            this.Controls.Add(this.NewItemOrganization);
            this.Controls.Add(this.NewItemOwner);
            this.Controls.Add(this.AddAssetButton);
            this.Controls.Add(this.Organization);
            this.Controls.Add(this.NewItemModel);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.AccountNumber);
            this.Controls.Add(this.NewItemSerialNumber);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.NewItemManufacturer);
            this.Controls.Add(this.NewItemType);
            this.Controls.Add(this.Item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewAssetWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Asset";
            this.Load += new System.EventHandler(this.NewAssetWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.ComboBox NewItemType;
        private System.Windows.Forms.TextBox NewItemManufacturer;
        private System.Windows.Forms.Label Manufacturer;
        private System.Windows.Forms.Label SerialNumber;
        private System.Windows.Forms.TextBox NewItemSerialNumber;
        private System.Windows.Forms.Label AccountNumber;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.TextBox NewItemModel;
        private System.Windows.Forms.Label Organization;
        private System.Windows.Forms.Button AddAssetButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox NewItemOwner;
        private System.Windows.Forms.TextBox NewItemOrganization;
        private System.Windows.Forms.Label EC;
        private System.Windows.Forms.Label Building;
        private System.Windows.Forms.Label Room;
        private System.Windows.Forms.TextBox NewBuilding;
        private System.Windows.Forms.TextBox NewRoom;
        private System.Windows.Forms.Label EstimatedValue;
        private System.Windows.Forms.TextBox NewEstimatedValue;
        private System.Windows.Forms.Button ECSelectionButton;
        public System.Windows.Forms.TextBox NewEC;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.RichTextBox NewAssetNotes;
    }
}