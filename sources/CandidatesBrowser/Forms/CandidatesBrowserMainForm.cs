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
        private bool editEnabled = false;
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
            editEnabled = !editEnabled;
        }

        private void mainGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (editEnabled)
            {
                editEnabled = false;
                candidateForm.FormCandidate = (Candidate)((GridView)sender).GetRow(e.RowHandle);
                candidateForm.ShowDialog();
            }
        }

        private void mainGridView_DoubleClick(object sender, EventArgs e)
        {
            candidateForm.FormCandidate = (Candidate)((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle);
            candidateForm.ShowDialog();
        }
    }
}
