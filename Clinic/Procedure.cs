using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Procedure : Form
    {
        public Procedure()
        {
            InitializeComponent();
            this.Size = new Size(650, 280);

            TypeLabel.Location = new Point(10, 10);
            TypeComboBox.Location = new Point(100, 6);

            MedicineLabel.Location = new Point(10, 45);
            MedicineComboBox.Location = new Point(100, 41);

            DoseLabel.Location = new Point(10, 80);
            DoseTextBox.Location = new Point(100, 76);
            DoseTextBox.Size = new Size(100, 23);

            CommentLabel.Location = new Point(10, 115);
            CommentTextBox.Location = new Point(120, 111);
            CommentTextBox.Size = new Size(330, 60);

            AddButton.Location = new Point(350, 190);
        }
        FiratApp main;

        private void button1_Click(object sender, EventArgs e)
        {
            main = this.Owner as FiratApp;
            
            this.Close();
        }
    }
}
