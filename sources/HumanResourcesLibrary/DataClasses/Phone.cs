using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public class Phone : IDeepCopy<Phone>, IEquatable<Phone>
    {
        public Phone CreateDeepCopy()
        {
            Phone p = new Phone();
            p.Type = this.Type;
            p.PhoneNumber = this.PhoneNumber;
            return p;
        }

        public string PhoneNumber { get; set; }
        public PhoneType Type { get; set; }
        public Phone() { }

        public bool Equals(Phone other)
        {
            return this.Type == other.Type && this.PhoneNumber == other.PhoneNumber;
        }
    }
}
