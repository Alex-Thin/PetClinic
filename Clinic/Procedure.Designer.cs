namespace Clinic
{
    partial class Procedure
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
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.MedicineLabel = new System.Windows.Forms.Label();
            this.DoseLabel = new System.Windows.Forms.Label();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.DoseTextBox = new System.Windows.Forms.TextBox();
            this.MedicineComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(230, 194);
            this.CommentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommentTextBox.Size = new System.Drawing.Size(159, 26);
            this.CommentTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(465, 245);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 29);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(41, 28);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(126, 25);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Процедура: ";
            // 
            // MedicineLabel
            // 
            this.MedicineLabel.AutoSize = true;
            this.MedicineLabel.Location = new System.Drawing.Point(41, 85);
            this.MedicineLabel.Name = "MedicineLabel";
            this.MedicineLabel.Size = new System.Drawing.Size(112, 25);
            this.MedicineLabel.TabIndex = 3;
            this.MedicineLabel.Text = "Препарат: ";
            // 
            // DoseLabel
            // 
            this.DoseLabel.AutoSize = true;
            this.DoseLabel.Location = new System.Drawing.Point(78, 148);
            this.DoseLabel.Name = "DoseLabel";
            this.DoseLabel.Size = new System.Drawing.Size(112, 25);
            this.DoseLabel.TabIndex = 4;
            this.DoseLabel.Text = "Дозировка";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(48, 202);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(142, 25);
            this.CommentLabel.TabIndex = 5;
            this.CommentLabel.Text = "Комментарий";
            // 
            // DoseTextBox
            // 
            this.DoseTextBox.Location = new System.Drawing.Point(338, 148);
            this.DoseTextBox.Multiline = true;
            this.DoseTextBox.Name = "DoseTextBox";
            this.DoseTextBox.Size = new System.Drawing.Size(100, 28);
            this.DoseTextBox.TabIndex = 6;
            // 
            // MedicineComboBox
            // 
            this.MedicineComboBox.FormattingEnabled = true;
            this.MedicineComboBox.Location = new System.Drawing.Point(306, 100);
            this.MedicineComboBox.Name = "MedicineComboBox";
            this.MedicineComboBox.Size = new System.Drawing.Size(350, 33);
            this.MedicineComboBox.TabIndex = 7;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(457, 48);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(350, 33);
            this.TypeComboBox.TabIndex = 8;
            // 
            // Procedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(957, 324);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.MedicineComboBox);
            this.Controls.Add(this.DoseTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.DoseLabel);
            this.Controls.Add(this.MedicineLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CommentTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Procedure";
            this.Text = "Procedure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label MedicineLabel;
        private System.Windows.Forms.Label DoseLabel;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox DoseTextBox;
        private System.Windows.Forms.ComboBox MedicineComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
    }
}