using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResourcesLibrary.DataClasses;
using HumanResourcesLibrary;
using VacanciesBrowser.Properties;

namespace VacanciesBrowser
{
    public partial class VacancyMainForm : Form
    {
        public VacancyMainForm()
        {
            InitializeComponent();
        }
        public BindingList<Vacancy> listDataSource;
        public IMainRepository repo;

        private void AddVacancy_Click(object sender, EventArgs e)//
        {
            VacancyAddOrEdit frm2 = new VacancyAddOrEdit();
            frm2.isNew = true;
            frm2.Show();
        }

        private void EditVacancy_Click(object sender, EventArgs e)
        {
            var vacancy = VacancyGridView.GetRow(VacancyGridView.FocusedRowHandle) as Vacancy;
            VacancyAddOrEdit frm2 = new VacancyAddOrEdit(vacancy);
            frm2.isNew = false;
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
            var vacancy = VacancyGridView.GetRow(VacancyGridView.FocusedRowHandle) as Vacancy;
            VacancyAddOrEdit frm2 = new VacancyAddOrEdit(vacancy);
            frm2.Show();
        }

        private void barButtonItem_Version_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(Resources.Version, "Version");
        }

        private void barButtonItem_Licence_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(Resources.License, "Лицензионное соглашение");
        }

        private void VacancyMainForm_Load(object sender, EventArgs e)
        { 
            List<Vacancy> vacancyForPrint = new List<Vacancy>();
            listDataSource = new BindingList<Vacancy>();
            repo = RepositoryService.Repository;
            vacancyForPrint = repo.GetAllVacancies(); 
            foreach(var vac in vacancyForPrint)
            {
                listDataSource.Add(vac);
            }
            VacancyGridList.DataSource = listDataSource;

        }

        private void VacancyGridList_DoubleClick(object sender, EventArgs e)
        {
            var vacancy = VacancyGridView.GetRow(VacancyGridView.FocusedRowHandle) as Vacancy;
            VacancyAddOrEdit frm2 = new VacancyAddOrEdit(vacancy);
            frm2.isNew = false;
            frm2.Show();

        }

        private void VacancyMainForm_Activated(object sender, EventArgs e)
        {
            VacancyGridList.DataSource = repo.GetAllVacancies(); 
        }

        
    }
}
