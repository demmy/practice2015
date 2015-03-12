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
        List<Candidate> GetCandidates(string name, string soname, string candidate_phone, string city,
                                                bool agreeToRelocate,
                                                EnglishLevel engLevel,
                                                DateTime from, DateTime to);
        void SaveVacancy(Vacancy v);
        void SaveCandidate(Candidate c);
    }
}
