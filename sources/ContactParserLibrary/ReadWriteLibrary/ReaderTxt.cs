using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ContactParserLibrary.ContactsLibrary;

namespace ContactParserLibrary.ReadWriteLibrary
{
    public class ReaderTxt : IReader
    {
        private StreamReader myReader;
        private string path;
        private bool FindString(string str, out string ss)
        {
            if (myReader != null)
                myReader.Close();
            myReader = new StreamReader(path);
            for (string temp = ss = ""; temp != str && !(temp.Contains(str)); )// считываем , пока не найдем строку, или не дойдем до конца файла
            {
                temp = myReader.ReadLine();
                ss = temp;
                if (temp == null)
                    return false;
            }
            return true;
        }
        private bool IsMask(string str)
        {
            return (str.Contains(Masks.EMail)
                || str.Contains(Masks.Site)
                || str.Contains(Masks.Skype)
                || str.Contains(Masks.Telephone));

        }
        private void FindInComplexString(string str, ref List<string> templist)
        {
            string[] words;
            words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != " " && (!IsMask(words[i])))
                    templist.Add(words[i]);
            }

        }
        private List<string> GetContactsList(string s)
        {
            List<string> templist = new List<string>();
            string st;
            if (FindString(s, out st))
            {
                string tempstring = st;
                do
                {
                    FindInComplexString(tempstring, ref templist);
                    tempstring = myReader.ReadLine();
                } while (tempstring != null && (!IsMask(tempstring)));
                return templist;
            }
            else
                return null;
        }
        public List<string> GetEmails()
        {
            return GetContactsList(Masks.EMail);
        }
        public List<string> GetPhoneNumbers()
        {
            return GetContactsList(Masks.Telephone);
        }
        public List<string> GetSkypes()
        {
            return GetContactsList(Masks.Skype);
        }
        public List<string> GetWebSites()
        {
            return GetContactsList(Masks.Site);
        }
        public ReaderTxt(string path)
        {
            this.path = path;
            if (myReader != null)
                myReader.Close();
            myReader = new StreamReader(path);//генерирует System.IO.FileNotFoundException если не может открыть файл
        }
        public void SetPath(string path)
        {
            this.path = path;
            if (myReader != null)
                myReader.Close();
            //генерирует System.IO.FileNotFoundException если не может открыть файл
            myReader = new StreamReader(path);
        }
        public void InitContactsStorage(out ContactsStorage storage)
        {
            storage = new ContactsStorage();

            Contact newContact;
            foreach (var item in this.GetSkypes())
            {
                newContact = new Contact();
                newContact.IsChosen = false;
                newContact.Type = ContactType.Skype;
                newContact.Value = item;
                storage.SetContact(newContact);
            }
            foreach (var item in this.GetEmails())
            {
                newContact = new Contact();
                newContact.IsChosen = false;
                newContact.Type = ContactType.Email;
                newContact.Value = item;
                storage.SetContact(newContact);
            }
            foreach (var item in this.GetPhoneNumbers())
            {
                newContact = new Contact();
                newContact.IsChosen = false;
                newContact.Type = ContactType.PhoneNumber;
                newContact.Value = item;
                storage.SetContact(newContact);
            }
            foreach (var item in this.GetWebSites())
            {
                newContact = new Contact();
                newContact.IsChosen = false;
                newContact.Type = ContactType.WebSite;
                newContact.Value = item;
                storage.SetContact(newContact);
            }

        }
        ~ReaderTxt()
        {
            if (myReader != null)
                myReader.Close();
        }
    }
}
