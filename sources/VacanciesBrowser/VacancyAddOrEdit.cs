using HumanResourcesLibrary.DataClasses;
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
    public partial class VacancyAddOrEdit : Form
    {
        public VacancyAddOrEdit()
        {
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
            Vacancy vacancy = new Vacancy();
            // Download to DataBase
            MessageBox.Show("Вакансия сохранена");
            this.Close();
        }

    }
}
