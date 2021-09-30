namespace Clinic
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.VetButton = new System.Windows.Forms.Button();
            this.AdmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // VetButton
            // 
            this.VetButton.BackColor = System.Drawing.Color.White;
            this.VetButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VetButton.Location = new System.Drawing.Point(299, 68);
            this.VetButton.Margin = new System.Windows.Forms.Padding(4);
            this.VetButton.Name = "VetButton";
            this.VetButton.Size = new System.Drawing.Size(326, 49);
            this.VetButton.TabIndex = 0;
            this.VetButton.Text = "Войти как ветеринар";
            this.VetButton.UseVisualStyleBackColor = false;
            this.VetButton.Click += new System.EventHandler(this.VetButton_Click);
            // 
            // AdmButton
            // 
            this.AdmButton.BackColor = System.Drawing.Color.White;
            this.AdmButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdmButton.Location = new System.Drawing.Point(299, 125);
            this.AdmButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdmButton.Name = "AdmButton";
            this.AdmButton.Size = new System.Drawing.Size(326, 49);
            this.AdmButton.TabIndex = 1;
            this.AdmButton.Text = "Войти как администратор";
            this.AdmButton.UseVisualStyleBackColor = false;
            this.AdmButton.Click += new System.EventHandler(this.AdmButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(299, 181);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(326, 49);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Clinic.Properties.Resources.auto1;
            this.ClientSize = new System.Drawing.Size(984, 299);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AdmButton);
            this.Controls.Add(this.VetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VetButton;
        private System.Windows.Forms.Button AdmButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}

