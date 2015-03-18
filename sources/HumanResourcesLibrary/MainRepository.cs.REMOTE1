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
            vacancies.Add(new Vacancy("Super Vacancy 1", new Project(1, "ISD"), new City(1, "Dnipro"), 
                            Status.Closed, new ResponsiblePerson(1, "She"), new DateTime(2015,1,22), new DateTime(2015,1,22),  
                               HumanResourcesLibrary.DataClasses.TypeEmployment.Internsip, LevelEnglish.Beginner, "dsfdsg", "ldsfmckjdsn"));
            vacancies.Add(new Vacancy("Super Vacancy 2", new Project(2, "DataArt"), new City(2, "Lviv"),
                           Status.Closed, new ResponsiblePerson(2, "They"), new DateTime(2015, 1, 22), new DateTime(2015, 1, 22),
                              HumanResourcesLibrary.DataClasses.TypeEmployment.Practice, LevelEnglish.Intermediate, "dsfdsg", "ldsfmckjdsn"));
            vacancies.Add(new Vacancy("Super Vacancy 3", new Project(1, "ISD"), new City(1, "Dnipro"),
                           Status.Open, new ResponsiblePerson(1, "She"), new DateTime(2015, 1, 22), new DateTime(2015, 1, 22),
                              HumanResourcesLibrary.DataClasses.TypeEmployment.Internsip, LevelEnglish.Beginner, "dsfdsg", "ldsfmckjdsn"));
            vacancies.Add(new Vacancy("Super Vacancy 4", new Project(3, "SiteCore"), new City(3, "Kyiv"),
                           Status.Closed, new ResponsiblePerson(3, "He"), new DateTime(2015, 1, 22), new DateTime(2015, 1, 22),
                              HumanResourcesLibrary.DataClasses.TypeEmployment.FullEmployment, LevelEnglish.Proficiency, "dsfdsg", "ldsfmckjdsn"));
            vacancies.Add(new Vacancy("Super Vacancy 5", new Project(1, "ISD"), new City(1, "Dnipro"),
                           Status.Open, new ResponsiblePerson(2, "They"), new DateTime(2015, 1, 22), new DateTime(2015, 1, 22),
                              HumanResourcesLibrary.DataClasses.TypeEmployment.Internsip, LevelEnglish.Beginner, "dsfdsg", "ldsfmckjdsn"));
            vacancies.Add(new Vacancy("Super Vacancy 6", new Project(3, "SiteCore"), new City(3, "Kyiv"),
                           Status.Closed, new ResponsiblePerson(1, "She"), new DateTime(2015, 1, 22), new DateTime(2015, 1, 22),
                              HumanResourcesLibrary.DataClasses.TypeEmployment.PartTime, LevelEnglish.Pre_Intermediate, "dsfdsg", "ldsfmckjdsn"));
            candidates.Add(new Candidate() { LastName = "Ivanov", FirstName = "Ivan", Phones = new List<Phone>() });
            candidates.Add(new Candidate()
            {
                FirstName = "Konstantin",
                MiddleName = "Veniaminovich",
                LastName = "Prihodko",
                DOB = new DateTime(1994, 04, 24),
                Gender = Gender.Male,
                Country = "Ukraine",
                City = "Kharkov",
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
                        Date = new DateTime(2015, 02, 15, 17, 00, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(2015, 02, 17, 12, 05, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "all"
                    }

                }
            });
            candidates.Add(new Candidate()
            {
                FirstName = "Konstancia",
                LastName = "Simicolon",
                DOB = new DateTime(1985, 12, 19),
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
                        Date = new DateTime(2015, 01, 24, 13, 30, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(2015, 02, 17, 19, 25, 00), 
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
                DOB = new DateTime(1974, 12, 15),
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
                        Date = new DateTime(2015, 01, 24, 13, 30, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(2015, 02, 17, 19, 25, 00), 
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
                DOB = new DateTime(1965, 07, 02),
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
                        Date = new DateTime(2012, 01, 24, 13, 30, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(2014, 02, 17, 19, 25, 00), 
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
                DOB = new DateTime(1986, 11, 20),
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
                        Date = new DateTime(2014, 01, 24, 16, 50, 00), 
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
                DOB = new DateTime(1965, 07, 02),
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
                        Date = new DateTime(2013, 02, 24, 13, 30, 00), 
                        Type = ContactTypes.Meet,
                        Comment = "its ok"
                    },
                    new ContactWithCandidate() 
                    { 
                        Date = new DateTime(2014, 02, 17, 19, 25, 00), 
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
