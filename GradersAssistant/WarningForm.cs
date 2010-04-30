﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradersAssistant
{
    public partial class WarningForm: Form
    {
        public string strWarningMessage;
        public WarningForm()
        {
            InitializeComponent();
        }

        private void buttonOkError_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarningForm_Load(object sender, EventArgs e)
        {
            labelErrorList.Text = strWarningMessage;
        }
    }
}
