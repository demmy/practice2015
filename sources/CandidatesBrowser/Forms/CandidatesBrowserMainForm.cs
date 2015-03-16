using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanResourcesLibrary.DataClasses;
using DevExpress.LookAndFeel;
using DevExpress.XtraGrid;
using DevExpress.Utils.Drawing;
using System.Reflection;
using HumanResourcesLibrary;
using DevExpress.XtraGrid.Views.Grid;

namespace CandidatesBrowser.Forms
{
    public partial class CandidatesBrowserMainForm : Form
    {
        private CandidateForm candidateForm = null;

        public CandidatesBrowserMainForm()
        {
            candidateForm = new CandidateForm();

            InitializeComponent();
            mainBindingSource.DataSource = RepositoryService.Repository.GetAllCandidates();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            candidateForm.FormCandidate = new Candidate();
            candidateForm.ShowDialog();
            mainBindingSource.DataSource = RepositoryService.Repository.GetAllCandidates();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (mainGridView != null && mainGridView.SelectedRowsCount == 1)
                this.mainGridView_DoubleClick(mainGridView, e);
        }

        private void mainGridView_DoubleClick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                candidateForm.FormCandidate = (Candidate)((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle);
                candidateForm.ShowDialog();
            }
        }
    }
}
