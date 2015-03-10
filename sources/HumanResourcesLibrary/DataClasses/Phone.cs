using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public class Phone : IDeepCopy<Phone>
    {
        public Phone(string PhoneNumber, PhoneType Type)
        {
            this.PhoneNumber = PhoneNumber;
            this.Type = Type;
        }

        public Phone()
        { 
            
        }
        
        public Phone CreateDeepCopy()
        {
            Phone p = new Phone();
            p.Type = this.Type;
            p.PhoneNumber = this.PhoneNumber;
            return p;
        }

        public string PhoneNumber { get; set; }
        public PhoneType Type { get; set; }
    }
}
