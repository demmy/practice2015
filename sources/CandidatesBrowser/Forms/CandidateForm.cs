using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HumanResourcesLibrary.DataClasses; // for Candidate
using DevExpress.XtraGrid.Views.Grid;

namespace CandidatesBrowser.Forms
{
    public partial class CandidateForm : Form
    {
        public CandidateForm()
        {
            InitializeComponent();
        }
        
        // TODO: you are free to change this name if you have a better one.
        public Candidate FormCandidate
        {
            get
            {
                return this.candidate;
            }
            set 
            {                
                this.candidate = value;
                this.candidateCopy = value.CreateDeepCopy();
                candidateBindingSource.DataSource = candidateCopy;
                RenewPhoto();
            }
        }

        private void RenewPhoto()
        {
            if (candidate.Photo != null)
            {
                using (var stream = new MemoryStream(candidate.Photo))
                {
                    this.candidatePhoto.Image = Image.FromStream(stream);
                }
            }
            else
            {
                // TODO: load the picture for the candidate who has no photo.
            }
        }

        private Candidate candidate, candidateCopy;

        private void commentsGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var newContact = (ContactWithCandidate)commentsGridView.GetRow(e.RowHandle);
            newContact.Date = DateTime.Now;
            newContact.Type = ContactTypes.Call;
            newContact.Comment = "";            
        }

        private void RowsDeletion(object sender, KeyEventArgs e)
        {
            var gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
                gridView.DeleteSelectedRows();
        }

        private void commentsGridView_KeyDown(object sender, KeyEventArgs e)
        {
            RowsDeletion(sender, e);
        }

        private void phonesGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var newPhone = (Phone)commentsGridView.GetRow(e.RowHandle);
            newPhone.PhoneNumber = "";
            newPhone.Type = PhoneType.Mobile;
        }

        private void phonesGridView_KeyDown(object sender, KeyEventArgs e)
        {
            RowsDeletion(sender, e);
        }

        private void socialNetworksGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var newSocNetowrk = (SocialNetwork)commentsGridView.GetRow(e.RowHandle);
            newSocNetowrk.Link = "";
            newSocNetowrk.Type = SocialNetworkType.Facebook;
        }

        private void socialNetworksGridView_KeyDown(object sender, KeyEventArgs e)
        {
            RowsDeletion(sender, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            candidate = candidateCopy.CreateDeepCopy();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CandidateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.candidate.Equals(this.candidateCopy))
            {
                var result = MessageBox.Show("Record has been changed but not saved.\nDo you want to save changes?",
                    "Warning", MessageBoxButtons.YesNoCancel);
                
                switch (result)
                {
                    case DialogResult.Yes:
                        candidate = candidateCopy; // WRONG
                        break;

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
