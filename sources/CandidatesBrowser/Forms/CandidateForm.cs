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

namespace CandidatesBrowser.Forms
{
    public partial class CandidateForm : Form
    {
        /// <summary>
        /// Create a new CandidateForm binded to a Candidate item.
        /// </summary>
        /// <param name="candidate"> A Candidate item that is binded to the form's controls. </param>
        public CandidateForm(Candidate candidate)
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
                candidateBindingSource.DataSource = candidate;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Candidate candidate;
    }
}
