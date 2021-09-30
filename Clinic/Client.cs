using Clinic.Properties;
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
    public partial class Client : Form
    {
        SqlConnection sqlconnection;
        Controller controller;
        Check ch = new Check();
        public Client(int code, SqlConnection SQLC)
        {
            InitializeComponent();
            sqlconnection = SQLC;
            controller = new Controller(sqlconnection);
            this.Size = new Size(470, 600);

            ClientClass client = controller.FindClient(code);
            DataTable dtpets = controller.FindPet(code);

            Label CL = new Label();
            CL.Location = new Point(0, 0);
            CL.Size = new Size(450, 80);
            CL.Text += "Владелец: " + client.Surname.ToString() + " " + client.Name + " " + client.Lastname + "\nАдрес: " + client.Address + "\nEmail: " + client.Email + "\nМобильный телефон: " + client.Phone;
            this.Controls.Add(CL);

            int pets=dtpets.Rows.Count;
            int y = 80;
            for (int i = 0; i < pets; i++)
            {
                Button b = new Button();
                b.Location = new Point(25, y);
                b.Size = new Size(400, 95);
                string tabs = "                          ";
                int codeofkind = Int32.Parse(dtpets.Rows[i]["Kind"].ToString());
                string kind = controller.GetNameOfVocabularity(codeofkind, "Kinds","Kind", "CodeOfClient");
                int codeofBreed = Int32.Parse(dtpets.Rows[i]["Breed"].ToString());
                string breed = controller.GetNameOfVocabularity(codeofBreed, "Breeds", "Name", "CodeOfBreed");
                string age = ch.FindAge((DateTime)(dtpets.Rows[i]["DateOfBirth"]));
                b.Text = tabs + "Имя: "+dtpets.Rows[i]["Name"]+" \n" + tabs + "Вид: "+kind+"\n" + tabs + "Порода:"+breed+" \n" + tabs + "Возраст: "+age+"\n" + tabs + "Номер договора:"+dtpets.Rows[i]["CodeOfContract"];
                b.TextAlign = ContentAlignment.TopLeft;
                switch (kind)
                {
                    case "Грызуны":
                        {
                            //b.BackgroundImage = Resources.rat;
                        }break;
                    case "Птицы":
                        {
                            //b.BackgroundImage = Resources.parrot;
                        }
                        break;
                    case "Рептилии":
                        {
                            //b.BackgroundImage = Resources.snake;
                        }
                        break;
                    case "Кролик":
                        {
                            //b.BackgroundImage = Resources.rabbit;
                        }
                        break;
                    case "Хорек":
                        {
                            //b.BackgroundImage = Resources.ferret;
                        }
                        break;
                    case "Хомяк":
                        {
                            //b.BackgroundImage = Resources.rat;
                        }
                        break;
                    case "Насекомоядные":
                        {
                            //b.BackgroundImage = Resources.Ej;
                        }
                        break;
                    case "Сурикаты":
                        {
                            //b.BackgroundImage = Resources.meerkat;
                        }
                        break;
                    case "Сельскохозяйственные":
                        {
                            //b.BackgroundImage = Resources.cow;
                        }
                        break;
                    case "Моллюск":
                        {
                            //b.BackgroundImage = Resources.ocean;
                        }
                        break;
                    case "Рыбы":
                        {
                           // b.BackgroundImage = Resources.fish;
                        }
                        break;
                    case "Кошки":
                        {
                            //b.BackgroundImage = Resources.cat;
                        }
                        break;
                    case "Собаки":
                        {
                            //b.BackgroundImage = Resources.dog;
                        }
                        break;

                }
                this.Controls.Add(b);
                y += 105;
            }
        }
    }
}
