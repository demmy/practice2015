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
        }

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
