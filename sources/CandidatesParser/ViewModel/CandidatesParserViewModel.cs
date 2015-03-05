using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactParserLibrary.ContactsLibrary;
using ContactParserLibrary.ReadWriteLibrary;

namespace CandidatesParser
{
    class CandidatesParserViewModel    // Like Singelton
    {
        //////////////////////////////      SINGELTON       //////////////////////////////////////
        private static CandidatesParserViewModel instance = null;
        // Конструкторы и оператор присваивания недоступны клиентам
        private CandidatesParserViewModel() { }
        
        public static CandidatesParserViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidatesParserViewModel();
                }
                return instance;
            }
        }

        //this manager is speak with ContactsManager object
        ContactsManager myContactsManager = new ContactsManager();
        public List<KeyValuePair<string, bool>> GetSkypes()
        {
            return myContactsManager.GetSkypes();
        }
        public List<KeyValuePair<string, bool>> GetEmails()
        {
            return myContactsManager.GetEmails();
        }
        public List<KeyValuePair<string, bool>> GetPhoneNumbers()
        {
            return myContactsManager.GetPhoneNumbers();
        }
        public List<KeyValuePair<string, bool>> GetWebSites()
        {
            return myContactsManager.GetWebSites();
        }
        //set true for selected contact
        public void SelectSkype(int index)
        {
            myContactsManager.SelectSkype(index);
        }
        public void SelectEmail(int index)
        {
            myContactsManager.SelectEmail(index);
        }
        public void SelectWebSite(int index)
        {
            myContactsManager.SelectWebSite(index);
        }
        public void SelectPhoneNumbers(int[] index)
        {
            myContactsManager.SelectPhoneNumbers(index);
        }
        public void Read(string path)
        {
            myContactsManager.Read(path);
        }
    }
}
