using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clinic
{
    public class Treatment
    {
        public int type, medicine, appoinment;
        public string amount, comment, TypeName, MedicineName;
        public Treatment(int Type, int Med, int App, string Dose, string Comm, SqlConnection SQLC)
        {
            Controller controller = new Controller(SQLC);
            type = Type;
            TypeName = controller.GetNameOfVocabularity(type, "TreatmentType", "TypeOfTreatment", "CodeOfType");
            medicine = Med;
            if (medicine != -1)
                MedicineName = controller.GetNameOfVocabularity(medicine, "Medicine", "Name", "CodeOfMedicine");
            else MedicineName = "";
            appoinment = App;
            amount = Dose;
            comment = Comm;
        }
    }
}
