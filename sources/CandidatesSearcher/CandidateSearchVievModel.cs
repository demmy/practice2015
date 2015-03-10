using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using HumanResourcesLibrary;
using System.Windows.Input;
using HumanResourcesLibrary.DataClasses;
using System.Collections.ObjectModel;

namespace CandidatesSearcher
{
    public class CandidateSearchVievModel : ViewModelBase, IDisposable
    {
        
        private readonly CandidateSearchCommand searchComand;
        public  SearchCandidateMainForm View;

        public ObservableCollection<Candidate> SortedCandidate;
        

        public CandidateSearchVievModel()
        {
           // searchComand = ViewModelSource.Create(() => new CandidateSearchCommand(this));
            searchComand = new CandidateSearchCommand(this);
            
        }

        #region BindingFields

        public string candidateName = "";
        public string CandidateName
        {
            get { return candidateName; }
            set
            {
                if (value != candidateName)
                {
                    candidateName = value;
                    RaisePropertyChanged("CandidateName");
                }
            }
        }

        private string candidateSoname = "";
         public string CandidateSoname
        {
            get { return candidateSoname; }
            set
            {
                if (value != candidateSoname)
                {
                    candidateSoname = value;
                    RaisePropertyChanged("CandidateSoname");
                }
            }
        }

         private string candidateCity = "";
         public string CandidateCity
         {
             get { return candidateCity; }
             set
             {
                 if (value != candidateCity)
                 {
                     candidateCity = value;
                     RaisePropertyChanged("CandidateCity");
                 }
             }
         }


         private string candidatePhone = "";
         public string CandidatePhone
         {
             get { return candidatePhone; }
             set
             {
                 if (value == null)
                     candidatePhone = "";
                 else
                 if (value != candidatePhone)
                 {
                     candidatePhone = value;
                     RaisePropertyChanged("CandidatePhone");
                 }
             }
         }

         private EnglishLevel engLevel;
         public EnglishLevel EngLevel
         {
             get { return engLevel; }
             set
             {
                 if (value == null)
                     engLevel = default(EnglishLevel);
                 else
                 if (value != engLevel)
                 {
                     engLevel = value;
                     RaisePropertyChanged("CandidateEnglishLevel");
                 }
             }
         }

         private DateTime fromDate;
         public DateTime FromDate
         {
             get { return fromDate; }
             set
             {
                 if (value != fromDate)
                 {
                     fromDate = value;
                     RaisePropertyChanged("CandidateFromDate");
                 }
             }
         }

         private DateTime toDate;
         public DateTime ToDate
         {
             get { return toDate; }
             set
             {
                 if (value != toDate)
                 {
                     toDate = value;
                     RaisePropertyChanged("CandidateToDate");
                 }
             }
         }

         private bool agreeToRelocate = default (bool); //Как отслеживать таинствевнное 3е состояние?
         public bool AgreeToRelocate 
         {
             get { return agreeToRelocate; }
             set
             {
                 if (value != agreeToRelocate)
                 {
                     agreeToRelocate = value;
                     RaisePropertyChanged("AgreeToRelocate");
                 }
             }
         }
        #endregion

      public ICommand SearchCommand
        {
            get { return searchComand; }
        }
        
        
        public void Dispose()
        {
           
        }

       



       
    }
}
