namespace Clinic
{
    partial class AddBreedForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.AddBreedButton = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип породы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название:";
            // 
            // AddBreedButton
            // 
            this.AddBreedButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBreedButton.Location = new System.Drawing.Point(329, 119);
            this.AddBreedButton.Name = "AddBreedButton";
            this.AddBreedButton.Size = new System.Drawing.Size(176, 60);
            this.AddBreedButton.TabIndex = 2;
            this.AddBreedButton.Text = "Добавить";
            this.AddBreedButton.UseVisualStyleBackColor = false;
            this.AddBreedButton.Click += new System.EventHandler(this.AddBreedButton_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(175, 9);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(330, 37);
            this.TypeComboBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(175, 64);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(330, 37);
            this.NameTextBox.TabIndex = 4;
            // 
            // AddBreedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1123, 828);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.AddBreedButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBreedForm";
            this.Text = "Добавление породы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBreedButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}