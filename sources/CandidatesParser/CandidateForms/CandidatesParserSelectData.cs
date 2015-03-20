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
using DevExpress.XtraEditors.Controls;

namespace CandidatesParser.CandidateForms
{
    public partial class CandidatesParserSelectData : DevExpress.XtraEditors.XtraForm
    {

        public CandidatesParserSelectData(CandidatesParserViewModel manager)
        {
            InitManager(manager);
            InitializeComponent();

            //////////////////////// ComboBoxesInit \\\\\\\\\\\\\\\\\\\\\\\\++
            AddSkypes();
            AddEmails();
            AddWebSites();
            AddPhoneNumbersToGrid();
            ////////////////////////////////////////////////////////////////
        }

        /////////////////////////////////// ComboBoxes \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\++
        private void AddSkypes()
        {
            ComboBoxItemCollection coll = comboBoxEdit_Skypes.Properties.Items;
            coll.BeginUpdate();
            try
            {
                foreach(var item in manager.GetSkypeContacts())
                {
                coll.Add(item.Value);
                }
            }
            finally
            {
                coll.EndUpdate();
            }
        }
        private void AddEmails()
        {
            ComboBoxItemCollection coll = comboBoxEdit_Emails.Properties.Items;
            coll.BeginUpdate();
            try
            {
                foreach (var item in manager.GetEmailContacts())
                {
                    coll.Add(item.Value);
                }
            }
            finally
            {
                coll.EndUpdate();
            }
        }
        private void AddWebSites()
        {
            ComboBoxItemCollection coll = comboBoxEdit_WebSites.Properties.Items;
            coll.BeginUpdate();
            try
            {
                foreach (var item in manager.GetWebSiteContacts())
                {
                    coll.Add(item.Value);
                }
            }
            finally
            {
                coll.EndUpdate();
            }
        }
        private void ComboBoxEdit_Skypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager.SelectSkype(comboBoxEdit_Skypes.SelectedIndex);
        }
        private void ComboBoxEdit_Emails_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager.SelectEmail(comboBoxEdit_Emails.SelectedIndex);
        }
        private void ComboBoxEdit_WebSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager.SelectWebSite(comboBoxEdit_WebSites.SelectedIndex);
        }


        //////////////////////////// PhoneNumber Table(Grid) \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\++
        private void AddPhoneNumbersToGrid()
        {
            gridControl_PhoneNumber.DataSource = manager.GetPhoneNumberContacts();
        }


        ////////////////////////////////////   Buttons and Actions      \\\\\\\\\\\\\\\\\\\\\\\\\++
        private void Button_SaveContactsToBD_Click(object sender, EventArgs e)
        {
            CandidatesParserWriterDataBase modalFormForWritingToDataBase = new CandidatesParserWriterDataBase(manager);
            modalFormForWritingToDataBase.ShowDialog();
        }
        private void Button_CopySelectedToBuffer_Click(object sender, EventArgs e)
        {
            string selectedPhoneNumbers = "";

            bool firstIteration = true;
            foreach (var item in manager.GetPhoneNumberContacts())
            {
                
                if (item.IsChosen)
                {
                    if (firstIteration)
                    {
                        firstIteration = false;
                    }
                    else
                    {
                        selectedPhoneNumbers += "; ";
                    }
                    selectedPhoneNumbers += item.Value;
                    
                }
            }


            Clipboard.SetText(
                                "Skype: " + comboBoxEdit_Skypes.EditValue.ToString() + "\n"
                                +"EMail: " + comboBoxEdit_Emails.EditValue.ToString() + "\n"
                                +"WebSite: " + comboBoxEdit_WebSites.EditValue.ToString() + "\n"
                                +"PhoneNumbers: " + selectedPhoneNumbers + "\n"
                              );
        }
        
    }


}