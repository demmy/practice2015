﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CandidatesParser.CandidateForms
{
    public partial class CandidatesParserWriterDataBase : DevExpress.XtraEditors.XtraForm
    {

        public CandidatesParserWriterDataBase()
        {
            InitializeComponent();
        }

        private void form3_Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}