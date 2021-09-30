using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic
{
    public partial class MainForm : Form
    {
        SqlConnection sqlconnection;
        int worker;
        Controller controller;
        int choose;
        Check ch=new Check();
        public MainForm(int code, SqlConnection SQL)
        {
            InitializeComponent();
            sqlconnection = SQL;
            worker = code;
            controller = new Controller(sqlconnection);
            this.Size = new Size(700, 700);
            if (worker == 2)
            {
                menuStrip1.Items.Clear();
                ToolStripMenuItem clients = new ToolStripMenuItem("Клиенты");
                ToolStripMenuItem allclients = new ToolStripMenuItem("Все клиенты");
                clients.DropDownItems.Add(allclients);
                menuStrip1.Items.Add(clients);
                allclients.Click += всеКлиентыToolStripMenuItem_Click;
                ToolStripMenuItem pets = new ToolStripMenuItem("Питомцы");
                ToolStripMenuItem allpets = new ToolStripMenuItem("Все питомцы");
                ToolStripMenuItem addpet = new ToolStripMenuItem("Добавить");
                ToolStripMenuItem missed = new ToolStripMenuItem("Потерянные");
                ToolStripMenuItem given = new ToolStripMenuItem("Отданные");
                pets.DropDownItems.Add(addpet);
                pets.DropDownItems.Add(allpets);
                pets.DropDownItems.Add(missed);
                pets.DropDownItems.Add(given);
                menuStrip1.Items.Add(pets);
                allpets.Click += всеПитомцыToolStripMenuItem_Click;
                addpet.Click += добавитьпитомцаToolStripMenuItem1_Click;
                missed.Click += потерянныеToolStripMenuItem_Click;
                ToolStripMenuItem reports = new ToolStripMenuItem("Отчеты");
                ToolStripMenuItem NewClientReport = new ToolStripMenuItem("Отчет о новых клиентах");
                reports.DropDownItems.Add(NewClientReport);
                menuStrip1.Items.Add(reports);
                contextMenuStrip1.Items.Clear();
                
            }
            else
            {
                contextMenuStrip1.Items.Clear();
                contextMenuStrip1.Items.Add("Добавить запись о первичном приеме");
                contextMenuStrip1.Items.Add("Добавить запись о повторном приеме");
                contextMenuStrip1.Items.Add("Добавить запись о процедурном приеме");
                contextMenuStrip1.Items.Clear();
                menuStrip1.Items.Clear();
                ToolStripMenuItem clients = new ToolStripMenuItem("Клиенты");
                ToolStripMenuItem allclients = new ToolStripMenuItem("Все клиенты");
                clients.DropDownItems.Add(allclients);
                menuStrip1.Items.Add(clients);
                allclients.Click += всеКлиентыToolStripMenuItem_Click;
                ToolStripMenuItem pets = new ToolStripMenuItem("Питомцы");
                ToolStripMenuItem allpets = new ToolStripMenuItem("Все питомцы");
                pets.DropDownItems.Add(allpets);
                menuStrip1.Items.Add(pets);
                allpets.Click += всеПитомцыToolStripMenuItem_Click;
            }
        }
        private void всеКлиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choose = 1;
            NameLabel.Visible = true;
            NameLabel.Text = "Фамилия:";
            PhoneLabel.Visible = true;
            PhoneMaskedTextBox.Visible = true;
            SearchButton.Visible = true;
            SearchTextBox.Visible = true;
            contextMenuStrip1.Items.Clear();

            ToolStripMenuItem delete = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.Add(delete);
            delete.Click += УдалитьКлиентаToolStripMenuItem_Click;
            ToolStripMenuItem change = new ToolStripMenuItem("Изменить");
            contextMenuStrip1.Items.Add(change);
            change.Click += ИзменитьКлиентаToolStripMenuItem_Click;
            ToolStripMenuItem openprofile = new ToolStripMenuItem("Открыть профиль");
            contextMenuStrip1.Items.Add(openprofile);
            openprofile.Click += ОткрытьПрофильКлиентаToolStripMenuItem_Click;

            contextMenuStrip1.Items.Add("Получить уникальный код");
            DataTable clients = controller.ShowClientTable();
            dataGridView1.DataSource = clients;
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Имя";
            dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[4].HeaderCell.Value = "Адрес";
            dataGridView1.Columns[6].HeaderCell.Value = "Номер телефона";
            dataGridView1.Columns[0].Visible = false;
        }

        private void УдалитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                controller.DeleteClient(Int32.Parse(dataGridView1[0, index].Value.ToString()));
                dataGridView1.DataSource=controller.ShowClientTable();
            }
        }
        private void ИзменитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                Form f = new AddClient(sqlconnection, Int32.Parse(dataGridView1[0, index].Value.ToString()));
                f.Show();
                dataGridView1.DataSource = null;
            }
        }
        private void ОткрытьПрофильКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            Form f = new Client( Int32.Parse(dataGridView1[0, index].Value.ToString()), sqlconnection);
            f.Show();
        }
        private void всеПитомцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choose = 2;
            NameLabel.Visible = true;
            NameLabel.Text = "Кличка";
            PhoneLabel.Visible = false;
            PhoneMaskedTextBox.Visible = false;
            SearchButton.Visible = true;
            SearchTextBox.Visible = true;
            contextMenuStrip1.Items.Clear();
            ToolStripMenuItem delete = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.Add(delete);
            delete.Click += удалитьпитомцаToolStripMenuItem_Click;
            ToolStripMenuItem change = new ToolStripMenuItem("Изменить");
            contextMenuStrip1.Items.Add(change);
            dataGridView1.DataSource = controller.ShowPetsTable();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderCell.Value = "Кличка";
            dataGridView1.Columns[2].HeaderCell.Value = "Вид";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            
        }
        private void добавитьклиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddClient = new AddClient(sqlconnection);
            AddClient.Show();
        }
        private void добавитьпитомцаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AddPet = new AddPet(sqlconnection);
            AddPet.Show();
        }

        private void потерянныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add("Вернуть в список");
            contextMenuStrip1.Items.Add("Добавить нового хозяина");
        }

        private void отданныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add("Добавить нового хозяина");
        }
        private void удалитьпитомцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Delete = new DeletePet();
            Delete.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = new AuthorizationForm();
            f.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                if (SearchTextBox.Text != "")
                {
                    string surname = ch.CorrectSurnameName(SearchTextBox.Text);
                    if (PhoneMaskedTextBox.MaskFull)
                    {                        
                        string phone = ch.CorrectPhone(PhoneMaskedTextBox.Text);
                        dataGridView1.DataSource = controller.SearchOwner(phone, surname);
                    }
                    else
                    {
                        dataGridView1.DataSource = controller.SearchOwner("", surname);
                    }
                }else if (PhoneMaskedTextBox.MaskFull)
                {
                    string phone = ch.CorrectPhone(PhoneMaskedTextBox.Text);
                    dataGridView1.DataSource = controller.SearchOwner(phone, "");
                }

            }
            PhoneMaskedTextBox.Text = "";
            SearchTextBox.Text = "";
        
    }

        private void SearchTTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (e.KeyChar.ToString() == "-") || (e.KeyChar == (char)Keys.Back)||(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
    }
}
