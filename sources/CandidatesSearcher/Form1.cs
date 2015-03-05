using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandidatesSearcher
{
    public partial class Form1 : Form
    {
        CandidateSearchVievModel vm;
        CandidateSearchCommand command;

        public Form1()
        {
            InitializeComponent();
            vm = new CandidateSearchVievModel();
            command = new CandidateSearchCommand(vm);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            command.Execute();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = vm;
            CandidateName.DataBindings.Add("CandidateName", bindingSource, "CandidateName");
            CandidateSoname.DataBindings.Add("CandidateSoname", bindingSource, "CandidateSoname");
            CandidateName.DataBindings.Add("CandidatePhone", bindingSource, "CandidatePhone");
            CandidateSoname.DataBindings.Add("CandidateCity", bindingSource, "CandidateCity");
            CandidateSoname.DataBindings.Add("CandidateEnglishLevel", bindingSource, "CandidateEnglishLevel");
            
           // CandidateName.DataBindings.Add("",);
        }


        
    }
}
