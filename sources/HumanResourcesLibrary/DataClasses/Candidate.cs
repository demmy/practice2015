using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public enum Gender
    { 
        Male,
        Female
    }

    public class Candidate : UniqueItem, IDeepCopy<Candidate>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public List<Phone> Phones { get; set; }


        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public Candidate CreateDeepCopy()
        {
            Candidate copy = new Candidate();
            copy.LastName = this.LastName;
            copy.FirstName = this.FirstName;
            copy.Phones = this.Phones.ConvertAll(CopyPhone);
            return copy;
        }

        private static Phone CopyPhone(Phone p)
        {
            return p.CreateDeepCopy();
        }
    }
}
