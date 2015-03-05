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
        List<Candidate> GetCandidates(Dictionary<string, object> candidate_criteria);
        void SaveVacancy(Vacancy v);
        void SaveCandidate(Candidate c);
    }
}
