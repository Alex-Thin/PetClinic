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
    public partial class ProcApp : Form
    {
        int ProcCount = 0, ProcedureY;
        public ProcApp()
        {
            InitializeComponent();
            this.Size = new Size(650, 600);
            Toplabel.Location = new Point(220, 10);
            DLabel1.Location = new Point(10, 35);
            DateLabel.Location = new Point(55, 35);
            NLabel2.Location = new Point(10, 50);
            NameLabel.Location = new Point(65, 50);
            OLabel3.Location = new Point(10, 65);
            OwnerLabel.Location = new Point(80, 65);
            PLabel4.Location = new Point(10, 80);
            PhoneLabel.Location = new Point(125, 80);

            ProcedureGroupBox.Location = new Point(10, 100);
            ProcedureGroupBox.Size = new Size(620, 100);
            ProcedureButton.Location=new Point(340, 30);
            ProcedureY += 30;

        }
        private void ProcedureButton_Click(object sender, EventArgs e)
        {
            if (ProcCount == 5)
                MessageBox.Show("Невозможно добавить более 5 процедур в один прием");
            else
            {
                Procedure r = new Procedure();
                r.Owner = this;
                r.ShowDialog();

                Label lp = new Label();
                string type = "", medicine = "", dose = "";
                lp.Size = new Size(500, 50);
                lp.Text = "Тип процедуры: " + type + "\nПрепарат: " + medicine + "\nДозировка: " + dose;
                lp.Location = new Point(5, ProcedureY);
                lp.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                ProcedureGroupBox.Controls.Add(lp);
                ProcedureButton.Location = new Point(340, ProcedureY + 50);
                ProcedureY += 70;
                ProcCount += 1;
            }
        }
    }
}
