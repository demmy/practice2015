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

        //public CandidatesParserSelectData()
        public CandidatesParserSelectData(CandidatesParserViewModel manager)
        {
            InitManager(manager);
            InitializeComponent();

            /////////////////////////////////////////////////////////
            form2OrigHight = this.Height;
            form2OrigWidth = this.Width;
            form2MainLayoutOrigHeight = this.layoutControl1.Height;
            form2MainLayoutOrigWidth = this.layoutControl1.Width;
            ////////////////////////////////////////////////////////

            //////////////////////// ComboBoxesInit \\\\\\\\\\\\\\\\\\\\\\\\++
            addSkypes();
            addEmails();
            addWebSites();
            addPhoneNumbersToGrid();
            ////////////////////////////////////////////////////////////////
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CandidatesParserWriterDataBase ModalForm2 = new CandidatesParserWriterDataBase(manager);
            ModalForm2.ShowDialog();
        }


        ////////////////////////////////////   FormResizeStyle      \\\\\\\\\\\\\\\\\\\\\\\\\++
        private void resizeBoxesCenter()
        {
            //form2_ComboBoxEdit_Skypes.Dock = DockStyle.Fill;
            //form2_ComboBoxEdit_Emails
            //form2_ComboBoxEdit_WebSites

        }
        private void resizeFormInside(object sender, EventArgs e)
        {
             resizeBoxesCenter();
        }
        private void XtraForm1_ResizeEnd(object sender, EventArgs e)
        {
            /*   
               float percent1 = (float)this.Height / this.form1OrigHight;
               float percent2 = (float)this.Width / this.form1OrigWidth;

               float percent = (percent1 < percent2) ? (percent1) : (percent2);

               this.Height = (int)(percent * this.form1OrigHight);
               this.Width = (int)(percent * this.form1OrigWidth);
            */
        }
        ///////////////////////////////////////////////////////////////////////////////////////
    

        /////////////////////////////////// ComboBoxes \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\++
        private void addSkypes()
        {
            ComboBoxItemCollection coll = form2_ComboBoxEdit_Skypes.Properties.Items;
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
        private void addEmails()
        {
            ComboBoxItemCollection coll = form2_ComboBoxEdit_Emails.Properties.Items;
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
        private void addWebSites()
        {
            ComboBoxItemCollection coll = form2_ComboBoxEdit_WebSites.Properties.Items;
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

        //////////////////////////// PhoneNumber Table(Grid) \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void addPhoneNumbersToGrid()
        {
            form2_gridControl_PhoneNumber.DataSource = manager.GetPhoneNumberContacts();
        }


        private void form2_ComboBoxEdit_Skypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = form2_ComboBoxEdit_Skypes.SelectedIndex;
            string b = form2_ComboBoxEdit_Skypes.EditValue.ToString();
        }

        private void form2_Button_CopySelectedToBuffer_Click(object sender, EventArgs e)
        {
            string SelectedPhoneNumbers = "";

            bool FirstIteration = true;
            foreach (var item in manager.GetPhoneNumberContacts())
            {
                
                if (item.IsChosen == true)
                {
                    if (FirstIteration)
                    {
                        FirstIteration = false;
                    }
                    else
                    {
                        SelectedPhoneNumbers += "; ";
                    }
                    SelectedPhoneNumbers += item.Value;
                    
                }
            }


            Clipboard.SetText(
                                "Skype: " + form2_ComboBoxEdit_Skypes.EditValue.ToString() + "\n"
                                +"EMail: " + form2_ComboBoxEdit_Emails.EditValue.ToString() + "\n"
                                +"WebSite: " + form2_ComboBoxEdit_WebSites.EditValue.ToString() + "\n"
                                +"PhoneNumbers: " + SelectedPhoneNumbers + "\n"
                              );
        }
        ////////////////////////////////////////////////////////////////////////////////////
    }


}