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
    public partial class PetForm : Form
    {
        public PetForm(PetClass pet, ClientClass owner)
        {
            InitializeComponent();

            this.Size = new Size(570, 400);

            Label petlabel = new Label();
            petlabel.Location = new Point(200, 0);
            petlabel.Size = new Size(300, 150);
            petlabel.Text += "Номер договора: \nИмя: "+pet.name+"\nДата рождения: "+pet.dateofbirth.ToString()+"\nВозраст: "+pet.age+"\nПол: "+pet.gender+"\nВид: "+pet.kind+"\nПорода: "+pet.breed+"\nКастрирован: "+pet.castrade+ "\nВладелец:"+owner.Surname+owner.Name+owner.Lastname;
            this.Controls.Add(petlabel);

            int appointments = 17;
            int x = 10;
            int y = 170;
            for (int i = 0; i < appointments; i++)
            {
                if (x>=380)
                {
                    x = 10;
                    y += 40;
                }
                Button b = new Button();
                b.Location = new Point(x, y);
                b.Size = new Size(170, 30);
                b.Text = "Первичный " +"12.12.2019";
                b.TextAlign = ContentAlignment.MiddleLeft;
                this.Controls.Add(b);
                x += 180;
            }

        }
    }
}
