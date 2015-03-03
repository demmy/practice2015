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

    public class ContactWithCandidate : IDeepCopy<ContactWithCandidate>
    {
        public ContactWithCandidate CreateDeepCopy()
        {
            throw new NotImplementedException();
        }
    }
}
