using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class ClientClass
    {
        public string Name, Lastname, Address, Email, Phone;
        public string Surname;
        public ClientClass(string name, string surname, string lastname, string address, string email, string phone)
        {
            Name = name;
            Surname = surname;
            Lastname = lastname;
            Address = address;
            Email = email;
            Phone = phone; 
        }
    }
}
