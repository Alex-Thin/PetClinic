using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    class Check
    {
        public string FindAge(DateTime date)
        {
            int age;
            int months;
            if ((date.Month < DateTime.Now.Month) || ((date.Month == DateTime.Now.Month) && (date.Day > DateTime.Now.Day)))
            {
                age = DateTime.Now.Year - date.Year;
            }
            else age = DateTime.Now.Year - date.Year-1;
            int mb = date.Month;
            int mn = DateTime.Now.Month;
            int db = date.Day;
            int dn = DateTime.Now.Day;
            if (mb == mn)
                months = 0;
            else
            {
                if (mb > mn)
                    if (db > dn)
                        months = 12 - mb + mn - 1;
                    else months = 12 - mb + mn;
                else
                { if (db > dn)
                        months = mn - mb - 1;
                    else months = mn - mb;
                        }

            }
            string result = age.ToString() + " л. "+months.ToString()+" м.";
            return result;

        }
        public bool CheckDate(string date)
        {
            DateTime result;
            if (DateTime.TryParse(date, out result))
            {
                if (result > DateTime.Now)
                    return false;
            }
            else return false;
            return true;
        }
        public bool CheckSearchPhone(string str)
        {
            bool check=true;
            for (int i=0; i<str.Length; i++)
            {
                if ((!Char.IsDigit(str[i]))&&(str[i]!='-'))
                {
                    check = false;
                    break;
                }                   
            }
            return check;
        }
        public bool CheckAddress(string address)
        {
            bool check = false;
            if (address == "") return check;
            for (int i=0; i<address.Length; i++)
            {
                if (address[i] != ' ')
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public string CorrectPhone(string phone)
        {
            string result = "8";
            phone = phone.Remove(0, 4);
            phone = phone.Remove(3, 2);
            phone = phone.Remove(6, 1);
            result += phone;
            return result;
        }
        public bool CheckName(string name)
        {
            if (name == "")
                return false;
            else return true;
        }
        public string CorrectName (string name)
        {
            char letter= Char.ToUpper(name[0]);
            string result=letter.ToString();
            for (int i=1; i<name.Length; i++)
            {
                if (Char.IsUpper(name[i]))
                {
                    result += Char.ToLower(name[i]);
                }
                else result += name[i];
            }
            return result;
        }
        public bool CheckSurname(string surname)
        {
            bool check=false;
            if (surname == "") return check;
            for (int i =0; i<surname.Length; i++)
            {
                if (surname[i] != '-')
                {
                    check = true;
                    break;
                }
            }
            return check;

        }
        public string CorrectSurnameName(string name)
        {
            string result="";
            while ((name[0]=='-')&&(name.Length>0))
            {
                name= name.Remove(0, 1);
            }
            int lenght = name.Length;
            while ((name[name.Length-1]=='-')&&(name.Length>0))
            {
                name = name.Remove(lenght - 1, 1);
                lenght -= 1;
            }
            char letter;
            for (int i = 0; i < name.Length; i++)
            {
                if (i==0)
                {
                        letter = Char.ToUpper(name[i]);
                        result += letter;
                }else
                {
                    if (name[i] == '-')
                    {
                        if (name[i + 1] != '-')
                        {
                            letter = Char.ToUpper(name[i + 1]);
                            result += "-" + letter;
                            i++;
                        }
                    }
                    else
                    {
                        letter = Char.ToLower(name[i]);
                        result += letter;
                    }
                }

            }
            return result;
        }

    }
}
