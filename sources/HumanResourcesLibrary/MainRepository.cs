using HumanResourcesLibrary.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary
{
    public class MainRepository : IMainRepository
    {
        private List<Vacancy> vacancies = new List<Vacancy>();
        private List<Candidate> candidates = new List<Candidate>();

        public MainRepository()
        {
            vacancies.Add(new Vacancy() { Title = "Super Vacancy 1" });
            candidates.Add(new Candidate() { LastName = "Ivanov", FirstName = "Ivan", Phones = new List<Phone>() });
            candidates.Add(new Candidate() { LastName = "Coul", FirstName = "Petr", Phones = new List<Phone>(), EnglishLevel = EnglishLevel.Intermediate, DOB =DateTime.Today, City = "Dnepr" });
            candidates.Add(new Candidate() { LastName = "Petrov", FirstName = "Tiran", Phones = new List<Phone>(), EnglishLevel = EnglishLevel.UpperIntermediate });
            candidates.Add(new Candidate() { LastName = "Sidorov", FirstName = "Babai", Phones = new List<Phone>() });
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
        public List<Candidate> GetCandidates(string name, string soname, string candidate_phone, string city,
                                                bool agreeToRelocate,
                                                EnglishLevel engLevel,
                                                DateTime from, DateTime to)
        {
            
            IEnumerable<Candidate> filteredCandidates = new List<Candidate>();
            filteredCandidates = candidates.Where
                (candidateName => (!string.IsNullOrWhiteSpace(name) ? candidateName.FirstName == name : true))
                .Where(candidateSoname => (!string.IsNullOrWhiteSpace(soname) ? candidateSoname.LastName == soname : true))
                .Where(candidateCity => (!string.IsNullOrWhiteSpace(soname) ? candidateCity.City == city : true))
                .Where(candidateIsAgreeToRelocate => candidateIsAgreeToRelocate.RelocationAgreement == agreeToRelocate)
                .Where(candidateEngLevel => candidateEngLevel.EnglishLevel == engLevel)
                .Where(candidateFromDate => ((default(DateTime) != from) ? (candidateFromDate.DOB > from): true))
                .Where(candidateToDate => ((default(DateTime) != to)?candidateToDate.DOB < to:true));
           List <Candidate> tmp = filteredCandidates.ToList<Candidate>();
           return tmp;

              /* if (t.Key == "Name" && !string.IsNullOrWhiteSpace((string)t.Value)) 
                filteredCandidates = candidates.Where
                    (x => x.FirstName == t.Value);
               else filteredCandidates = candidates;

               if (t.Key == "Soname" && !string.IsNullOrWhiteSpace((string)t.Value))
                   filteredCandidates = filteredCandidates.Where
                       (x => x.LastName == t.Value);
               if (t.Key == "Phone" && !string.IsNullOrWhiteSpace((string)t.Value))
                   filteredCandidates = filteredCandidates.Where
                       (x => x.Phones == t.Value);
               if (t.Key == "City" && !string.IsNullOrWhiteSpace((string)t.Value))
                   filteredCandidates = filteredCandidates.Where
                       (x => x.City == t.Value);
               if (t.Key == "AgreeToRelocate")
                   filteredCandidates = filteredCandidates.Where
                       (x => x.RelocationAgreement == (bool)t.Value);
               if (t.Key == "FromDate" && (DateTime)t.Value != default(DateTime))
                   filteredCandidates = filteredCandidates.Where
                       (x => x.DOB >= (DateTime)t.Value);
               if (t.Key == "ToDate" && (DateTime)t.Value != default(DateTime))
                   filteredCandidates = filteredCandidates.Where
                       (x => x.DOB <= (DateTime)t.Value);
                   
            }
            return filteredCandidates.ToList<Candidate>();
        }

                /*filteredCandidates = candidates.Where
                    (item => !string.IsNullOrWhiteSpace(candidate_criteria["FirstName"] as string)
                        ? (item.FirstName == candidate_criteria["FirstName"])
                        : true);*/
            
        

            /*  List<Candidate> returns_candidate = candidates;
                
                foreach (var t in candidate_criteria)
                {

                    if (t.Value is string)
                    {
                        if (t.Key == "Name")
                            for (int i = 0; i < returns_candidate.Count; i++)
                            {
                                if ((string)t.Value != candidates[i].FirstName)
                                    returns_candidate.Remove(returns_candidate[i]);
                            }

                        if (t.Key == "Soname")
                            for (int i = 0; i < returns_candidate.Count; i++)
                            {
                                if ((string)t.Value != returns_candidate[i].LastName)
                                    returns_candidate.Remove(returns_candidate[i]);
                            }

                        if (t.Key == "Phone")
                            for (int i = 0; i < returns_candidate.Count; i++)
                            {
                                if ((string)t.Value != returns_candidate[i].Phones[i].PhoneNumber)
                                    returns_candidate.Remove(returns_candidate[i]);
                            }

                        if (t.Key == "City")
                            for (int i = 0; i < returns_candidate.Count; i++)
                            {
                                if ((string)t.Value != returns_candidate[i].City)
                                    returns_candidate.Remove(returns_candidate[i]);
                            }
                    }

                    if ((t.Value is bool) && t.Key == "AgreeToRelocate")
                        for (int i = 0; i < returns_candidate.Count; i++)
                        {
                            if ((bool)t.Value != returns_candidate[i].RelocationAgreement)
                                returns_candidate.Remove(returns_candidate[i]);
                        }


                    if (t.Value is DateTime)
                    {
                        if (t.Key == "FromData")
                            for (int i = 0; i < returns_candidate.Count; i++)
                            {
                                if ((DateTime)t.Value > returns_candidate[i].DOB)
                                    returns_candidate.Remove(returns_candidate[i]);
                            }
                        if (t.Key == "ToData")
                            for (int i = 0; i < returns_candidate.Count; i++)
                            {
                                if ((DateTime)t.Value < returns_candidate[i].DOB)
                                    returns_candidate.Remove(returns_candidate[i]);
                            }
                    }
                    
                }
                */
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
