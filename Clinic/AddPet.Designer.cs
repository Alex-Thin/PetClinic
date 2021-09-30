namespace Clinic
{
    partial class AddPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPet));
            this.NewPetLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.LinkLabel();
            this.DateOfBirthLabel = new System.Windows.Forms.LinkLabel();
            this.AgeLabel = new System.Windows.Forms.LinkLabel();
            this.GenderLabel = new System.Windows.Forms.LinkLabel();
            this.KindLabel = new System.Windows.Forms.LinkLabel();
            this.BreedLabel = new System.Windows.Forms.LinkLabel();
            this.CastradeLabel = new System.Windows.Forms.LinkLabel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.KindComboBox = new System.Windows.Forms.ComboBox();
            this.BreedComboBox = new System.Windows.Forms.ComboBox();
            this.CastradeCheckBox = new System.Windows.Forms.CheckBox();
            this.OwnerLabel = new System.Windows.Forms.LinkLabel();
            this.OwnerComboBox = new System.Windows.Forms.ComboBox();
            this.AddOwnerButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPetLabel
            // 
            this.NewPetLabel.AutoSize = true;
            this.NewPetLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPetLabel.Location = new System.Drawing.Point(210, 10);
            this.NewPetLabel.Name = "NewPetLabel";
            this.NewPetLabel.Size = new System.Drawing.Size(257, 37);
            this.NewPetLabel.TabIndex = 0;
            this.NewPetLabel.Text = "Новый питомец";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.LinkColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(39, 80);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(114, 29);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.TabStop = true;
            this.NameLabel.Text = "Кличка*:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.LinkColor = System.Drawing.Color.Black;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(39, 115);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(206, 29);
            this.DateOfBirthLabel.TabIndex = 4;
            this.DateOfBirthLabel.TabStop = true;
            this.DateOfBirthLabel.Text = "Дата рождения*: ";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.LinkColor = System.Drawing.Color.Black;
            this.AgeLabel.Location = new System.Drawing.Point(39, 150);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(107, 29);
            this.AgeLabel.TabIndex = 5;
            this.AgeLabel.TabStop = true;
            this.AgeLabel.Text = "Возраст:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.LinkColor = System.Drawing.Color.Black;
            this.GenderLabel.Location = new System.Drawing.Point(39, 184);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(77, 29);
            this.GenderLabel.TabIndex = 6;
            this.GenderLabel.TabStop = true;
            this.GenderLabel.Text = "Пол*:";
            // 
            // KindLabel
            // 
            this.KindLabel.AutoSize = true;
            this.KindLabel.LinkColor = System.Drawing.Color.Black;
            this.KindLabel.Location = new System.Drawing.Point(39, 219);
            this.KindLabel.Name = "KindLabel";
            this.KindLabel.Size = new System.Drawing.Size(76, 29);
            this.KindLabel.TabIndex = 7;
            this.KindLabel.TabStop = true;
            this.KindLabel.Text = "Вид*:";
            // 
            // BreedLabel
            // 
            this.BreedLabel.AutoSize = true;
            this.BreedLabel.LinkColor = System.Drawing.Color.Black;
            this.BreedLabel.Location = new System.Drawing.Point(39, 255);
            this.BreedLabel.Name = "BreedLabel";
            this.BreedLabel.Size = new System.Drawing.Size(101, 29);
            this.BreedLabel.TabIndex = 8;
            this.BreedLabel.TabStop = true;
            this.BreedLabel.Text = "Порода:";
            // 
            // CastradeLabel
            // 
            this.CastradeLabel.AutoSize = true;
            this.CastradeLabel.LinkColor = System.Drawing.Color.Black;
            this.CastradeLabel.Location = new System.Drawing.Point(39, 293);
            this.CastradeLabel.Name = "CastradeLabel";
            this.CastradeLabel.Size = new System.Drawing.Size(162, 29);
            this.CastradeLabel.TabIndex = 9;
            this.CastradeLabel.TabStop = true;
            this.CastradeLabel.Text = "Кастрирован:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(144, 77);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(244, 37);
            this.NameTextBox.TabIndex = 10;
            // 
            // DateOfBirthMaskedTextBox
            // 
            this.DateOfBirthMaskedTextBox.Location = new System.Drawing.Point(210, 112);
            this.DateOfBirthMaskedTextBox.Mask = "00/00/0000";
            this.DateOfBirthMaskedTextBox.Name = "DateOfBirthMaskedTextBox";
            this.DateOfBirthMaskedTextBox.Size = new System.Drawing.Size(178, 37);
            this.DateOfBirthMaskedTextBox.TabIndex = 11;
            this.DateOfBirthMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.DateOfBirthMaskedTextBox.Leave += new System.EventHandler(this.DateOfBirthMaskedTextBox_Leave);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Enabled = false;
            this.AgeTextBox.Location = new System.Drawing.Point(144, 147);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(244, 37);
            this.AgeTextBox.TabIndex = 12;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(144, 181);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(244, 37);
            this.GenderComboBox.TabIndex = 13;
            // 
            // KindComboBox
            // 
            this.KindComboBox.FormattingEnabled = true;
            this.KindComboBox.Location = new System.Drawing.Point(111, 216);
            this.KindComboBox.Name = "KindComboBox";
            this.KindComboBox.Size = new System.Drawing.Size(277, 37);
            this.KindComboBox.TabIndex = 14;
            this.KindComboBox.SelectedIndexChanged += new System.EventHandler(this.KindComboBox_SelectedIndexChanged);
            // 
            // BreedComboBox
            // 
            this.BreedComboBox.Enabled = false;
            this.BreedComboBox.FormattingEnabled = true;
            this.BreedComboBox.Location = new System.Drawing.Point(144, 252);
            this.BreedComboBox.Name = "BreedComboBox";
            this.BreedComboBox.Size = new System.Drawing.Size(244, 37);
            this.BreedComboBox.TabIndex = 15;
            // 
            // CastradeCheckBox
            // 
            this.CastradeCheckBox.AutoSize = true;
            this.CastradeCheckBox.Location = new System.Drawing.Point(185, 296);
            this.CastradeCheckBox.Name = "CastradeCheckBox";
            this.CastradeCheckBox.Size = new System.Drawing.Size(22, 21);
            this.CastradeCheckBox.TabIndex = 16;
            this.CastradeCheckBox.UseVisualStyleBackColor = true;
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.LinkColor = System.Drawing.Color.Black;
            this.OwnerLabel.Location = new System.Drawing.Point(39, 360);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(138, 29);
            this.OwnerLabel.TabIndex = 17;
            this.OwnerLabel.TabStop = true;
            this.OwnerLabel.Text = "Владелец*:";
            // 
            // OwnerComboBox
            // 
            this.OwnerComboBox.FormattingEnabled = true;
            this.OwnerComboBox.Location = new System.Drawing.Point(160, 357);
            this.OwnerComboBox.Name = "OwnerComboBox";
            this.OwnerComboBox.Size = new System.Drawing.Size(376, 37);
            this.OwnerComboBox.TabIndex = 18;
            // 
            // AddOwnerButton
            // 
            this.AddOwnerButton.Location = new System.Drawing.Point(322, 396);
            this.AddOwnerButton.Name = "AddOwnerButton";
            this.AddOwnerButton.Size = new System.Drawing.Size(214, 31);
            this.AddOwnerButton.TabIndex = 19;
            this.AddOwnerButton.Text = "Добавить владельца";
            this.AddOwnerButton.UseVisualStyleBackColor = true;
            this.AddOwnerButton.Click += new System.EventHandler(this.AddOwnerButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(322, 433);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(214, 40);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Сохранить запись";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1196, 928);
            this.BackgroundImage = global::Clinic.Properties.Resources.pets_right;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddOwnerButton);
            this.Controls.Add(this.OwnerComboBox);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.CastradeCheckBox);
            this.Controls.Add(this.BreedComboBox);
            this.Controls.Add(this.KindComboBox);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.DateOfBirthMaskedTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CastradeLabel);
            this.Controls.Add(this.BreedLabel);
            this.Controls.Add(this.KindLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NewPetLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPetLabel;
        private System.Windows.Forms.LinkLabel NameLabel;
        private System.Windows.Forms.LinkLabel DateOfBirthLabel;
        private System.Windows.Forms.LinkLabel AgeLabel;
        private System.Windows.Forms.LinkLabel GenderLabel;
        private System.Windows.Forms.LinkLabel KindLabel;
        private System.Windows.Forms.LinkLabel BreedLabel;
        private System.Windows.Forms.LinkLabel CastradeLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.MaskedTextBox DateOfBirthMaskedTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.ComboBox KindComboBox;
        private System.Windows.Forms.ComboBox BreedComboBox;
        private System.Windows.Forms.CheckBox CastradeCheckBox;
        private System.Windows.Forms.LinkLabel OwnerLabel;
        private System.Windows.Forms.Button AddOwnerButton;
        private System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.ComboBox OwnerComboBox;
    }
}