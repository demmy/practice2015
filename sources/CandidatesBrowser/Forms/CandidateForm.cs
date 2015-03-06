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
            englishLevelComboBox.Properties.Items.AddRange(typeof (HumanResourcesLibrary.DataClasses.EnglishLevel).GetEnumValues());
            genderComboBox.Properties.Items.AddRange(typeof(HumanResourcesLibrary.DataClasses.Gender).GetEnumValues());
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
            if (candidateCopy.Photo != null)
            {
                using (var stream = new MemoryStream(candidateCopy.Photo))
                {
                    this.candidatePhoto.Image = Image.FromStream(stream);
                }
            }
            else
            {
                this.candidatePhoto.Image = null;
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
            SaveCandidate();
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
                        SaveCandidate();
                        break;

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void SaveCandidate()
        {
            candidate.LastName = candidateCopy.LastName;
            candidate.MiddleName = candidateCopy.MiddleName;
            candidate.FirstName = candidateCopy.FirstName;
            candidate.DOB = candidateCopy.DOB;
            candidate.Gender = candidateCopy.Gender;
            candidate.Country = candidateCopy.Country;
            candidate.City = candidateCopy.City;
            candidate.RelocationAgreement = candidateCopy.RelocationAgreement;
            candidate.Photo = null;
            if (candidateCopy.Photo != null)
            {
                candidate.Photo = new byte[candidateCopy.Photo.Length];
                Array.Copy(candidateCopy.Photo, candidate.Photo, candidateCopy.Photo.Length);
            }
            candidate.Email = candidateCopy.Email;
            candidate.Skype = candidateCopy.Skype;
            candidate.SiteURL = candidateCopy.SiteURL;
            candidate.EnglishLevel = candidateCopy.EnglishLevel;
            candidate.Phones = candidateCopy.Phones.ConvertAll(phone => phone.CreateDeepCopy());
            candidate.ContactsList = candidateCopy.ContactsList.ConvertAll(contact => contact.CreateDeepCopy());
            candidate.SocialNetworksList = candidateCopy.SocialNetworksList.ConvertAll(socNet => socNet.CreateDeepCopy());

            HumanResourcesLibrary.RepositoryService.Repository.SaveCandidate(candidate);
        }

        private void candidatePhoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dialog = new OpenFileDialog();            
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                using (var reader = new BinaryReader(File.Open(dialog.FileName, FileMode.Open)))
                {
                    candidateCopy.Photo = reader.ReadBytes((int)(new FileInfo(dialog.FileName).Length));
                    RenewPhoto();
                }
            }
        }
    }
}
