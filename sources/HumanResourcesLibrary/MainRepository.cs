using HumanResourcesLibrary.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary
{
    internal class MainRepository : IMainRepository
    {
        private List<Vacancy> vacancies = new List<Vacancy>();
        private List<Candidate> candidates = new List<Candidate>();

        public MainRepository()
        {
            vacancies.Add(new Vacancy() { Title = "Super Vacancy 1" });
            candidates.Add(new Candidate() { LastName = "Ivanov", FirstName = "Ivan", Phones = new List<Phone>() });
            candidates.Add(new Candidate()
            {
                FirstName = "Konstantin",
                MiddleName = "Veniaminovich",
                LastName = "Prihodko",
                DOB = new DateTime(24, 04, 1994),
                Gender = Gender.Male,
                Country = "Ukraine",
                City = "Lviv",
                RelocationAgreement = true,
                Phones = new List<Phone>() 
                { 
                    new Phone() { PhoneNumber = "0931594895", Type = PhoneType.Mobile },
                    new Phone() { PhoneNumber = "05685952215", Type = PhoneType.Mobile },
                    new Phone() { PhoneNumber = "7495619", Type = PhoneType.Home }
                },
                Skype = "Kostya94",
                EnglishLevel = EnglishLevel.Proficiency,
                SocialNetworksList = new List<SocialNetwork>()
                {
                    new SocialNetwork() {Type = SocialNetworkType.VKontakte, Link =" http://vk.com/id236999968 "}
                },
                ContactsList = new List<ContactWithCandidate>()
                {
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(15, 02, 2015, 17, 00, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(17, 02, 2015, 12, 05, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "all"
                    }

                }
              });
            candidates.Add(new Candidate()
            {
                FirstName = "Konstancia",
                LastName = "Simicolon",
                DOB = new DateTime(15, 12, 1985),
                Gender = Gender.Female,
                Country = "Great Britain",
                City = "London",
                RelocationAgreement = false,
                Phones = new List<Phone>() 
                { 
                    new Phone() { PhoneNumber = "7854944822", Type = PhoneType.Mobile },

                },
                Skype = "SweetFlower",
                EnglishLevel = EnglishLevel.Proficiency,
                SocialNetworksList = new List<SocialNetwork>()
                {
                    new SocialNetwork() {Type = SocialNetworkType.Facebook, Link ="https://www.facebook.com/misx.rosered"}
                },
                ContactsList = new List<ContactWithCandidate>()
                {
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(24, 01, 2015, 13, 30, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(17, 02, 2015, 19, 25, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "all"
                    }

                }
            });
            candidates.Add(new Candidate()
            {
                FirstName = "Лешка",
                MiddleName = "Алексеевич",
                LastName = "Гидропоник",
                DOB = new DateTime(12, 12, 1974),
                Gender = Gender.Male,
                Country = "Россия",
                City = "Москва",
                RelocationAgreement = false,
                Phones = new List<Phone>() 
                { 
                    new Phone() { PhoneNumber = "2124588646", Type = PhoneType.Mobile },
                    new Phone() { PhoneNumber = "7854944822", Type = PhoneType.Mobile },

                },
                Skype = "SweetLesha",
                EnglishLevel = EnglishLevel.Proficiency,
                SocialNetworksList = new List<SocialNetwork>()
                {
                    new SocialNetwork() {Type = SocialNetworkType.Facebook, Link ="https://www.facebook.com/misx.rosered"}
                },
                ContactsList = new List<ContactWithCandidate>()
                {
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(24, 01, 2015, 13, 30, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(17, 02, 2015, 19, 25, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "all"
                    }

                }
            });
            candidates.Add(new Candidate()
            {
                FirstName = "Машка",
                MiddleName = "Петровна",
                LastName = "Гупергун",
                DOB = new DateTime(02, 07, 1965),
                Gender = Gender.Female,
                Country = "Россия",
                City = "Волгоград",
                RelocationAgreement = false,
                Phones = new List<Phone>() 
                { 
                    new Phone() { PhoneNumber = "0358559665", Type = PhoneType.Mobile },
                    new Phone() { PhoneNumber = "5885644822", Type = PhoneType.Mobile },

                },
                Skype = "Honey",
                EnglishLevel = EnglishLevel.Proficiency,
                SocialNetworksList = new List<SocialNetwork>()
                {
                    new SocialNetwork() {Type = SocialNetworkType.Facebook, Link ="https://www.facebook.com/sen.tokugawa.37"}
                },
                ContactsList = new List<ContactWithCandidate>()
                {
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(24, 01, 2012, 13, 30, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(17, 02, 2014, 19, 25, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "all"
                    }

                }
            });
            candidates.Add(new Candidate()
            {
                FirstName = "Валентин",
                MiddleName = "Гуоргиевич",
                LastName = "Набойко",
                DOB = new DateTime(30, 11, 1986),
                Gender = Gender.Female,
                Country = "Белоруссия",
                City = "Смоленск",
                RelocationAgreement = true,
                Phones = new List<Phone>() 
                { 
                    new Phone() { PhoneNumber = "2124588645", Type = PhoneType.Mobile },
                   

                },
                Skype = "Valysha",
                EnglishLevel = EnglishLevel.Proficiency,
                SocialNetworksList = new List<SocialNetwork>()
                {
                    new SocialNetwork() {Type = SocialNetworkType.Facebook, Link ="https://www.facebook.com/misx.rosered"}
                },
                ContactsList = new List<ContactWithCandidate>()
                {
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(24, 01, 2014, 16, 50, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },

                }
            });
            candidates.Add(new Candidate()
            {
                FirstName = "Августина",
                MiddleName = "Вячеславовна",
                LastName = "Красношапкова",
                DOB = new DateTime(02, 07, 1965),
                Gender = Gender.Male,
                Country = "Россия",
                City = "Москва",
                RelocationAgreement = false,
                Phones = new List<Phone>() 
                { 
                    new Phone() { PhoneNumber = "751845", Type = PhoneType.Home },
                    new Phone() { PhoneNumber = "784445822", Type = PhoneType.Mobile },

                },
                Skype = "SweetAugust",
                EnglishLevel = EnglishLevel.Proficiency,
                ContactsList = new List<ContactWithCandidate>()
                {
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(24, 02, 2013, 13, 30, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(17, 02, 2014, 19, 25, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "all"
                    }

                }
            });
        }

        /// <summary>
        /// Use this method to get list of all vacancies
        /// </summary>
        /// <returns>list of vacancies</returns>
        public List<Vacancy> GetAllVacancies()
        {
            return vacancies.ConvertAll((v) => { return v.CreateDeepCopy(); });
        }

        /// <summary>
        /// Use this method to get list of all candidates
        /// </summary>
        /// <returns>list of candidates</returns>
        public List<Candidate> GetAllCandidates()
        {
            return candidates.ConvertAll((v) => { return v.CreateDeepCopy(); });
        }
        

        /// <summary>
        /// Use this method to get list of candidates which correspond to given criteria
        /// </summary>
        /// <returns>list of candidates</returns>
        public List<Candidate> GetCandidates(/* here search criteria go */)
        {
            return candidates.FindAll((c) => { return true; /* here search criteria go */ }).ConvertAll((c) => { return c.CreateDeepCopy(); });
        }

        /// <summary>
        /// Use this method to update the vacancy information, or to add newly created vacancy
        /// </summary>
        /// <param name="v"></param>
        public void SaveVacancy(Vacancy v)
        {
            int index = vacancies.FindIndex((vac) => { return v.Id == vac.Id; });
            if (index > -1)
            {
                vacancies[index] = v;
            }
            else
            {
                vacancies.Add(v);
            }
        }

        /// <summary>
        /// Use this method to update the candidate information, or to add newly created candidate
        /// </summary>
        /// <param name="c"></param>
        public void SaveCandidate(Candidate c)
        {
            int index = candidates.FindIndex((cand) => { return c.Id == cand.Id; });
            if (index > -1)
            {
                candidates[index] = c;
            }
            else
            {
                candidates.Add(c);
            }
        }
    }
}
