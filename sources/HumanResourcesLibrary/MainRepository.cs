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
        }

        public List<Vacancy> GetAllVacancies()
        {
            return vacancies.ConvertAll((v) => { return v.CreateDeepCopy(); });
        }

        public List<Candidate> GetAllCandidates()
        {
            return candidates.ConvertAll((v) => { return v.CreateDeepCopy(); });
        }

        public List<Candidate> GetCandidates(/* here search criteria go */)
        {
            throw new NotImplementedException();
        }

        public void SaveVacancy(Vacancy v)
        {
            throw new NotImplementedException();
        }

        public void SaveCandidate(Candidate c)
        {
            throw new NotImplementedException();
        }
    }
}
