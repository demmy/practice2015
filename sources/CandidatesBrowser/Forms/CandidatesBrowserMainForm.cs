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

namespace CandidatesBrowser.Forms
{
    public partial class CandidatesBrowserMainForm : Form
    {
        public CandidatesBrowserMainForm()
        {
            InitializeComponent();
        }

        private BindingList<Candidate> CreateData()
        {
            ContactWithCandidate newContact = null;
            Candidate newCandidate = null;
            BindingList<Candidate> Result = new BindingList<Candidate>();

            for (int i = 0; i < 29; i++)
            {
                newContact = new ContactWithCandidate();
                newContact.Date = new DateTime(1994, 01, 1 + i);
                newContact.Comment = String.Format("This is comment #{0}", i);
                newContact.Type = ContactTypes.Meet;
                
                newCandidate = new Candidate();
                newCandidate.FirstName = String.Format("Vasya_{0}", i);
                newCandidate.MiddleName = String.Format("Vasilievich_{0}", i);
                newCandidate.LastName = String.Format("Pupkin_{0}", i);
                newCandidate.ContactsList.Add(newContact); 
                
                Result.Add(newCandidate);
            }

            return Result;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainGridControl.DataSource = CreateData();
            mainGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            mainGridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            mainGridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            mainGridView.OptionsView.ShowIndicator = false;
            
            mainGridView.Appearance.Row.BackColor = SystemColors.Control;
            mainGridView.PaintAppearance.Empty.BackColor = SystemColors.Control;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.AddOwnedForm(new CandidateForm());
            this.OwnedForms[0].Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.AddOwnedForm(new CandidateForm());
            this.OwnedForms[0].Show();
        }

        private void mainGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle % 2 == 1)
                e.Appearance.BackColor = System.Drawing.Color.FromArgb(209, 214, 217);
        }
    }
}
