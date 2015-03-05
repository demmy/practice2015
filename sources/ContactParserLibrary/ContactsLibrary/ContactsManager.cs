using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactParserLibrary.ReadWriteLibrary;

namespace ContactParserLibrary.ContactsLibrary
{
    public class ContactsManager
    {
        IReader reader;
        ContactsStorage storage;
        public void Read(string path)
        {
            if (path[path.Length - 1] == 't' && path[path.Length - 2] == 'x' && path[path.Length - 3] == 't')
            {
                ReadTxt(path);
            }
            reader.InitContactsStorage(out storage);
        }
        private void ReadTxt(string path)
        {
            reader = new ReaderTxt(path);
        }
        private void ReadXml(string path)
        {
            reader = new ReaderXML();

        }
        public List<KeyValuePair<string, bool>> GetSkypes()
        {
            List<KeyValuePair<string, bool>> skypes = new List<KeyValuePair<string, bool>>();

            foreach (var item in (storage.GetContactsByType(ContactType.Skype)))
            {
                skypes.Add(new KeyValuePair<string, bool>(item.Value, item.IsChosen));
            }
            return skypes;
        }
        public List<KeyValuePair<string, bool>> GetEmails()
        {
            List<KeyValuePair<string, bool>> emails = new List<KeyValuePair<string, bool>>();

            foreach (var item in (storage.GetContactsByType(ContactType.Email)))
            {
                emails.Add(new KeyValuePair<string, bool>(item.Value, item.IsChosen));
            }
            return emails;
        }
        public List<KeyValuePair<string, bool>> GetPhoneNumbers()
        {
            List<KeyValuePair<string, bool>> phones = new List<KeyValuePair<string, bool>>();

            foreach (var item in (storage.GetContactsByType(ContactType.PhoneNumber)))
            {
                phones.Add(new KeyValuePair<string, bool>(item.Value, item.IsChosen));
            }
            return phones;
        }
        public List<KeyValuePair<string, bool>> GetWebSites()
        {
            List<KeyValuePair<string, bool>> webSites = new List<KeyValuePair<string, bool>>();

            foreach (var item in (storage.GetContactsByType(ContactType.WebSite)))
            {
                webSites.Add(new KeyValuePair<string, bool>(item.Value, item.IsChosen));
            }
            return webSites;
        }
        public void SelectSkype(int index)
        {
            storage.GetContactsByType(ContactType.Skype)[index].IsChosen = true;
            //set false for each unselected Skypes
            ResetUnselectedOtherContacts(ContactType.Skype, index);
        }
        public void SelectEmail(int index)
        {
            storage.GetContactsByType(ContactType.Email)[index].IsChosen = true;
            //set false for each unselected e-mails
            ResetUnselectedOtherContacts(ContactType.Email, index);
        }
        public void SelectWebSite(int index)
        {
            storage.GetContactsByType(ContactType.WebSite)[index].IsChosen = true;
            //set false for each unselected web-site
            ResetUnselectedOtherContacts(ContactType.WebSite, index);
        }
        public void SelectPhoneNumbers(int[] indexArray)
        {
            foreach (int index in indexArray)
            {
                storage.GetContactsByType(ContactType.PhoneNumber)[index].IsChosen = true;
            }
            //set false for each unselected phonenumber
            ResetUnselectedPhoneNumbers(indexArray);
        }
        private void ResetUnselectedPhoneNumbers(int[] indexArray)
        {
            for (int i = 0, j = 0; i < storage.GetContactsByType(ContactType.PhoneNumber).Count; i++)
            {
                if (i == indexArray[j])
                {
                    continue;
                    j++;
                }
                storage.GetContactsByType(ContactType.PhoneNumber)[indexArray[j]].IsChosen = false;
            }
        }
        private void ResetUnselectedOtherContacts(ContactType contactType, int index)
        {
            for (int i = 0; i < storage.GetContactsByType(contactType).Count; i++)
            {
                if (i == index)
                {
                    continue;
                }
                storage.GetContactsByType(contactType)[index].IsChosen = false;
            }
        }
    }
}
