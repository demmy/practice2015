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
        public List<Candidate> GetCandidates(Dictionary<string,object> candidate_criteria)
        {
                List<Candidate> returns_candidate = candidates;
                
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
                return returns_candidate;
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
