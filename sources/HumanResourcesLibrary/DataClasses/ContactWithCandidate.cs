using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public enum ContactTypes
    { 
        Meet,
        Call
    }

    public class ContactWithCandidate : IDeepCopy<ContactWithCandidate>, IEquatable<ContactWithCandidate>
    {
        public ContactWithCandidate CreateDeepCopy()
        {
            ContactWithCandidate copy = new ContactWithCandidate();
            copy.Date = this.Date;
            copy.Type = this.Type;
            copy.Comment = this.Comment;
            return copy;
        }

        public ContactTypes Type{get; set;}
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public ContactWithCandidate() { }

        public bool Equals(ContactWithCandidate other)
        {
            return this.Type == other.Type && this.Date == other.Date && this.Comment == other.Comment;
        }
    }
}
