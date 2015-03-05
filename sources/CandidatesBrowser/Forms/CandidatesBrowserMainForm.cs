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

        public CandidatesBrowserMainForm()
        {
            //mainGridControl.DataSource = RepositoryService.Repository.GetAllCandidates();
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //this.AddOwnedForm(new CandidateForm(
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editEnabled = !editEnabled;
        }

        private void mainGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (editEnabled)
            {
                //this.AddOwnedForm(new CandidateForm(
            }
        }

        private void mainGridView_DoubleClick(object sender, EventArgs e)
        {
            //this.AddOwnedForm(new CandidateForm(
            //((GridView)sender).GetRow//GetDataRow(((GridView)sender).FocusedRowHandle);
        }
    }
}
