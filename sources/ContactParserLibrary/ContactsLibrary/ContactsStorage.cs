using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactParserLibrary.ContactsLibrary
{
    public class ContactsStorage
    {
        private List<Contact> contacts = new List<Contact>();

        public ContactsStorage()
        {

        }
        public ContactsStorage(Contact newContact)
        {
            contacts.Add(newContact);
        }
        public ContactsStorage(List<Contact> newContacts)
        {
            contacts = newContacts;
        }
        
        public void SetContact(Contact newContact)
        {
            contacts.Add(newContact);
        }
        public List<Contact> GetContactsByType(ContactType type)
        {
            return contacts.FindAll(x => x.Type == type);
        }
    }
}
