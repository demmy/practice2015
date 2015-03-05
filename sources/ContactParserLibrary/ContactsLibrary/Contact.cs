using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactParserLibrary.ContactsLibrary
{
    public class Contact
    {
        public string Value { set; get; }
        public bool IsChosen { set; get; }
        public ContactType Type { set; get; }
    }
}
