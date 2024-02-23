using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class frmEndRoute : Form
    {

        frmAirlineMainMenu parent;

        public frmEndRoute()
        {
            InitializeComponent();
        }

        public frmEndRoute(frmAirlineMainMenu parent)
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

        private void btnRouteSearch_Click(object sender, EventArgs e)
        {
            // Fetch routes from the database
            List<Route> routes = Route.getAllRouteDetails();
            if (cboEndRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a route to view details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Route selectedRoute = routes[cboEndRoute.SelectedIndex];

            string routeInfo = "Route ID: " + selectedRoute.RouteID + "\n\n" +
                               "Departure Airport: " + selectedRoute.DepartureAirport + "\n\n" +
                               "Arrival Airport: " + selectedRoute.ArrivalAirport + "\n\n" +
                               "Ticket Price: " + selectedRoute.TicketPrice + "\n\n" +
                               "Duration: " + selectedRoute.Duration + "\n\n" +
                               "Status: " + selectedRoute.Status;

            lblEndRouteDetails.Text = routeInfo;
            grpEndRouteDetails.Visible = true;
            btnEndRouteConfirm.Visible = true;
        }

        private void btnEndRouteConfirm_Click(object sender, EventArgs e)
        {
            if (cboEndRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a route.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to end the route?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string selectedItem = cboEndRoute.SelectedItem.ToString();
                int routeID = int.Parse(selectedItem.Substring(0, selectedItem.IndexOf(" ")));

                Route route = new Route();
                route.endRoute(routeID);
                MessageBox.Show("Route has been ended in the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            grpEndRouteDetails.Visible = false;
        }


        private void frmEndRoute_Load(object sender, EventArgs e)
        {
            cboEndRoute.Items.Clear();

            btnEndRouteConfirm.Visible = false;

            List<Route> routes = Route.getRoutes();

            foreach (Route route in routes)
            {
                //This format includes leading zeros with the RouteID
                string routeInfo = route.RouteID.ToString("D2") + " " + route.DepartureAirport + " - " + route.ArrivalAirport;

                cboEndRoute.Items.Add(routeInfo);
            }

            lblEndRouteDetails.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        }

    }
}