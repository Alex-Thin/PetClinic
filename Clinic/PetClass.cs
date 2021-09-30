using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class PetClass
    {
        public int  castrade, gender;
        public int owner;
        public string name, kind, breed, age;
        public DateTime dateofbirth;
        public PetClass( int Gender, int Castrade, int Owner, string Name, string Kind, string Breed, DateTime DateOfBirth, string Age)
        {
            if (Gender==0)
            gender = Gender;
            if (Castrade==0)
            castrade = Castrade;
            owner = Owner;
            name = Name;
            kind = Kind;
            breed = Breed;
            dateofbirth = DateOfBirth;
            age = Age;
        }
            
    }
}
