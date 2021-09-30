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
    public partial class AddVocab : Form
    {
        SqlConnection sqlconnection;
        int CODE;
        Controller controller;
        string app="";
        public AddVocab(string name, SqlConnection SQLC, int code, string App)
        {
            InitializeComponent();
            this.Text = name;
            CODE = code;
            sqlconnection = SQLC;
            controller = new Controller(sqlconnection);
            app = App.Remove(1, App.Length - 1);
            this.Size = new Size(300, 300);
        }

        private void AddBreedButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text!="")
            {
                
                switch (CODE)
                {
                    case 1:
                        {
                            controller.AddVocab(NameTextBox.Text, "TreatmentType", "TypeOfTreatment");
                        }break;
                    case 2:
                        {
                            controller.AddVocab(NameTextBox.Text, "Medicine", "Name");
                            if (app != "3")
                            {
                                FiratApp main = this.Owner as FiratApp;
                                main.medicine = controller.GetVocabulary("Medicine", "Name");
                                for (int i=0; i<main.MedicineGroupBox.Controls.Count; i++)
                                {
                                    if (main.MedicineGroupBox.Controls[i] is ComboBox)
                                    {
                                        ((ComboBox)main.MedicineGroupBox.Controls[i]).Items.Add(NameTextBox.Text);
                                    }
                                }
                                for (int i =0; i<main.ProtectionGroupBox1.Controls.Count; i++)
                                {
                                    if (main.ProtectionGroupBox1.Controls[i] is ComboBox)
                                    {
                                        if (((ComboBox)main.ProtectionGroupBox1.Controls[i]).Tag==null)
                                            ((ComboBox)main.ProtectionGroupBox1.Controls[i]).Items.Add(NameTextBox.Text);
                                    }
                                }
                            }
                      }
                        break;
                    case 3:
                        {
                            if (app != "3")
                            {
                                FiratApp main = this.Owner as FiratApp;
                                controller.AddVocab(NameTextBox.Text, "Allergies", "Allergy");
                                main.allergies = controller.GetVocabulary("Allergies", "Allergy");
                                for (int i = 0; i < main.AllergiesGroupBox.Controls.Count; i++)
                                {
                                    if (main.AllergiesGroupBox.Controls[i] is ComboBox)
                                    {
                                        ((ComboBox)main.AllergiesGroupBox.Controls[i]).Items.Add(NameTextBox.Text);
                                    }
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            if (app == "3")
                            {
                                controller.AddVocab(NameTextBox.Text, "Diagnosis", "Name");
                            }
                            else
                            {
                                FiratApp main = this.Owner as FiratApp;
                                controller.AddVocab(NameTextBox.Text, "Diagnosis", "Name");
                                main.diag = controller.GetVocabulary("Diagnosis", "Name");
                                for (int i = 0; i < main.DiagnosisGroupBox.Controls.Count; i++)
                                {
                                    if (main.DiagnosisGroupBox.Controls[i] is ComboBox)
                                    {
                                        ((ComboBox)main.DiagnosisGroupBox.Controls[i]).Items.Add(NameTextBox.Text);
                                    }
                                }
                                for (int i = 0; i < main.DifDiagnosisGroupBox.Controls.Count; i++)
                                {
                                    if (main.DifDiagnosisGroupBox.Controls[i] is ComboBox)
                                    {
                                        ((ComboBox)main.DifDiagnosisGroupBox.Controls[i]).Items.Add(NameTextBox.Text);
                                    }
                                }
                            }                                                        
                        }break;
                }
                this.Close();
            }
        }
    }
}
