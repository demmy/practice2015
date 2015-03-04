using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VacanciesBrowser
{
    public partial class ListVacancy : Form
    {
        public ListVacancy()
        {
            InitializeComponent();
        }

        private void AddVacancy_Click(object sender, EventArgs e)
        {
            VacancyAddOrEdit frm2 = new VacancyAddOrEdit();
            frm2.Show();
        }

        private void EditVacancy_Click(object sender, EventArgs e)
        {
            VacancyAddOrEdit frm2 = new VacancyAddOrEdit();
            frm2.Show();
        }

        private void barButtonItem_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem_AddVacancy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VacancyAddOrEdit frm2 = new VacancyAddOrEdit();
            frm2.Show();
        }

        private void barButtonItem_EditVacancy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VacancyAddOrEdit frm2 = new VacancyAddOrEdit();
            frm2.Show();
        }

        private void barButtonItem_Version_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Version");
        }

        private void barButtonItem_Licence_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Version");
        }



    }
}
