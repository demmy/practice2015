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
        public List<Vacancy> GetAllVacancies()
        {
            throw new NotImplementedException();
        }

        public List<Candidate> GetAllCandidates()
        {
            throw new NotImplementedException();
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
