﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormRemoveEmployee : Form
    {
        Store mb;
        Employee e;
        public FormRemoveEmployee(Store mb, Employee e)
        {
            InitializeComponent();
            this.mb = mb;
            this.e = e;

            lblEmployee.Text = $"{e.EmployeeID} - {e.FirstName} {e.LastName}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
