namespace Clinic
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеКлиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.питомцыToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПитомцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.потерянныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отданныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОНовыхКлиентахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентToolStripMenuItem,
            this.питомцыToolStripMenuItem2,
            this.отчетыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.всеКлиентыToolStripMenuItem});
            this.клиентToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.клиентToolStripMenuItem.Text = "Клиенты";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьклиентаToolStripMenuItem_Click);
            // 
            // всеКлиентыToolStripMenuItem
            // 
            this.всеКлиентыToolStripMenuItem.Name = "всеКлиентыToolStripMenuItem";
            this.всеКлиентыToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.всеКлиентыToolStripMenuItem.Text = "Все клиенты";
            this.всеКлиентыToolStripMenuItem.Click += new System.EventHandler(this.всеКлиентыToolStripMenuItem_Click);
            // 
            // питомцыToolStripMenuItem2
            // 
            this.питомцыToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.всеПитомцыToolStripMenuItem,
            this.потерянныеToolStripMenuItem,
            this.отданныеToolStripMenuItem});
            this.питомцыToolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.питомцыToolStripMenuItem2.Name = "питомцыToolStripMenuItem2";
            this.питомцыToolStripMenuItem2.Size = new System.Drawing.Size(113, 29);
            this.питомцыToolStripMenuItem2.Text = "Питомцы";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(222, 30);
            this.добавитьToolStripMenuItem1.Text = "Добавить ";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьпитомцаToolStripMenuItem1_Click);
            // 
            // всеПитомцыToolStripMenuItem
            // 
            this.всеПитомцыToolStripMenuItem.Name = "всеПитомцыToolStripMenuItem";
            this.всеПитомцыToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.всеПитомцыToolStripMenuItem.Text = "Все питомцы";
            this.всеПитомцыToolStripMenuItem.Click += new System.EventHandler(this.всеПитомцыToolStripMenuItem_Click);
            // 
            // потерянныеToolStripMenuItem
            // 
            this.потерянныеToolStripMenuItem.Name = "потерянныеToolStripMenuItem";
            this.потерянныеToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.потерянныеToolStripMenuItem.Text = "Потерянные";
            this.потерянныеToolStripMenuItem.Click += new System.EventHandler(this.потерянныеToolStripMenuItem_Click);
            // 
            // отданныеToolStripMenuItem
            // 
            this.отданныеToolStripMenuItem.Name = "отданныеToolStripMenuItem";
            this.отданныеToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.отданныеToolStripMenuItem.Text = "Отданные ";
            this.отданныеToolStripMenuItem.Click += new System.EventHandler(this.отданныеToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетОНовыхКлиентахToolStripMenuItem});
            this.отчетыToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.отчетыToolStripMenuItem.Text = "Отчеты ";
            // 
            // отчетОНовыхКлиентахToolStripMenuItem
            // 
            this.отчетОНовыхКлиентахToolStripMenuItem.Name = "отчетОНовыхКлиентахToolStripMenuItem";
            this.отчетОНовыхКлиентахToolStripMenuItem.Size = new System.Drawing.Size(332, 30);
            this.отчетОНовыхКлиентахToolStripMenuItem.Text = "Отчет о новых клиентах ";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 116);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(105, 27);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Фамилия";
            this.NameLabel.Visible = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(311, 116);
            this.SearchTextBox.MaxLength = 60;
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(416, 27);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.Visible = false;
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTTextBox_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(784, 105);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(130, 49);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 179);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(976, 418);
            this.dataGridView1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.Location = new System.Drawing.Point(12, 59);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(173, 25);
            this.PhoneLabel.TabIndex = 6;
            this.PhoneLabel.Text = "Номер телефона:";
            this.PhoneLabel.Visible = false;
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(311, 59);
            this.PhoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(415, 26);
            this.PhoneMaskedTextBox.TabIndex = 7;
            this.PhoneMaskedTextBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clinic.Properties.Resources.PETS_AS70594827_940x384;
            this.ClientSize = new System.Drawing.Size(1070, 841);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Система клиники \"Мягкая Лапка\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеКлиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem питомцыToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem всеПитомцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОНовыхКлиентахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem потерянныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отданныеToolStripMenuItem;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
    }
}