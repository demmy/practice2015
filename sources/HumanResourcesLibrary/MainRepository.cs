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
            vacancies.Add(new Vacancy("Super Vacancy 1", new Project(1, "ISD"), new City(1, "Dnipro"), Status.Closed));
            vacancies.Add(new Vacancy("Super Vacancy 2", new Project(2, "DataArt"), new City(3, "Lviv"), Status.Open));
            vacancies.Add(new Vacancy("Super Vacancy 3", new Project(3, "SiteCore"), new City(2, "Kyiv"), Status.Open));
            vacancies.Add(new Vacancy("Super Vacancy 4", new Project(2, "DataArt"), new City(1, "Dnipro"), Status.Closed));
            vacancies.Add(new Vacancy("Super Vacancy 5", new Project(1, "ISD"), new City(1, "Dnipro"), Status.Open));
            vacancies.Add(new Vacancy("Super Vacancy 6", new Project(1, "ISD"), new City(1, "Dnipro"), Status.Closed));
            candidates.Add(new Candidate() { LastName = "Ivanov", FirstName = "Ivan", Phones = new List<Phone>() });
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
