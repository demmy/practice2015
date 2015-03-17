using HumanResourcesLibrary.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HumanResourcesLibrary;

namespace VacanciesBrowser
{
    public partial class VacancyAddOrEdit : Form
    {
        public bool isNew;
        Vacancy vacancy;
        public IMainRepository repo;
        public VacancyAddOrEdit()
        {
            InitializeComponent();
			this.vacancy = new Vacancy();
        }
        public VacancyAddOrEdit(Vacancy vacancy)
        {
            this.vacancy = vacancy;
            InitializeComponent();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Выйти без сохранения?", "Вопрос", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
                // Close MsgBox
            }
            this.Close();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            List<Vacancy> list = new List<Vacancy>();
			repo = RepositoryService.Repository;
			if (isNew)
			{
				vacancy = new Vacancy();
				vacancy.Title = NameVacancy.Text;
				vacancy.Project = ListProject.Text;
				vacancy.City = ListCity.Text;
				vacancy.LevelEnglish = (LevelEnglish)Enum.Parse(typeof(LevelEnglish), ListLevelEnglish.Text.ToString());
				vacancy.Status = (Status)Enum.Parse(typeof(Status), ListStatus.Text.ToString());
				vacancy.Skills = ListSkills.Text;
				vacancy.Description = DescriptionVacancy.Text;
				vacancy.ResponsiblePerson = ListResponsiblePerson.Text;
				vacancy.TypeEmployment = (TypeEmployment)Enum.Parse(typeof(TypeEmployment), ListTypeEmployment.Text.ToString());
				vacancy.DateStart = (DateTime)StartDate.EditValue;
				vacancy.DateFinish = (DateTime)FinishDate.EditValue;
			}
			repo.SaveVacancy(vacancy);
			MessageBox.Show("Вакансия сохранена");
			this.Close();
        }

        private void VacancyAddOrEdit_Load(object sender, EventArgs e)
        {
            List<string> listProjectName = new List<string>();
            listProjectName.Add("ISD");
            listProjectName.Add("DataArt");
            listProjectName.Add("SiteCore");
            ListProject.Properties.DataSource = listProjectName;
            

            List<string> listStatusName = new List<string>();
            listStatusName.Add("Open");
            listStatusName.Add("Closed");
            ListStatus.Properties.DataSource = listStatusName;
            

            List<string> listLevelName = new List<string>();
            listLevelName.Add("Beginner");
            listLevelName.Add("Pre_Intermediate");
            listLevelName.Add("Intermediate");
            listLevelName.Add("Upper_Intermediate");
            listLevelName.Add("Advansed");
            listLevelName.Add("Proficiency");
            ListLevelEnglish.Properties.DataSource = listLevelName;
            

            List<string> ListTypeEmploymentName = new List<string>();
            ListTypeEmploymentName.Add("FullEmployment");
            ListTypeEmploymentName.Add("PartTime");
            ListTypeEmploymentName.Add("RemoteEmployment");
            ListTypeEmploymentName.Add("Internsip");
            ListTypeEmploymentName.Add("Practice");
            ListTypeEmployment.Properties.DataSource = ListTypeEmploymentName;
            

            List<string> listCityName = new List<string>();
            listCityName.Add("Dnipro");
            listCityName.Add("Lviv");
            listCityName.Add("Kyiv");
            ListCity.Properties.DataSource = listCityName;
            
            List<string> ListResponsiblePersonName = new List<string>();
            ListResponsiblePersonName.Add("She");
            ListResponsiblePersonName.Add("They");
            ListResponsiblePersonName.Add("He");
            ListResponsiblePerson.Properties.DataSource = ListResponsiblePersonName;

            ListResponsiblePerson.EditValue = vacancy.ResponsiblePerson;
            ListCity.EditValue = vacancy.City;
            ListTypeEmployment.EditValue = vacancy.TypeEmployment.ToString();
            ListLevelEnglish.EditValue = vacancy.LevelEnglish.ToString();
            ListStatus.EditValue = vacancy.Status.ToString();
            ListProject.EditValue = vacancy.Project;
            NameVacancy.Text = vacancy.Title;
            ListSkills.Text = vacancy.Skills;
            DescriptionVacancy.Text = vacancy.Description;
            StartDate.EditValue = vacancy.DateStart;
            FinishDate.EditValue = vacancy.DateFinish;
        }

        private void VacancyAddOrEdit_KeyDown(object sender, KeyEventArgs e)
        {
                switch (e.KeyCode)
                {
                    case Keys.Escape: //Закрыть форму
                        DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Close();
                        }
                        break;
                }
        }
    }
}
