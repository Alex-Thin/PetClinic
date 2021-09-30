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
    public partial class AddClient : Form
    {
        AddPet main;
        Controller controller;
        SqlConnection sqlconnection;
        Check ch = new Check();
        int Code;
        string purpose="";
        public AddClient(SqlConnection sqlc)
        {
            InitializeComponent();
            this.Size = new Size(600, 420);
            sqlconnection = sqlc;
            controller = new Controller(sqlconnection);
            purpose = "add";
            
        }
        public AddClient(SqlConnection sqlc, int code)
        {
            InitializeComponent();
            this.Size = new Size(600, 420);
            sqlconnection = sqlc;
            controller = new Controller(sqlconnection);
            purpose = "change";
            Code = code;
            ClientClass client = controller.FindClient(code);
            NameTextBox.Text = client.Name;
            SurnameTextBox.Text = client.Surname;
            LastnameTextBox.Text = client.Lastname;
            EmailTextBox.Text = client.Email;
            AddressTextBox.Text = client.Address;
            PhoneMaskedTextBox.Text = client.Phone.Remove(1, 1);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool check = true;
            string surname = "", name = "", lastname = null, address = null, email = null, phone = "";
            if (!ch.CheckSurname(SurnameTextBox.Text))
            {
                check = false;
                SurnameTextBox.BackColor = Color.LightCoral;
            }
            else
            {
                SurnameTextBox.BackColor = Color.White;
                surname += ch.CorrectSurnameName(SurnameTextBox.Text);
                SurnameTextBox.Text = surname;
            }
            if (!ch.CheckName(NameTextBox.Text))
            {
                NameTextBox.BackColor = Color.LightCoral;
                check = false;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
                name += ch.CorrectName(NameTextBox.Text);
                NameTextBox.Text = name;
            }
            if (LastnameTextBox.Text!="")
            {
                lastname = ch.CorrectName(LastnameTextBox.Text);
                LastnameTextBox.Text = lastname;
            }
            if (ch.CheckAddress(AddressTextBox.Text))
                address = AddressTextBox.Text;               
            if (EmailTextBox.Text != "")
                email = EmailTextBox.Text;
            if (PhoneMaskedTextBox.MaskFull)
            {
                PhoneMaskedTextBox.BackColor = Color.White;
                phone += ch.CorrectPhone(PhoneMaskedTextBox.Text);
            }
            else
            {
                PhoneMaskedTextBox.BackColor = Color.LightCoral;
                check = false;
            }
            if (check)
            {
                ClientClass owner = new ClientClass(name, surname, lastname, address, email, phone);

                if (purpose == "add")
                {
                    controller.AddOwner(owner);
                    int code = controller.GetCodeOwner();
                    string client;
                    if ((lastname != "") && (lastname != null))
                    {
                        client = code + ". " + surname + " " + name.Remove(1, name.Length - 1) + ". " + lastname.Remove(1, lastname.Length - 1) + ". ";
                    }
                    else client = code + ". " + surname + " " + name.Remove(1, name.Length - 1) + ".";
                    main = this.Owner as AddPet;
                    main.OwnerComboBox.Items.Add(client);
                    main.OwnerComboBox.SelectedIndex = main.OwnerComboBox.Items.Count - 1;
                    this.Close();
                }else
                {
                    controller.UpdateClient(Code, owner);
                    this.Close();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (e.KeyChar.ToString() == "-")||(e.KeyChar==(char)Keys.Back))
            {
                e.Handled = false;
            }
            else e.Handled = true;               
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }
    }
}
