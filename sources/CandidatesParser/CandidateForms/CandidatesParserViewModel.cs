using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactParserLibrary.ContactsLibrary;
using ContactParserLibrary.ReadWriteLibrary;
using HumanResourcesLibrary;

namespace CandidatesParser
{
    public class CandidatesParserViewModel
    {
        public CandidatesParserViewModel() { }

        //this manager is speak with ContactsManager object
        ContactsManager contactsManager = new ContactsManager();
        IMainRepository repository = RepositoryService.Repository;

        public List<KeyValuePair<string, bool>> GetSkypes()
        {
            return contactsManager.GetSkypes();
        }
        public List<KeyValuePair<string, bool>> GetEmails()
        {
            return contactsManager.GetEmails();
        }
        public List<KeyValuePair<string, bool>> GetPhoneNumbers()
        {
            return contactsManager.GetPhoneNumbers();
        }
        public List<KeyValuePair<string, bool>> GetWebSites()
        {
            return contactsManager.GetWebSites();
        }
        public List<Contact> GetSkypeContacts()
        {
            return contactsManager.GetSkypeContacts();
        }
        public List<Contact> GetEmailContacts()
        {
            return contactsManager.GetEmailContacts();
        }
        public List<Contact> GetPhoneNumberContacts()
        {
            return contactsManager.GetPhoneNumberContacts();
        }
        public List<Contact> GetWebSiteContacts()
        {
            return contactsManager.GetWebSiteContacts();
        }
        //set true for selected contact
        public void SelectSkype(int index)
        {
            contactsManager.SelectSkype(index);
        }
        public void SelectEmail(int index)
        {
            contactsManager.SelectEmail(index);
        }
        public void SelectWebSite(int index)
        {
            contactsManager.SelectWebSite(index);
        }
        public void SelectPhoneNumbers(int[] index)
        {
            contactsManager.SelectPhoneNumbers(index);
        }
        public void Read(string path)
        {
            contactsManager.Read(path);
        }

        public List<HumanResourcesLibrary.DataClasses.Candidate> GetAllCandidates()
        {
            return repository.GetAllCandidates();
        }
    }
}
