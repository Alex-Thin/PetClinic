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
    public partial class FiratApp : Form
    {
        int x1, y1, x2, y2, difdiagloc, comploc, anamloc, x3, y3, x33, y33, y4, pos=0, DiagCount=1, DifDiagCount=1, medloc, protloc, ProtectionY, ProtectionCount=1, allergloc, AllergiesY, ProcedureY, ProcCount=1;

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

        private void AllergiesButton_Click(object sender, EventArgs e)
        {
            ComboBox acb = new ComboBox();
            acb.Location= new Point(10, AllergiesY);
            acb.Size = new Size(300, 33);
            AllergiesGroupBox.Controls.Add(acb);
            AllergiesButton.Location = new Point(330, AllergiesY - 2);
            AllergiesY += 35;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            int a = this.AutoScrollPosition.Y;
            comploc -= pos;
            comploc += a;
            difdiagloc -= pos;
            difdiagloc += a;
            anamloc -= pos;
            anamloc += a;
            medloc -= pos;
            medloc += a;
            protloc -= pos;
            protloc += a;
            allergloc -= pos;
            allergloc += a;
            pos = a;
        }

        private void ProtButton_Click(object sender, EventArgs e)
        {
            if (ProtectionCount == 2)
            {
                MessageBox.Show("Невозможно добавить более 2 записей об обработке");
            }
            else
            {
                Label ptl = new Label();
                ptl.Location = new Point(10, ProtectionY);
                ptl.Text = "Тип обработки:";
                ptl.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                ProtectionGroupBox1.Controls.Add(ptl);

                ComboBox ptcb = new ComboBox();
                ptcb.Location = new Point(110, ProtectionY - 5);
                ptcb.Size = new Size(380, 33);
                ptcb.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                ProtectionGroupBox1.Controls.Add(ptcb);

                Label pl = new Label();
                pl.Location = new Point(10, ProtectionY + 30);
                pl.Text = "Препарат";
                pl.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                ProtectionGroupBox1.Controls.Add(pl);

                ComboBox mcb = new ComboBox();
                mcb.Size = new Size(380, 33);
                mcb.Location = new Point(110, ProtectionY + 25);
                mcb.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                ProtectionGroupBox1.Controls.Add(mcb);

                Label dl = new Label();
                dl.Location = new Point(10, ProtectionY + 60);
                dl.Text = "Дата приема";
                dl.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                ProtectionGroupBox1.Controls.Add(dl);

                MaskedTextBox bmtb = new MaskedTextBox();
                bmtb.Location = new Point(155, ProtectionY + 55);
                bmtb.Mask = "00/00/0000";
                bmtb.Size = new Size(80, 33);
                bmtb.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                ProtectionGroupBox1.Controls.Add(bmtb);

                ProtButton.Location = new Point(400, ProtectionY + 70);
                ProtectionY += 100;
                ProtectionCount += 1;
                AfterProtection();
            }
        }

        private void MedButton_Click(object sender, EventArgs e)
        {
            Label med = new Label();
            med.Location = new Point(x33, y33);
            med.Text = "Препарат:";
            med.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            MedicineGroupBox.Controls.Add(med);

            ComboBox cb = new ComboBox();
            cb.Size = new Size(380, 33);
            cb.Location = new Point(x33 + 100, y33 - 5);
            cb.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            MedicineGroupBox.Controls.Add(cb);

            Label bdl = new Label();
            bdl.Location = new Point(x33, y33 + 30);
            bdl.Text = "Дата начала приема:";
            bdl.Size = new Size(138, 25);
            bdl.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            MedicineGroupBox.Controls.Add(bdl);

            MaskedTextBox bmtb = new MaskedTextBox();
            bmtb.Location = new Point(x33+145, y33 + 25);
            bmtb.Mask = "00/00/0000";
            bmtb.Size = new Size(80, 33);
            bmtb.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            MedicineGroupBox.Controls.Add(bmtb);

            Label el = new Label();
            el.Location = new Point(x33+230 , y33 + 30);
            el.Size = new Size(160, 20);
            el.Text = "Дата окончания приема:";
            el.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            MedicineGroupBox.Controls.Add(el);

            MaskedTextBox emtb = new MaskedTextBox();
            emtb.Location = new Point(x33 + 400, y33 + 25);
            emtb.Mask = "00/00/0000";
            emtb.Size = new Size(80, 33);
            emtb.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            MedicineGroupBox.Controls.Add(emtb);

            Label dl = new Label();           
            dl.Location = new Point(x33, y33 + 60);
            dl.Text = "Дозировка:";
            dl.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            MedicineGroupBox.Controls.Add(dl);

            TextBox dtb = new TextBox();            
            dtb.Location = new Point(x33 + 100, y33 + 55);
            dtb.Size = new Size(380, 33);
            dtb.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            MedicineGroupBox.Controls.Add(dtb);
            MedButton.Location = new Point(x33 + 350, y33 + 90);
            y33 += 120;
            y4 += 40;
            AfterTakingMed();
        }

        public FiratApp(int TypeOfApp)
        {
            InitializeComponent();
            this.Size = new Size(1200, 650);
            this.Scroll += vScrollBar1_Scroll;
            Toplabel.Location = new Point(180, 10);
            DLabel1.Location = new Point(10, 35);
            DateLabel.Location = new Point(55, 35);
            NLabel2.Location = new Point(10, 50);
            NameLabel.Location = new Point(65, 50);
            OLabel3.Location = new Point(10, 65);
            OwnerLabel.Location = new Point(80, 65);
            PLabel4.Location = new Point(10, 80);
            PhoneLabel.Location = new Point(125, 80);

            DiagnosisGroupBox.Location = new Point(0, 100);
            DiagnosisGroupBox.Size = new Size(540, 100);
            x1 = 10;
            y1 = 30;
            ComboBox diagnosis = new ComboBox();
            diagnosis.Location = new Point(x1, y1);
            diagnosis.Size = new Size(200, 18);
            diagnosis.Font = new Font("Times New Roman", 11, FontStyle.Regular);

            AddDiagnosisButton.Size= new Size(100, 29);
            AddDiagnosisButton.Location = new Point(x1+202, y1-2);
            DiagnosisGroupBox.Controls.Add(diagnosis);
            DiagnosisGroupBox.Controls.Add(AddDiagnosisButton);


            x2 = 10;
            y2 = 30;
            ComboBox difdiagnosis = new ComboBox();
            difdiagnosis.Location = new Point(x2, y2);
            difdiagnosis.Size = new Size(200, 18);
            difdiagnosis.Font = new Font("Times New Roman", 11, FontStyle.Regular);

            DifDiagnButton.Size = new Size(100, 29);
            DifDiagnButton.Location = new Point(x2 + 202, y2 - 2);

            difdiagloc =200;
            DifDiagnosisGroupBox.Location = new Point(0, difdiagloc);
            DifDiagnosisGroupBox.Size = new Size(540, 100);
            DifDiagnosisGroupBox.Controls.Add(difdiagnosis);
            DifDiagnosisGroupBox.Controls.Add(DifDiagnButton);

            comploc = 300;
            ComplTextBox.Location = new Point(5, 30);
            ComplTextBox.Size = new Size(530, 80);
            ComplGroupBox.Location = new Point(0, comploc);
            ComplGroupBox.Size = new Size(540, 130);
            ComplGroupBox.Controls.Add(ComplTextBox);

            anamloc = 430;
            AnamnesisGroupBox.Location = new Point(0, anamloc);
            AnamnesisGroupBox.Size = new Size(540, 520);

            TypeOfFoodLabel.Location = new Point(5, 30);
            TypeOfFoodComboBox.Location = new Point(105, 22);
            FrequencyLabel.Location = new Point(5, 60);
            FrequencyTextBox.Location = new Point(305, 54);
            FoodAmountLabel.Location = new Point(5, 90);
            AmountOfFoodTextBox.Location = new Point(305, 84);
            FoodComLabel.Location = new Point(5, 120);
            FoodComTextBox.Location = new Point(5, 140);
            HeatLabel.Location = new Point(5, 225);
            HeatMaskedTextBox.Location = new Point(294, 219);
            BirthDateLabel.Location = new Point(5, 255);
            BirthDateMaskedTextBox.Location = new Point(294, 249);
            BirthAmountLlabel.Location = new Point(5, 285);
            BirthAmountTextBox.Location = new Point(305, 279);
            BirthHardLabel.Location = new Point(5, 315);
            BirthHardComboBox.Location = new Point(115, 309);
            SexContactLabel.Location = new Point(5, 345);
            SexContactComboBox.Location = new Point(295, 339);
            ReprodLabel.Location = new Point(5, 375);
            ReprodTextBox.Location = new Point(5, 395);
            ContentTypeLabel.Location = new Point(5, 480);
            ContentComboBox.Location = new Point(125, 474);

            medloc = 950;
            MedicineGroupBox.Location = new Point(0, medloc);
            MedicineGroupBox.Size = new Size(540, 150);
            this.Controls.Add(MedicineGroupBox);
            x3 = 10;
            y3 = 30;
            MedLabel.Location = new Point(x3, y3);
            TakeMedComboBox.Location = new Point(x3 + 100, y3 - 5);
            BegDateTabel.Location = new Point(x3, y3 + 30);
            BegMaskedTextBox.Location = new Point(x3 + 145, y3 + 25);
            EndDateLabel.Location = new Point(x3 + 230, y3 + 30);
            EndMaskedTextBox.Location = new Point(x3 + 400, y3 + 25);
            DoseLabel.Location = new Point(x3, y3 + 60);
            DoseTextBox.Location = new Point(x3 + 100, y3 + 55);
            MedButton.Location = new Point(x3 + 350, y3 + 90);
            y33 = y3 + 120;
            x33 = 10;

            this.Controls.Add(ProtectionGroupBox1);
            protloc = 1130;
            ProtectionGroupBox1.Location = new Point(0, protloc);
            ProtectionGroupBox1.Size = new Size(540, 150);
            ProtTypeLabel.Location = new Point(x3, y3);
            ProtTypeComboBox.Location = new Point(x3 + 100, y3 - 5);
            ProtTypeComboBox.Size= new Size(380, 33);
            ProtLabel.Location = new Point(x3, y3+30);
            ProtComboBox.Location = new Point(x3 + 100, y3 + 25);
            ProtDateLabel.Location = new Point(x3, y3 + 60);
            ProtMaskedTextBox.Location = new Point(x3 + 145, y3 + 55);
            ProtButton.Location = new Point(x3 + 390, y3 + 70);
            ProtectionY = y3 + 100;

            //АЛЛЕРГИИ
            allergloc = 1290;
            AllergiesGroupBox.Location = new Point(0, allergloc);
            AllergiesGroupBox.Size= new Size(540, 100);

            AllergieComboBox.Location = new Point(10, 30);
            AllergiesButton.Location = new Point(330, 28);
            AllergiesY += 75;
            //ОСМОТР
            ExaminationGroupBox.Location=new Point(560, 0);
            ExaminationGroupBox.Size = new Size(600, 10);

            EyesLabel.Location = new Point(5, 20);
            EyesCheckBox.Location = new Point(55, 22);
            EyesTextBox.Location = new Point(5, 40);
            EyesTextBox.Size = new Size(250, 60);

            EarsLabel.Location = new Point(5, 105);
            EarsCheckBox.Location = new Point(50, 107);
            EarsTextBox.Location = new Point(5, 125);
            EarsTextBox.Size = new Size(250, 60);

            OralLabel.Location = new Point(5, 190);
            OralCheckBox.Location = new Point(125, 192);
            OralTextBox.Location = new Point(5, 210);
            OralTextBox.Size = new Size(250, 60);

            LymphLabel.Location = new Point(5, 275);
            LymphCheckBox.Location = new Point(90, 277);
            LymphTextBox1.Location=new Point(5, 295);
            LymphTextBox1.Size = new Size(250, 60);

            BodyLabel.Location = new Point(5, 360);
            BodyCheckBox.Location = new Point(220, 362);
            BodyTextBox.Location = new Point(5, 380);
            BodyTextBox.Size = new Size(250, 60);

            HRLabel.Location = new Point(5, 445);
            HRTextBox.Location = new Point(5, 465);
            HRTextBox.Size = new Size(250, 60);
            HRValueTextBox4.Location = new Point(55, 443);
            HRValueTextBox4.Size = new Size(90, 17);

            SACLabel.Location = new Point(5, 530);
            SACTextBox.Location = new Point(5, 550);
            SACTextBox.Size = new Size(250, 60);
            SACValueextBox.Location = new Point(55, 528);
            SACValueextBox.Size = new Size(90, 17);

            BreathingLabel.Location = new Point(270, 20);
            BreathTextBox.Location = new Point(270, 40);
            BreathTextBox.Size = new Size(250,60);
            BreathValueTextBox.Location = new Point(320, 19);
            BreathValueTextBox.Size = new Size(90, 17);

            TemperatureLabel.Location = new Point(270, 105);
            TemperatureTextBox.Location = new Point(270, 125);
            TemperatureTextBox.Size = new Size(250, 60);
            TempValueTextBox.Location = new Point(370, 104);
            TempValueTextBox.Size = new Size(90, 17);

            GTLabel.Location = new Point(270, 190);
            GTCheckBox.Location = new Point(315, 192);
            GTTextBox.Location = new Point(270, 210);
            GTTextBox.Size = new Size(250, 60);

            UrinaryLabel.Location = new Point(270, 275);
            UrinaryCheckBox.Location = new Point(475, 277);
            UrinaryTextBox.Location = new Point(270, 295);
            UrinaryTextBox.Size = new Size(250, 60);

            HairLabel.Location = new Point(270, 360);
            HairCheckBox.Location = new Point(380, 362);
            HairTextBox.Location = new Point(270, 380);
            HairTextBox.Size = new Size(250, 60);


            WeightLabel.Location = new Point(270, 445);
            WeightTextBox.Location = new Point(270, 465);
            WeightTextBox.Size = new Size(250, 60);
            WeightValueTextBox.Location = new Point(330, 444);
            WeightValueTextBox.Size = new Size(90, 17);

            ExamCommentLabel.Location = new Point(270, 530);
            CommentTextBox.Location = new Point(270, 550);
            CommentTextBox.Size = new Size(250, 60);

            //РЕКОМЕНДАЦИИ
            PrescriptionGroupBox.Location = new Point(560, 640);
            PrescriptionGroupBox.Size = new Size(600, 200);
            PrescriptionTextBox.Location=new Point(5, 30);
            PrescriptionTextBox.Size = new Size(590, 160);

            //ДИНАМИКА
            if (TypeOfApp == 2)
            {
                DinamicLabel.Location = new Point(560, 845);
                DinamicComboBox.Location = new Point(650, 847);
                Toplabel.Text = "Первичный прием";
            }else
            {
                DinamicLabel.Visible = false;
                DinamicComboBox.Visible = false;
                Toplabel.Text = "Повторный прием";
            }
            //ПРОЦЕДУРЫ
            ProcedureGroupBox.Location = new Point(560, 875);
            ProcedureGroupBox.Size = new Size(600, 50);
            ProcedureButton.Location = new Point(340, 30);
            ProcedureY += 30;
        }

        private void AddDiagnosisButton_Click(object sender, EventArgs e)
        {
            if (DiagCount == 15)
                MessageBox.Show("Невозможно добавление более 15 диагнозов");
            else
            {
                if (x1 >= 211)
                {
                    x1 = 10;
                    y1 += 30;
                    AfterDiagnosis();
                }
                else
                    x1 += 202;
                ComboBox diagnosis = new ComboBox();
                diagnosis.Location = new Point(x1, y1);
                diagnosis.Size = new Size(200, 18);
                diagnosis.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                DiagnosisGroupBox.Controls.Add(diagnosis);
                AddDiagnosisButton.Location = new Point(x1 + 202, y1);
                DiagCount += 1;
            }
        }

        private void AddDifDiagnosisButton_Click(object sender, EventArgs e)
        {
            if (DifDiagCount == 10)
            {
                MessageBox.Show("Невозможно добавление более 10 дифференциальных диагнозов");
            }
            else
            {
                if (x2 > 211)
                {
                    x2 = 10;
                    y2 += 30;
                    AfterDifDiagnosis();
                }
                else
                    x2 += 202;
                ComboBox diagnosis = new ComboBox();
                diagnosis.Location = new Point(x2, y2);
                diagnosis.Size = new Size(200, 18);
                diagnosis.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                DifDiagnosisGroupBox.Controls.Add(diagnosis);
                DifDiagnButton.Location = new Point(x2 + 202, y2);
                DifDiagCount += 1;
            }
        }
        public void AfterDiagnosis()
        {
            difdiagloc += 30;
            DifDiagnosisGroupBox.Location = new Point(0, difdiagloc);
            comploc += 30;
            ComplGroupBox.Location = new Point(0, comploc);
            anamloc += 30;
            AnamnesisGroupBox.Location = new Point(0, anamloc);
            medloc += 30;
            MedicineGroupBox.Location = new Point(0, medloc);
            protloc += 30;
            ProtectionGroupBox1.Location = new Point(0, protloc);
            allergloc += 30;
            AllergiesGroupBox.Location = new Point(0, allergloc);
        }
        public void AfterTakingMed()
        {
            protloc += 120;
            ProtectionGroupBox1.Location = new Point(0, protloc);
            allergloc += 120;
            AllergiesGroupBox.Location = new Point(0, allergloc);
        }
        public void AfterDifDiagnosis()
        {
            comploc += 30;
            ComplGroupBox.Location = new Point(0, comploc);
            anamloc += 30;
            AnamnesisGroupBox.Location = new Point(0, anamloc);
            medloc += 30;
            MedicineGroupBox.Location = new Point(0, medloc);
            protloc += 30;
            ProtectionGroupBox1.Location = new Point(0, protloc);
            allergloc += 30;
            AllergiesGroupBox.Location = new Point(0, allergloc);
        }
        public void AfterProtection()
        {
            allergloc += 100;
            AllergiesGroupBox.Location = new Point(0, allergloc);
        }
    }
}
