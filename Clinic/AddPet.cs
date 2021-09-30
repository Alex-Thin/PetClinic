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
using Clinic.Properties;

namespace Clinic
{
    public partial class AddPet : Form
    {
        SqlConnection sqlconnection;
        Controller controller;
        Check ch = new Check();
        string name, kind, breed;
        DateTime dateofbirth;
        int gender, typeofbreed, castrade;
        string purpose = "";
        public AddPet(SqlConnection SQLC)
        {
            InitializeComponent();
            this.Size = new Size(600, 550);
            purpose = "add";
            sqlconnection = SQLC;
            controller = new Controller(sqlconnection);

            GenderComboBox.Items.Add("Ж");
            GenderComboBox.Items.Add("М");
            DataTable kinds = controller.GetKinds();
            for (int i=0; i<kinds.Rows.Count; i++)
            {
                KindComboBox.Items.Add(kinds.Rows[i]["Kind"]);
            }
            DataTable owners = controller.ShowClientTable();
            for (int i=0; i<owners.Rows.Count; i++)
            {
                string surname = owners.Rows[i]["Surname"].ToString();
                string name = owners.Rows[i]["Name"].ToString();
                string lastname;
                if (owners.Rows[i]["Lastname"].ToString() != "")
                {
                    lastname = owners.Rows[i]["Lastname"].ToString();
                    OwnerComboBox.Items.Add(owners.Rows[i]["CodeOfClient"].ToString()+". "+ surname + " " + name.Remove(1, name.Length - 1) + ". " + lastname.Remove(1, lastname.Length - 1) + ". " + owners.Rows[i]["Питомцы"]);
                }else OwnerComboBox.Items.Add(owners.Rows[i]["CodeOfClient"].ToString() + ". " + surname + " " + name.Remove(1, name.Length - 1) + ". "+ owners.Rows[i]["Питомцы"]);

            }

        }
        public AddPet(SqlConnection SQLC, int code)
        {
            InitializeComponent();
            this.Size = new Size(600, 550);
            purpose = "change";
            sqlconnection = SQLC;
            controller = new Controller(sqlconnection);

            GenderComboBox.Items.Add("Ж");
            GenderComboBox.Items.Add("М");
            DataTable kinds = controller.GetKinds();
            for (int i = 0; i < kinds.Rows.Count; i++)
            {
                KindComboBox.Items.Add(kinds.Rows[i]["Kind"]);
            }
            DataTable owners = controller.ShowClientTable();
            for (int i = 0; i < owners.Rows.Count; i++)
            {
                string surname = owners.Rows[i]["Surname"].ToString();
                string name = owners.Rows[i]["Name"].ToString();
                string lastname;
                if (owners.Rows[i]["Lastname"].ToString() != "")
                {
                    lastname = owners.Rows[i]["Lastname"].ToString();
                    OwnerComboBox.Items.Add(owners.Rows[i]["CodeOfClient"].ToString() + ". " + surname + " " + name.Remove(1, name.Length - 1) + ". " + lastname.Remove(1, lastname.Length - 1) + ". " + owners.Rows[i]["Питомцы"]);
                }
                else OwnerComboBox.Items.Add(owners.Rows[i]["CodeOfClient"].ToString() + ". " + surname + " " + name.Remove(1, name.Length - 1) + ". " + owners.Rows[i]["Питомцы"]);

            }

        }

        private void AddOwnerButton_Click(object sender, EventArgs e)
        {
            AddClient owner = new AddClient(sqlconnection);
            owner.Owner = this;
            owner.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool check = true; 
            if (ch.CheckName(NameTextBox.Text))
            {
                NameTextBox.BackColor = Color.White;
                name = ch.CorrectName(NameTextBox.Text);
                NameTextBox.BackColor = Color.White;
            }else
            {
                NameTextBox.BackColor = Color.LightCoral;
                check = false;
            }
            if (!ch.CheckDate(DateOfBirthMaskedTextBox.Text))
            {
                DateOfBirthMaskedTextBox.BackColor = Color.LightCoral;
                check = false;
            }
            else
            {
                DateOfBirthMaskedTextBox.BackColor = Color.White;
                AgeTextBox.Text = ch.FindAge(DateTime.Parse(DateOfBirthMaskedTextBox.Text));
                dateofbirth = DateTime.Parse(DateOfBirthMaskedTextBox.Text);
            }
            if (GenderComboBox.SelectedIndex == -1)
            {
                GenderComboBox.BackColor = Color.LightCoral;
                check = false;
            }else
            {
                GenderComboBox.BackColor = Color.White;
                gender = GenderComboBox.SelectedIndex;
            }
            if(KindComboBox.SelectedIndex==-1)
            {
                KindComboBox.BackColor = Color.LightCoral;
                check = false;
            }
            else
            {
                KindComboBox.BackColor = Color.White;
                kind = KindComboBox.Text;
            }
            if ((BreedComboBox.Enabled==true)&&(BreedComboBox.SelectedIndex==-1))
            {
                BreedComboBox.BackColor = Color.LightCoral;
                check = false;
            }
            else
            {
                BreedComboBox.BackColor = Color.White;
                if (BreedComboBox.Enabled == true)
                    breed = BreedComboBox.Text;
            }
            if (CastradeCheckBox.Checked)
                castrade = 0;
            else castrade = 1;
            if (OwnerComboBox.SelectedIndex==-1)
            {
                OwnerComboBox.BackColor = Color.LightCoral;
                check = false;
            }else
            {
                OwnerComboBox.BackColor = Color.White;
            }
            if (check)
            {
                string o = OwnerComboBox.Text;
                int index = o.IndexOf('.');
                o = o.Remove(index, o.Length - index - 1);
                PetClass pet = new PetClass( gender, castrade, Int32.Parse(o), name, kind, breed, dateofbirth, AgeTextBox.Text);
                controller.AddPet(pet);
                this.Close();
            }
                
        }

        private void KindComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KindComboBox.SelectedIndex == 1)
            {
                BreedComboBox.Enabled = true;
                typeofbreed = 3;
                DataTable breeds = controller.GetBreeds(typeofbreed);
                BreedComboBox.Items.Clear();
                for (int i=0; i<breeds.Rows.Count; i++)
                {
                    BreedComboBox.Items.Add(breeds.Rows[i]["Name"]);
                }
                BreedComboBox.Items.Add("Другое...");
            }
            else
           if (KindComboBox.SelectedIndex == 11)
            {
                BreedComboBox.Enabled = true;
                typeofbreed = 2;
                DataTable breeds = controller.GetBreeds(typeofbreed);
                BreedComboBox.Items.Clear();
                for (int i = 0; i < breeds.Rows.Count; i++)
                {
                    BreedComboBox.Items.Add(breeds.Rows[i]["Name"]);
                }
                BreedComboBox.Items.Add("Другое...");
            }
            else
               if (KindComboBox.SelectedIndex == 12)
            {
                BreedComboBox.Enabled = true;
                typeofbreed = 1;
                DataTable breeds = controller.GetBreeds(typeofbreed);
                BreedComboBox.Items.Clear();
                for (int i = 0; i < breeds.Rows.Count; i++)
                {
                    BreedComboBox.Items.Add(breeds.Rows[i]["Name"]);
                }
                BreedComboBox.Items.Add("Другое...");
            }
            else BreedComboBox.Enabled = false;
            BreedComboBox.BackColor = Color.White;
        }

        private void DateOfBirthMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (DateOfBirthMaskedTextBox.MaskFull)
                if (ch.CheckDate(DateOfBirthMaskedTextBox.Text))
                {
                    AgeTextBox.Text = ch.FindAge(DateTime.Parse(DateOfBirthMaskedTextBox.Text));
                    DateOfBirthMaskedTextBox.BackColor = Color.White;
                }
        }
    }
}

