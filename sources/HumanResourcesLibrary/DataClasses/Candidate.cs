using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public enum Gender
    { 
        Male,
        Female
    }

    public class Candidate : UniqueItem, IDeepCopy<Candidate>
    {
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public bool RelocationAgreement { get; set; }
        public byte [] Photo { get; set; } 
        public List<Phone> Phones { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string SiteURL { get; set; }
        public EnglishLevel EnglishLevel { get; set; }
        public List<ContactWithCandidate> ContactsList { get; set; }
        public List<SocialNetwork> SocialNetworksList { get; set; }
        public ContactWithCandidate LastContact { get ; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public Candidate CreateDeepCopy()
        {
            Candidate copy = new Candidate();
            copy.LastName = this.LastName;
            copy.MiddleName = this.MiddleName;
            copy.FirstName = this.FirstName;
            copy.DOB = this.DOB;
            copy.Gender = this.Gender;
            copy.Country = this.Country;
            copy.City = this.City;
            copy.RelocationAgreement = this.RelocationAgreement;
            this.Photo.CopyTo(copy.Photo, 0);
            copy.Email = this.Email;
            copy.Skype = this.Skype;
            copy.SiteURL = this.SiteURL;
            copy.EnglishLevel = this.EnglishLevel;
            copy.Phones = this.Phones.ConvertAll(CopyPhone);
            copy.ContactsList = this.ContactsList.ConvertAll(CopyContact);
            copy.SocialNetworksList = this.SocialNetworksList.ConvertAll(CopySocialNetwork);
            return copy;
        }

        private static Phone CopyPhone(Phone p)
        {
            return p.CreateDeepCopy();
        }

        private static ContactWithCandidate CopyContact(ContactWithCandidate contact)
        {
            return contact.CreateDeepCopy();
        }

        private static SocialNetwork CopySocialNetwork(SocialNetwork socialNetwork)
        {
            return socialNetwork.CreateDeepCopy();
        }
    }
}
