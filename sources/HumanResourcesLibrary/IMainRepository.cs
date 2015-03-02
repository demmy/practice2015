using HumanResourcesLibrary.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary
{
    public interface IMainRepository
    {
        List<Vacancy> GetAllVacancies();
        List<Candidate> GetAllCandidates();
        List<Candidate> GetCandidates(/* here search criteria go */);
        void SaveVacancy(Vacancy v);
        void SaveCandidate(Candidate c);
    }
}
