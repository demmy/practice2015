using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CandidatesParser.CandidateForms
{
    public partial class CandidatesParserWriterDataBase : DevExpress.XtraEditors.XtraForm
    {

        public CandidatesParserWriterDataBase(CandidatesParserViewModel manager)
        {
            InitManager(manager);
            InitializeComponent();
            InitDBGrid();
        }

        private void InitDBGrid()
        {
            gridControl_CandidatesGrid.DataSource = manager.GetAllCandidates(); 
        }

        ////////////////////////////////////   Buttons and Actions      \\\\\\\\\\\\\\\\\\\\\\\\\++
        private void Button_SaveContacts_Click(object sender, EventArgs e)
        {
            string sSkype;
            try
            {
                sSkype = manager.GetSkypeContacts().Find(x => x.IsChosen).Value;
            }
            catch 
            { 
                sSkype = " ";
            }

            string sEmail;
            try
            {
                sEmail = manager.GetEmailContacts().Find(x => x.IsChosen).Value;
            }
            catch 
            { 
                sEmail = " ";
            }

            string sWebSite;
            try
            {
                sWebSite = manager.GetWebSiteContacts().Find(x => x.IsChosen).Value;
            }
            catch
            {
                sWebSite = " "; 
            }

            
            manager.SaveCandidate(manager.GetAllCandidates()[gridView_CandidatesGrid.FocusedRowHandle], sSkype, sEmail, sWebSite, manager.GetPhoneNumberContacts());
            this.Close();
        }
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}