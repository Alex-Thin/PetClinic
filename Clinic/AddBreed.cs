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
    public partial class AddBreedForm : Form
    {
        SqlConnection sqlconnection;
        Controller controller;
        Check ch = new Check();
        public AddBreedForm(SqlConnection SQLC)
        {
            InitializeComponent();
            Size = new Size(600, 150);
            label1.Location = new Point(5, 10);
            TypeComboBox.Location = new Point(120, 8);
            TypeComboBox.Size = new Size(300, 33);
            label2.Location = new Point(5, 40);
            NameTextBox.Location = new Point(120, 38);
            NameTextBox.Size = new Size(300, 33);
            AddBreedButton.Location = new Point(343, 70);
            AddBreedButton.Size = new Size(80, 33);

            sqlconnection = SQLC;
            controller = new Controller(sqlconnection);
       
            DataTable types = controller.GetVocabulary("TypeOfBreed", "Name");
            for (int i = 0; i < types.Rows.Count; i++)
            {
                TypeComboBox.Items.Add(types.Rows[i]["Name"]);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (e.KeyChar==(char)Keys.Space)||(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void AddBreedButton_Click(object sender, EventArgs e)
        {
            bool check = true;
            int type=-1;
            string name="";
            if (TypeComboBox.SelectedIndex == -1)
            {
                TypeComboBox.BackColor = Color.LightCoral;
                check = false;
            }
            else
            {
                type = controller.GetCodeVocabulary("TypeOfBreed", "CodeOfType", TypeComboBox.Text, "Name");
                TypeComboBox.BackColor = Color.White;
            }
            if (!ch.CheckName(NameTextBox.Text))
            {
                NameTextBox.BackColor = Color.LightCoral;
                check = false;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
                name = NameTextBox.Text;
            }
            if (check)
            {
                controller.AddBreed(type, name);
                this.Close();
            }
        }
    }
}
