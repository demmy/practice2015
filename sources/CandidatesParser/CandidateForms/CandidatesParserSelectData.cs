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

        public CandidatesParserSelectData()
        {
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
            ////////////////////////////////////////////////////////////////

            //gridColumn4 = gridView1.Columns.Add();
            //gridColumn4.Caption = "1";
            //GridControl.DataSource 
            
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Rows.Add("Hello");
            table.Rows.Add("World");

            //DataTable newTable = form2_gridControl_PhoneNumber.; 
            
            // DataSource
            form2_gridControl_PhoneNumber.DataSource = table;

            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CandidatesParserWriterDataBase ModalForm2 = new CandidatesParserWriterDataBase();
            ModalForm2.ShowDialog();

        }


        ////////////////////////////////////   FormResizeStyle      \\\\\\\\\\\\\\\\\\\\\\\\\++
        private void resizeBoxesCenter()
        {
            form2_ComboBoxEdit_Skypes.Dock = DockStyle.Fill;
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
                //foreach()
                {
                coll.Add("VasjaPupkin_Skype1");
                coll.Add("VasjaPupkin_Skype2");
                coll.Add("VasjaPupkin_Skype3");
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
                //foreach()
                {
                    coll.Add("VasjaPupkin@mail.com1");
                    coll.Add("VasjaPupkin@mail.com2");
                    coll.Add("VasjaPupkin@mail.com3");
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
                //foreach()
                {
                    coll.Add("VasjaPupkin.com1");
                    coll.Add("VasjaPupkin.com2");
                    coll.Add("VasjaPupkin.com3");
                }
            }
            finally
            {
                coll.EndUpdate();
            }
        }

        private void form2_ComboBoxEdit_Skypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = form2_ComboBoxEdit_Skypes.SelectedIndex;
            string b = form2_ComboBoxEdit_Skypes.EditValue.ToString();
        }

        private void form2_Button_CopySelectedToBuffer_Click(object sender, EventArgs e)
        {
            string SelectedPhoneNumbers;

            //foreach() // как-то там заполнились
            SelectedPhoneNumbers = "789 888 888, 888 888 888, 123 123 123";


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