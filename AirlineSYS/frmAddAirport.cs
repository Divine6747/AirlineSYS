using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class frmAddAirport : Form
    {
        frmAirlineMainMenu parent;
        public frmAddAirport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmAddAirport(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }

        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            if (!ValidateAirportDetails.ValidateAirportFields(txtAirportCode.Text, txtAirportName.Text, txtAirportStreet.Text, txtAirportCity.Text, txtAirportCountry.Text, txtAirportEircode.Text, txtAirportPhone.Text, txtAirportEmail.Text))
            {
                return;
            }
            else
            {
                Airport anAirport = new Airport(txtAirportCode.Text,txtAirportName.Text, txtAirportStreet.Text, txtAirportCity.Text, txtAirportCountry.Text, 
                                                txtAirportEircode.Text,txtAirportPhone.Text,txtAirportEmail.Text);

                anAirport.addAirport();

                txtAirportCode.Clear();
                txtAirportName.Clear();
                txtAirportStreet.Clear();
                txtAirportCity.Clear();
                txtAirportCountry.Clear();
                txtAirportEircode.Clear();
                txtAirportPhone.Clear();
                txtAirportEmail.Clear();
            }
        }
    }
}
