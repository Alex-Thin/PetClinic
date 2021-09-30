using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class TakingMed
    {
        public int med, type;
        public string beg, end;
        public string dose;
        public TakingMed(int Med, string Beg, string End, string Dose)
        {
            med = Med;
            beg = Beg;
            end = End;
            dose = Dose;
        }
        public TakingMed(string Date, int Type, int Med)
        {
            med = Med;
            beg = Date;
            type = Type;
        }

    }
}
