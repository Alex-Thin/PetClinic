using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Allergies
    {
        public int AllergyCode, AppCode;
        public Allergies(int allcode, int appcode)
        {
            AllergyCode = allcode;
            AppCode = appcode;
        }
    }
}
