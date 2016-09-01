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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAssetWindow));
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
            this.AddBatchButton = new System.Windows.Forms.Button();
            this.AssetBatchCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(105, 103);
            this.Item.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(58, 25);
            this.Item.TabIndex = 0;
            this.Item.Text = "Item:";
            // 
            // NewItemType
            // 
            this.NewItemType.FormattingEnabled = true;
            this.NewItemType.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Printer",
            "Scanner",
            "Projector",
            "VOIP",
            "VTC",
            "Phone",
            "LMR",
            "Switch",
            "Server",
            "TV",
            "Other"});
            this.NewItemType.Location = new System.Drawing.Point(206, 103);
            this.NewItemType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewItemType.Name = "NewItemType";
            this.NewItemType.Size = new System.Drawing.Size(151, 33);
            this.NewItemType.TabIndex = 1;
            // 
            // NewItemManufacturer
            // 
            this.NewItemManufacturer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewItemManufacturer.Location = new System.Drawing.Point(206, 156);
            this.NewItemManufacturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewItemManufacturer.Name = "NewItemManufacturer";
            this.NewItemManufacturer.Size = new System.Drawing.Size(376, 31);
            this.NewItemManufacturer.TabIndex = 2;
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Location = new System.Drawing.Point(20, 161);
            this.Manufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(145, 25);
            this.Manufacturer.TabIndex = 5;
            this.Manufacturer.Text = "Manufacturer:";
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSize = true;
            this.SerialNumber.Location = new System.Drawing.Point(10, 208);
            this.SerialNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(154, 25);
            this.SerialNumber.TabIndex = 6;
            this.SerialNumber.Text = "Serial Number:";
            // 
            // NewItemSerialNumber
            // 
            this.NewItemSerialNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewItemSerialNumber.Location = new System.Drawing.Point(206, 208);
            this.NewItemSerialNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewItemSerialNumber.Name = "NewItemSerialNumber";
            this.NewItemSerialNumber.Size = new System.Drawing.Size(207, 31);
            this.NewItemSerialNumber.TabIndex = 3;
            // 
            // AccountNumber
            // 
            this.AccountNumber.AutoSize = true;
            this.AccountNumber.Location = new System.Drawing.Point(83, 260);
            this.AccountNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(72, 25);
            this.AccountNumber.TabIndex = 8;
            this.AccountNumber.Text = "Acct#:";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(87, 375);
            this.Model.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(77, 25);
            this.Model.TabIndex = 10;
            this.Model.Text = "Model:";
            // 
            // NewItemModel
            // 
            this.NewItemModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewItemModel.Location = new System.Drawing.Point(206, 370);
            this.NewItemModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewItemModel.Name = "NewItemModel";
            this.NewItemModel.Size = new System.Drawing.Size(376, 31);
            this.NewItemModel.TabIndex = 6;
            // 
            // Organization
            // 
            this.Organization.AutoSize = true;
            this.Organization.Location = new System.Drawing.Point(18, 315);
            this.Organization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(145, 25);
            this.Organization.TabIndex = 14;
            this.Organization.Text = "Organiziation:";
            // 
            // AddAssetButton
            // 
            this.AddAssetButton.Location = new System.Drawing.Point(206, 615);
            this.AddAssetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddAssetButton.Name = "AddAssetButton";
            this.AddAssetButton.Size = new System.Drawing.Size(112, 42);
            this.AddAssetButton.TabIndex = 10;
            this.AddAssetButton.Text = "Add";
            this.AddAssetButton.UseVisualStyleBackColor = true;
            this.AddAssetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewItemOwner
            // 
            this.NewItemOwner.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewItemOwner.Location = new System.Drawing.Point(206, 260);
            this.NewItemOwner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewItemOwner.Name = "NewItemOwner";
            this.NewItemOwner.Size = new System.Drawing.Size(76, 31);
            this.NewItemOwner.TabIndex = 4;
            // 
            // NewItemOrganization
            // 
            this.NewItemOrganization.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewItemOrganization.Location = new System.Drawing.Point(206, 315);
            this.NewItemOrganization.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewItemOrganization.Name = "NewItemOrganization";
            this.NewItemOrganization.Size = new System.Drawing.Size(376, 31);
            this.NewItemOrganization.TabIndex = 5;
            // 
            // EC
            // 
            this.EC.AutoSize = true;
            this.EC.Location = new System.Drawing.Point(116, 60);
            this.EC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EC.Name = "EC";
            this.EC.Size = new System.Drawing.Size(47, 25);
            this.EC.TabIndex = 19;
            this.EC.Text = "EC:";
            // 
            // NewEC
            // 
            this.NewEC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewEC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewEC.Location = new System.Drawing.Point(206, 55);
            this.NewEC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewEC.Name = "NewEC";
            this.NewEC.ReadOnly = true;
            this.NewEC.Size = new System.Drawing.Size(264, 31);
            this.NewEC.TabIndex = 0;
            // 
            // Building
            // 
            this.Building.AutoSize = true;
            this.Building.Location = new System.Drawing.Point(68, 438);
            this.Building.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(95, 25);
            this.Building.TabIndex = 21;
            this.Building.Text = "Building:";
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Location = new System.Drawing.Point(89, 495);
            this.Room.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(74, 25);
            this.Room.TabIndex = 22;
            this.Room.Text = "Room:";
            // 
            // NewBuilding
            // 
            this.NewBuilding.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewBuilding.Location = new System.Drawing.Point(206, 432);
            this.NewBuilding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewBuilding.Name = "NewBuilding";
            this.NewBuilding.Size = new System.Drawing.Size(76, 31);
            this.NewBuilding.TabIndex = 7;
            // 
            // NewRoom
            // 
            this.NewRoom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewRoom.Location = new System.Drawing.Point(206, 490);
            this.NewRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewRoom.Name = "NewRoom";
            this.NewRoom.Size = new System.Drawing.Size(76, 31);
            this.NewRoom.TabIndex = 8;
            // 
            // EstimatedValue
            // 
            this.EstimatedValue.AutoSize = true;
            this.EstimatedValue.Location = new System.Drawing.Point(48, 553);
            this.EstimatedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EstimatedValue.Name = "EstimatedValue";
            this.EstimatedValue.Size = new System.Drawing.Size(116, 25);
            this.EstimatedValue.TabIndex = 25;
            this.EstimatedValue.Text = "Est. Value:";
            // 
            // NewEstimatedValue
            // 
            this.NewEstimatedValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewEstimatedValue.Location = new System.Drawing.Point(206, 553);
            this.NewEstimatedValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewEstimatedValue.Name = "NewEstimatedValue";
            this.NewEstimatedValue.Size = new System.Drawing.Size(76, 31);
            this.NewEstimatedValue.TabIndex = 9;
            // 
            // ECSelectionButton
            // 
            this.ECSelectionButton.Location = new System.Drawing.Point(480, 55);
            this.ECSelectionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ECSelectionButton.Name = "ECSelectionButton";
            this.ECSelectionButton.Size = new System.Drawing.Size(112, 42);
            this.ECSelectionButton.TabIndex = 1;
            this.ECSelectionButton.Text = "Select";
            this.ECSelectionButton.UseVisualStyleBackColor = true;
            this.ECSelectionButton.Click += new System.EventHandler(this.ECSelectionButton_Click);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(649, 40);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(74, 25);
            this.NotesLabel.TabIndex = 28;
            this.NotesLabel.Text = "Notes:";
            // 
            // NewAssetNotes
            // 
            this.NewAssetNotes.Location = new System.Drawing.Point(653, 80);
            this.NewAssetNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewAssetNotes.Name = "NewAssetNotes";
            this.NewAssetNotes.Size = new System.Drawing.Size(405, 564);
            this.NewAssetNotes.TabIndex = 29;
            this.NewAssetNotes.Text = "";
            // 
            // AddBatchButton
            // 
            this.AddBatchButton.Enabled = false;
            this.AddBatchButton.Location = new System.Drawing.Point(343, 615);
            this.AddBatchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBatchButton.Name = "AddBatchButton";
            this.AddBatchButton.Size = new System.Drawing.Size(160, 42);
            this.AddBatchButton.TabIndex = 30;
            this.AddBatchButton.Text = "Add Batch";
            this.AddBatchButton.UseVisualStyleBackColor = true;
            this.AddBatchButton.Click += new System.EventHandler(this.AddBatchButton_Click);
            // 
            // AssetBatchCheckBox
            // 
            this.AssetBatchCheckBox.AutoSize = true;
            this.AssetBatchCheckBox.Location = new System.Drawing.Point(430, 210);
            this.AssetBatchCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AssetBatchCheckBox.Name = "AssetBatchCheckBox";
            this.AssetBatchCheckBox.Size = new System.Drawing.Size(143, 29);
            this.AssetBatchCheckBox.TabIndex = 31;
            this.AssetBatchCheckBox.Text = "Use Batch";
            this.AssetBatchCheckBox.UseVisualStyleBackColor = true;
            this.AssetBatchCheckBox.CheckedChanged += new System.EventHandler(this.AssetBatchCheckBox_CheckedChanged);
            // 
            // NewAssetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 727);
            this.Controls.Add(this.AssetBatchCheckBox);
            this.Controls.Add(this.AddBatchButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewAssetWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " New Asset";
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
        private System.Windows.Forms.Button AddBatchButton;
        private System.Windows.Forms.CheckBox AssetBatchCheckBox;
        public System.Windows.Forms.TextBox NewItemOwner;
        public System.Windows.Forms.TextBox NewItemOrganization;
    }
}