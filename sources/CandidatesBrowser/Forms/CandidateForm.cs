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
    public partial class CandidateForm : Form
    {
        public Candidate FormCandidate { get; set; }

        public CandidateForm()
        {
            FormCandidate = null;

            InitializeComponent();
        }
    }
}
