using HumanResourcesLibrary;
using HumanResourcesLibrary.DataClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CandidatesSearcher
{
   public class CandidateSearchCommand : ICommand
    {
        
        private CandidateSearchVievModel viewModel;

      

        public bool CanExecuteCnanged()
        {
            return true;
        }
        public CandidateSearchCommand(CandidateSearchVievModel vm)
        {
            viewModel = vm;
        }

        #region Candidate Search Command members
        public void Execute()
        {

            HumanResourcesLibrary.MainRepository repo = new HumanResourcesLibrary.MainRepository();
            var value= repo.GetCandidates(viewModel.CandidateName, viewModel.CandidateSoname, viewModel.CandidatePhone, viewModel.CandidateCity,
                viewModel.AgreeToRelocate, viewModel.EngLevel, viewModel.FromDate, viewModel.ToDate);

            viewModel.SortedCandidate = new ObservableCollection<Candidate>(value);
            viewModel.View.Refresher();
            
            /*if (!string.IsNullOrWhiteSpace(viewModel.CandidateName))
            { 
                FormInfo.Add("Name", viewModel.CandidateName);
            }

            if (!string.IsNullOrWhiteSpace(viewModel.CandidateSoname))
            {
                FormInfo.Add("Soname", viewModel.CandidateSoname);
            }

            if (!string.IsNullOrWhiteSpace(viewModel.CandidateCity))
            {
                FormInfo.Add("City", viewModel.CandidateCity);
            }

            if (!string.IsNullOrWhiteSpace(viewModel.CandidatePhone))
            {
                FormInfo.Add("Phone", viewModel.CandidatePhone);
            }

            if (viewModel.EngLevel != null)
            {
                FormInfo.Add("EngLevel", viewModel.EngLevel);
            }

            if (viewModel.AgreeToRelocate!= null)
            {
                FormInfo.Add("AgreeToRelocate", viewModel.AgreeToRelocate);
            }

            if (viewModel.FromDate != default (DateTime))
            {
                FormInfo.Add("FromDate", viewModel.FromDate);
            }

            if (viewModel.ToDate != default(DateTime))
            {
                FormInfo.Add("ToDate", viewModel.ToDate);
            }*/
        }


        /*public Dictionary<string, object> GetFormInformation
        {
            get 
            {
                return FormInfo;
            }
        }*/

        public bool CanExecute(object o)
        {
            return true;
        }
        #endregion



        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

    }
}
