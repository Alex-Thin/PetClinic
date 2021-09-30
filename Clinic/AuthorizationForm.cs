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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.Size = new Size(600, 225);
            VetButton.Location = new Point(220, 45);
            AdmButton.Location = new Point(220, 85);
            ExitButton.Location = new Point(220, 125);
        }

        private void VetButton_Click(object sender, EventArgs e)
        {
            Form MainForm = new MainForm(1, sqlConnection1);
            MainForm.Show();
            this.Hide();
        }

        private void AdmButton_Click(object sender, EventArgs e)
        {
            Form MainForm = new MainForm(2, sqlConnection1);
            MainForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
