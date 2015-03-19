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

using System.IO;

namespace CandidatesParser.CandidateForms
{
    

    public partial class CandidatesParserMainForm : DevExpress.XtraEditors.XtraForm
    {
        public CandidatesParserMainForm()
        {
            InitializeComponent();

            origHeight = this.Height;
            origWidth = this.Width;
            mainLayoutOrigHeight = this.layoutControl.Height;
            mainLayoutOrigWidth = this.layoutControl.Width;

        }


        ////////////////////////////////////   FormResizeStyle      \\\\\\\\\\\\\\\\\\\\\\\\\++
        private void ResizeFormInside(object sender, EventArgs e)
        {
            float percent1 = (float)this.Height / origHeight;
            float percent2 = (float)this.Width / origWidth;

            float percent = (percent1 < percent2) ? (percent1) : (percent2);

            this.layoutControl.Height = (int)(percent * mainLayoutOrigHeight);
            this.layoutControl.Width = (int)(percent * mainLayoutOrigWidth);

            TextResize(percent);
            ResizeFormInsidePutToCenter();
        }
        private void TextResize(float percent)
        {
            this.textField_FilePath.Font = new System.Drawing.Font("Tahoma", (float)(8.25 * percent));
            this.layoutControl_Button_Unused.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, this.layoutControl_Button_Unused.Height - (button_FilePath.Height));
        }
        private void ResizeFormInsidePutToCenter()
        {
            if (this.Width > origWidth)
            {
                this.layoutControl.Left = 0
                                                + (this.Width
                                                - (this.origWidth - mainLayoutOrigWidth)
                                                - this.layoutControl.Width) / 2;
            }
            else
            {
                this.layoutControl.Left = 0;
            }

            if (this.Height > origHeight)
            {
                this.layoutControl.Top = 0
                                                + (this.Height
                                                - (this.origHeight - mainLayoutOrigHeight)
                                                - this.layoutControl.Height) / 2;
            }
            else
            {
                this.layoutControl.Top = 0;
            }


        }

        private void ResizeFormEnd(object sender, EventArgs e)
        {
            float percent1 = (float)this.Height / this.origHeight;
            float percent2 = (float)this.Width / this.origWidth;

            float percent = (percent1 < percent2) ? (percent1) : (percent2);

            this.Height = (int)(percent * this.origHeight);
            this.Width = (int)(percent * this.origWidth);
        }


        ////////////////////////////////////   Buttons and Actions      \\\\\\\\\\\\\\\\\\\\\\\\\++
        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (File.Exists(textField_FilePath.Text))
            {
                bool Error = false;
                try
                {
                    manager.Read(textField_FilePath.Text);
                }
                catch
                {
                    MessageBox.Show(this.msgErrorIncorrectStruct);
                    Error = true;
                    // Maybe it not a good method, but program is working :)
                }
                if (!Error)
                {
                    CandidatesParserSelectData modalForm1 = new CandidatesParserSelectData(manager);
                    modalForm1.ShowDialog();
                }
            }
            else
            {
                if (textField_FilePath.Text == emptyFilePathString)
                {
                    MessageBox.Show(this.msgErrorEmptyFilePath);
                }
                else
                {
                    MessageBox.Show(this.msgErrorIncorrectFilePath);
                }
            }
        }
        private void Button_FilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = this.fileFormatFilter;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textField_FilePath.Text = openFileDialog1.FileName;
            }
        }

        private void TextField_FilePath_Leave(object sender, EventArgs e)
        {
            if (textField_FilePath.Text == "")
            {
                textField_FilePath.Text = emptyFilePathString;
            }
        }
        private void TextField_FilePath_MouseClick(object sender, EventArgs e)
        {
            textField_FilePath.Text = "";
        }

    }
}
