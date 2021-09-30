namespace Clinic
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.LinkLabel();
            this.NameLabel = new System.Windows.Forms.LinkLabel();
            this.LastNameLabel = new System.Windows.Forms.LinkLabel();
            this.AddressLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новый клиент";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.LinkColor = System.Drawing.Color.Black;
            this.SurnameLabel.Location = new System.Drawing.Point(48, 68);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(115, 25);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.TabStop = true;
            this.SurnameLabel.Text = "Фамилия*:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.LinkColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(48, 110);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.TabStop = true;
            this.NameLabel.Text = "Имя*:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.LinkColor = System.Drawing.Color.Black;
            this.LastNameLabel.Location = new System.Drawing.Point(48, 153);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(107, 25);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.TabStop = true;
            this.LastNameLabel.Text = "Отчество:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.LinkColor = System.Drawing.Color.Black;
            this.AddressLabel.Location = new System.Drawing.Point(48, 196);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(77, 25);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.TabStop = true;
            this.AddressLabel.Text = "Адрес:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(48, 239);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(267, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Адрес электронной почты:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(48, 283);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(190, 25);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Номер телефона*: ";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(416, 314);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(116, 43);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить ";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SurnameTextBox.Location = new System.Drawing.Point(173, 60);
            this.SurnameTextBox.MaxLength = 60;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(359, 33);
            this.SurnameTextBox.TabIndex = 8;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(173, 102);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(359, 33);
            this.NameTextBox.TabIndex = 9;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Location = new System.Drawing.Point(173, 145);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(359, 33);
            this.LastnameTextBox.TabIndex = 10;
            this.LastnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(173, 188);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(359, 33);
            this.AddressTextBox.TabIndex = 11;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(321, 231);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(211, 33);
            this.EmailTextBox.TabIndex = 12;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(244, 275);
            this.PhoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(288, 33);
            this.PhoneMaskedTextBox.TabIndex = 13;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1074, 840);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.LastnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel SurnameLabel;
        private System.Windows.Forms.LinkLabel NameLabel;
        private System.Windows.Forms.LinkLabel LastNameLabel;
        private System.Windows.Forms.LinkLabel AddressLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
    }
}