﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormViewEmployee : Form
    {
        Person p;
        public FormViewEmployee(Person p)
        {
            InitializeComponent();
            this.p = p;
        }
    }
}
