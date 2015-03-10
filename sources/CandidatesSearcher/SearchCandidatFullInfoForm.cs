﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandidatesSearcher
{
    public partial class SearchCandidatFullInfoForm : Form
    { 
        CandidateSearchCommand command;
        CandidateSearchVievModel vm;
        int index;

        public SearchCandidatFullInfoForm(CandidateSearchVievModel vm, int index)
        {
            InitializeComponent();
            this.vm = vm;
            command = new CandidateSearchCommand(this.vm);
            this.index = index;
        }

        private void SearchCandidatFullInfoForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = vm.SortedCandidate;
            labelCandidateName.Text = vm.SortedCandidate[index].FirstName;
            labelCandidateSoname.Text = vm.SortedCandidate[index].LastName;
            labelCandidateCity.Text = vm.SortedCandidate[index].City;
            if(vm.SortedCandidate[index].Gender == HumanResourcesLibrary.DataClasses.Gender.Male)
                labelCandidateMale.Text = "Мужчина";
            else
                labelCandidateMale.Text = "Женщина";
            foreach(var item in vm.SortedCandidate[index].Phones)
            {
                listCandidatePhones.Text = item.PhoneNumber + "\n";
            }
            
        }
    }
}
