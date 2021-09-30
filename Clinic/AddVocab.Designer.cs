namespace Clinic
{
    partial class AddVocab
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddBreedButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(175, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(330, 29);
            this.NameTextBox.TabIndex = 7;
            // 
            // AddBreedButton
            // 
            this.AddBreedButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBreedButton.Location = new System.Drawing.Point(329, 67);
            this.AddBreedButton.Name = "AddBreedButton";
            this.AddBreedButton.Size = new System.Drawing.Size(176, 60);
            this.AddBreedButton.TabIndex = 6;
            this.AddBreedButton.Text = "Добавить";
            this.AddBreedButton.UseVisualStyleBackColor = false;
            this.AddBreedButton.Click += new System.EventHandler(this.AddBreedButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название:";
            // 
            // AddVocab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Clinic.Properties.Resources.kotya;
            this.ClientSize = new System.Drawing.Size(543, 326);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddBreedButton);
            this.Controls.Add(this.label2);
            this.Name = "AddVocab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddBreedButton;
        private System.Windows.Forms.Label label2;
    }
}