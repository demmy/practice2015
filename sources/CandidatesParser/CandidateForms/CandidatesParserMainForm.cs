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

            form1OrigHight = this.Height;
            form1OrigWidth = this.Width;
            form1MainLayoutOrigHeight = this.layoutControl1.Height;
            form1MainLayoutOrigWidth = this.layoutControl1.Width;

            
        }

        private void Form1_Button_OK_Click(object sender, EventArgs e)
        {
            if (File.Exists(Form1_TextField_FilePath.Text) == true)
            {
                manager.Read(Form1_TextField_FilePath.Text);
                CandidatesParserSelectData modalForm1 = new CandidatesParserSelectData(manager);
                modalForm1.ShowDialog();
            }
            else
            {
                showErrorMessage_FlieDoesNotExist();
            }
        }


        ////////////////////////////////////   FormResizeStyle      \\\\\\\\\\\\\\\\\\\\\\\\\++
        private void resizeFormInsisePutToCenter()
        {
            if(this.Width > form1OrigWidth)
            {
                this.layoutControl1.Left =      0
                                                + (this.Width 
                                                - (this.form1OrigWidth - form1MainLayoutOrigWidth) 
                                                - this.layoutControl1.Width) / 2;
            }
            else
            {
                this.layoutControl1.Left = 0;
            }

            if (this.Height > form1OrigHight)
            {
                this.layoutControl1.Top =       0 
                                                + (this.Height
                                                - (this.form1OrigHight - form1MainLayoutOrigHeight) 
                                                - this.layoutControl1.Height) / 2;
            }
            else
            {
                this.layoutControl1.Top = 0;
            }
           
            
        }
        private void textResize(float percent)
        {
            this.Form1_TextField_FilePath.Font = new System.Drawing.Font("Tahoma", (float)(8.25 * percent));
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, this.layoutControlItem5.Height - (Form1_Button_FilePath.Height));
        }
        private void resizeFormInside(object sender, EventArgs e)
        {
            float percent1 = (float)this.Height / form1OrigHight;
            float percent2 = (float)this.Width / form1OrigWidth;

            float percent = (percent1 < percent2) ? (percent1) : (percent2);

            this.layoutControl1.Height = (int)(percent * form1MainLayoutOrigHeight);
            this.layoutControl1.Width = (int)(percent * form1MainLayoutOrigWidth);

            textResize(percent);
            resizeFormInsisePutToCenter();
        }
        private void XtraForm1_ResizeEnd(object sender, EventArgs e)
        {
         
            float percent1 = (float)this.Height / this.form1OrigHight;
            float percent2 = (float)this.Width / this.form1OrigWidth;

            float percent = (percent1 < percent2) ? (percent1) : (percent2);

            this.Height = (int)(percent * this.form1OrigHight);
            this.Width = (int)(percent * this.form1OrigWidth);
          
        }

        private void Form1_Button_FilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form1_TextField_FilePath.Text = openFileDialog1.FileName;


            }
            else
            {
                showErrorMessage_FlieDoesNotExist();
            }

        }

        private void showErrorMessage_FlieDoesNotExist()
        {
            MessageBox.Show("Ошибка: Невозможно считать файл с диска!!!");
        }

        private void Form1_TextField_FilePath_Leave(object sender, EventArgs e)
        {
            if (Form1_TextField_FilePath.Text == "")
            {
                Form1_TextField_FilePath.Text = "Путь к файлу...";
            }
        }

        private void Form1_TextField_FilePath_MouseClick(object sender, EventArgs e)
        {
            Form1_TextField_FilePath.Text = "";
        }
        //////// Just Copy
        /*
               private void resizeFormInsisePutToCenter()
        {
            if(this.Width > form1OrigWidth)
            {
                this.layoutControl1.Left =      0
                                                + (this.Width 
                                                - (this.form1OrigWidth - form1MainLayoutOrigWidth) 
                                                - this.layoutControl1.Width) / 2;
            }
            else
            {
                this.layoutControl1.Left = 0;
            }

            if (this.Height > form1OrigHight)
            {
                this.layoutControl1.Top =       0 
                                                + (this.Height
                                                - (this.form1OrigHight - form1MainLayoutOrigHeight) 
                                                - this.layoutControl1.Height) / 2;
            }
            else
            {
                this.layoutControl1.Top = 0;
            }
           
            
        }
        private void textResize(float percent)
        {
            this.Form1_TextField_FilePath.Font = new System.Drawing.Font("Tahoma", (float)(8.25 * percent));
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, this.layoutControlItem5.Height - (Form1_Button_FilePath.Height));
        }
        private void resizeFormInside(object sender, EventArgs e)
        {
            float percent1 = (float)this.Height / form1OrigHight;
            float percent2 = (float)this.Width / form1OrigWidth;

            float percent = (percent1 < percent2) ? (percent1) : (percent2);

            this.layoutControl1.Height = (int)(percent * form1MainLayoutOrigHeight);
            this.layoutControl1.Width = (int)(percent * form1MainLayoutOrigWidth);

            textResize(percent);
            resizeFormInsisePutToCenter();
        }

        private void XtraForm1_ResizeEnd(object sender, EventArgs e)
        {
          
            float percent1 = (float)this.Height / this.form1OrigHight;
            float percent2 = (float)this.Width / this.form1OrigWidth;

            float percent = (percent1 < percent2) ? (percent1) : (percent2);

            this.Height = (int)(percent * this.form1OrigHight);
            this.Width = (int)(percent * this.form1OrigWidth);
         
        }
        */ 
        ///////////////////////////////////////////////////////////////////////////////////////
    }
}
