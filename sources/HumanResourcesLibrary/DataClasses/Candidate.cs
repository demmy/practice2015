﻿using System;
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

    public class Candidate : UniqueItem, IDeepCopy<Candidate>, IEquatable<Candidate>
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
        public ContactWithCandidate LastContact 
        {
            get
            {
                var lastContact =
                    from contact in ContactsList
                    orderby contact.Date descending
                    select contact;
                return lastContact.FirstOrDefault();

            }
        }

        public Candidate()
        {
            Phones = new List<Phone>();
            ContactsList = new List<ContactWithCandidate>();
            SocialNetworksList = new List<SocialNetwork>();
        }

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
            copy.Photo = null;
            if (this.Photo != null)
            {
                copy.Photo = new byte[this.Photo.Length];
                Array.Copy(this.Photo, copy.Photo, this.Photo.Length);
            }
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

        public bool Equals(Candidate other)
        {
            bool result = true;

            if (!this.ContactsList.SequenceEqual(other.ContactsList))
                result = false;
            else if (!this.Phones.SequenceEqual(other.Phones))
                result = false;
            else if (!this.SocialNetworksList.SequenceEqual(other.SocialNetworksList))
                result = false;
            else if (this.LastName != other.LastName)
                result = false;
            else if (this.MiddleName != other.MiddleName)
                result = false;
            else if (this.FirstName != other.FirstName)
                result = false;
            else if (this.DOB != other.DOB)
                result = false;
            else if (this.Gender != other.Gender)
                result = false;
            else if (this.Country != other.Country)
                result = false;
            else if (this.City != other.City)
                result = false;
            else if (this.RelocationAgreement != other.RelocationAgreement)
                result = false;
            else if (this.Email != other.Email)
                result = false;
            else if (this.Skype != other.Skype)
                result = false;
            else if (this.SiteURL != other.SiteURL)
                result = false;
            else if ((this.Photo == null && other.Photo != null) || (this.Photo != null && other.Photo == null))
                result = false;
            else if (this.Photo != null && !this.Photo.SequenceEqual(other.Photo))
                result = false;

            return result;        
        }
    }
}
