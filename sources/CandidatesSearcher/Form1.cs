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
using DevExpress.XtraEditors.Controls;
using DevExpress.Xpf.Editors;


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
            ComboBoxItemCollection updater = CandidateEnglishLevel.Properties.Items;
            updater.BeginUpdate();
            updater.Add(new ComboBoxAdd(EnglishLevel.Beginner, "Beginer"));
            updater.Add(new ComboBoxAdd(EnglishLevel.Elementary, "Elementary"));
            updater.Add(new ComboBoxAdd(EnglishLevel.Intermediate, "Intermediate"));
            updater.Add(new ComboBoxAdd(EnglishLevel.PreIntermediate, "PreIntermediate"));
            updater.Add(new ComboBoxAdd(EnglishLevel.UpperIntermediate, "UpperIntermediate"));
            updater.Add(new ComboBoxAdd(EnglishLevel.Proficiency, "Proficiency"));
            updater.EndUpdate();
           //updater.SelectedIndex = -1;
           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            command.Execute();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = vm;
            CandidateName.DataBindings.Add("EditValue", bindingSource, "CandidateName");
            CandidateSoname.DataBindings.Add("EditValue", bindingSource, "CandidateSoname");
            CandidatePhone.DataBindings.Add("EditValue", bindingSource, "CandidatePhone");
            CandidateCity.DataBindings.Add("EditValue", bindingSource, "CandidateCity");
            //CandidateEnglishLevel.DataBindings.Add("EditValue", bindingSource, "CandidateEnglishLevel");    
            CandidateFromDate.DataBindings.Add("EditValue", bindingSource, "CandidateFromDate");
            CandidateToDate.DataBindings.Add("EditValue", bindingSource, "CandidateToDate");
            AgreeToRelocate.DataBindings.Add("EditValue", bindingSource, "AgreeToRelocate");
        }
        
            class ComboBoxAdd
            {
                EnglishLevel level;
                string name;
                public ComboBoxAdd(EnglishLevel level, string name)
                {
                    this.level = level;
                    this.name = name;
                }

                public override string ToString()
                {
                    return name;
                }

                public EnglishLevel GetLevel()
                {
                    return level;
                }
            }
        

     

      private void CandidateEnglishLevel_EditValueChanged(object sender, EventArgs e)
      {
         // ComboBoxAdd p = ((sender as ComboBoxEdit).SelectedItem as ComboBoxAdd);
      }




        
    }
}
