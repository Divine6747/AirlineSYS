using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmCreateRoute(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }

        private void btnCreateRouteConfirm_Click(object sender, EventArgs e)
        {
            int duration;
            decimal ticketPrice;
            bool isValid = true;

            List<string> availAirports = Airport.getAvailAirports();

            if (string.IsNullOrEmpty(lblRouteID.Text) || string.IsNullOrEmpty(txtRouteDept.Text) ||
                string.IsNullOrEmpty(txtRouteArr.Text) || string.IsNullOrEmpty(txtRoutePrice.Text) ||
                string.IsNullOrEmpty(txtRouteDur.Text))
            {
                MessageBox.Show("All required fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (txtRouteDept.Text.Equals(txtRouteArr.Text) || txtRouteArr.Text.Equals(txtRouteDept.Text))
            {
                MessageBox.Show("Departure Airport and Arrival Airport cannot be the same.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (!int.TryParse(txtRouteDur.Text, out duration) || duration <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (!decimal.TryParse(txtRoutePrice.Text, out ticketPrice) || ticketPrice <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Ticket Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (!availAirports.Contains(txtRouteDept.Text))
            {
                MessageBox.Show("Departure airport is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (!availAirports.Contains(txtRouteArr.Text))
            {
                MessageBox.Show("Arrival airport is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (Route.doesRouteExist(txtRouteDept.Text, txtRouteArr.Text))
            {
                MessageBox.Show("Route is not valid. Alreary Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            Route route = new Route(Convert.ToInt32(lblRouteID.Text), txtRouteDept.Text, txtRouteArr.Text, Convert.ToDecimal(txtRoutePrice.Text), Convert.ToInt32(txtRouteDur.Text), "A");
            route.addRoute();

            lblRouteID.Text = Route.getNextRouteID().ToString("00");
            txtRouteDept.Clear();
            txtRouteArr.Clear();
            txtRoutePrice.Text = "0.00";
            txtRouteDur.Clear();
        }

        private void frmCreateRoute_Load(object sender, EventArgs e)
        {
            lblRouteID.Text = Route.getNextRouteID().ToString("00");
        }
    }
}
