using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandidatesBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Forms.CandidatesBrowserMainForm());

            var candidate = HumanResourcesLibrary.RepositoryService.Repository.GetAllCandidates()[1];
            var form = new Forms.CandidateForm() { FormCandidate = candidate };
            Application.Run(form);
        }
    }
}
