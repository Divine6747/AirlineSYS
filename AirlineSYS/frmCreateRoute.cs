﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class frmCreateRoute : Form
    {
        frmAirlineMainMenu parent;
        public frmCreateRoute()
        {
            InitializeComponent();
        }
        public frmCreateRoute(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmCreateRoute_Load(object sender, EventArgs e)
        {

        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }

        private void grpOperatorDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblOperatorPhone_Click(object sender, EventArgs e)
        {

        }
    }
}