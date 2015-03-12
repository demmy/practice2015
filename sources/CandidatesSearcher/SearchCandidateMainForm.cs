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
using DevExpress.XtraGrid.Views.Base;
using System.Collections.ObjectModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace CandidatesSearcher
{
    public partial class SearchCandidateMainForm : Form
    {
        CandidateSearchVievModel vm;
        CandidateSearchCommand command;
        //int index;

        public SearchCandidateMainForm()
        {
            InitializeComponent();
            vm = new CandidateSearchVievModel();
            vm.View = this; 
            command = new CandidateSearchCommand(vm);
            ComboBoxItemCollection updater = candidateEnglishLevel.Properties.Items;
            updater.BeginUpdate();
            updater.Add(new ComboBoxAdd(EnglishLevel.Beginner, "Beginer"));
            updater.Add(new ComboBoxAdd(EnglishLevel.Elementary, "Elementary"));
            updater.Add(new ComboBoxAdd(EnglishLevel.PreIntermediate, "PreIntermediate"));
            updater.Add(new ComboBoxAdd(EnglishLevel.Intermediate, "Intermediate"));
            updater.Add(new ComboBoxAdd(EnglishLevel.UpperIntermediate, "UpperIntermediate"));
            updater.Add(new ComboBoxAdd(EnglishLevel.Proficiency, "Proficiency"));
            updater.Add(new ComboBoxAdd(EnglishLevel.Unknown, "Clear"));
            updater.EndUpdate();      
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            command.Execute();  
        }

        private void SearchCandidateMainForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = vm;
            CandidateName.DataBindings.Add("EditValue", bindingSource, "CandidateName");
            CandidateSoname.DataBindings.Add("EditValue", bindingSource, "CandidateSoname");
            CandidatePhone.DataBindings.Add("EditValue", bindingSource, "CandidatePhone");
            CandidateCity.DataBindings.Add("EditValue", bindingSource, "CandidateCity");
            CandidateTable.DataSource = vm.SortedCandidate;
        }
        
            class ComboBoxAdd
            {
                string name;
                EnglishLevel level;
                public EnglishLevel Level
                {
                    get
                    {return level;}
                    set
                    {
                        if(value != level)
                            level = value;
                    }
                }
                
                
                public ComboBoxAdd(EnglishLevel level, string name)
                {
                    this.level = level;
                    this.name = name;
                }

                public override string ToString()
                {
                    return name;
                }

                
            }
      private void CandidateEnglishLevel_EditValueChanged(object sender, EventArgs e)
      {
              var editValue = (ComboBoxAdd)candidateEnglishLevel.EditValue;
              vm.EngLevel = editValue.Level;
      }

      private void CandidateFromDate_EditValueChanged(object sender, EventArgs e)
      {  
          vm.FromDate = (DateTime)CandidateFromDate.EditValue;
      }

      private void CandidateToDat_EditValueChanged(object sender, EventArgs e)
      {
          vm.ToDate = (DateTime)CandidateToDat.EditValue;
      }

      private void AgreeToRelocate_EditValueChanged(object sender, EventArgs e)
      {
          vm.AgreeToRelocate = (bool)AgreeToRelocate.EditValue;
      }


      public void Refresher()
      {
          CandidateTable.DataSource = vm.SortedCandidate;
          CandidateTable.RefreshDataSource();
          CandidateTable.Refresh();
      }


      private void CandidateGridview_DoubleClick(object sender, EventArgs e)
      {
          GridView view = (GridView)sender;
          GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
          int cellNumberInfo=0;

          if (info.InRow || info.InRowCell)
          {
              cellNumberInfo = info.RowHandle;
          }

          SearchCandidatFullInfoForm form= new SearchCandidatFullInfoForm(vm,cellNumberInfo);
          form.ShowDialog();
      }

     



        
    }
}
