using System;
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
    public partial class frmAirlineMainMenu : Form
    {
        frmAirlineMainMenu parent;
        public frmAirlineMainMenu()
        {
            InitializeComponent();
        }
        public frmAirlineMainMenu(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuEndRoute_Click_1(object sender, EventArgs e)
        {
            frmEndRoute frmAirlineMainMenu = new frmEndRoute();
            this.Hide();
            frmAirlineMainMenu.Show();
        }


        private void mnuScheduleFlight_Click_1(object sender, EventArgs e)
        {
            frmScheduleFlight frmAirlineMainMenu = new frmScheduleFlight();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuUpdateFlight_Click_1(object sender, EventArgs e)
        {
            frmUpdateFlight frmAirlineMainMenu = new frmUpdateFlight();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuCancelFlight_Click_1(object sender, EventArgs e)
        {
            frmCancelFlight frmAirlineMainMenu = new frmCancelFlight();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuCreateBooking_Click_1(object sender, EventArgs e)
        {
            frmCreateBooking frmAirlineMainMenu = new frmCreateBooking();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuUpdateBooking_Click_1(object sender, EventArgs e)
        {
            frmUpdateBooking frmAirlineMainMenu = new frmUpdateBooking();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuCancelBooking_Click_1(object sender, EventArgs e)
        {
            frmCancelBooking frmAirlineMainMenu = new frmCancelBooking();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuAddAirport_Click_1(object sender, EventArgs e)
        {
            frmAddAirport frmAirlineMainMenu = new frmAddAirport();
            this.Hide();
            frmAirlineMainMenu.Show();
        }
        private void mnuAddOperator_Click_1(object sender, EventArgs e)
        {
            frmAddOperator frmAirlineMainMenu = new frmAddOperator();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuCreateRoute_Click_1(object sender, EventArgs e)
        {
            frmCreateRoute frmAirlineMainMenu = new frmCreateRoute();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuYearFlightAnalysis_Click(object sender, EventArgs e)
        {
            frmYearlyFlightAnalysis frmAirlineMainMenu = new frmYearlyFlightAnalysis();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuYearRevenue_Click(object sender, EventArgs e)
        {
            frmYearlyRevenueAnalysis frmAirlineMainMenu = new frmYearlyRevenueAnalysis();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void mnuYearRouteAnalysis_Click(object sender, EventArgs e)
        {
            frmYearlyRouteAnalysis frmAirlineMainMenu = new frmYearlyRouteAnalysis();
            this.Hide();
            frmAirlineMainMenu.Show();
        }

        private void munUpdateAirport_Click(object sender, EventArgs e)
        {
            frmUpdateAiport frmUpdateAirport = new frmUpdateAiport();
            this.Hide();
            frmUpdateAirport.Show();
        }



        private void munExit_Click_1(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }
}
