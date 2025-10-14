﻿using Oracle.ManagedDataAccess.Client;
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
            this.StartPosition = FormStartPosition.CenterScreen;
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
            List<Route> routes = Route.getAllRouteDetails();
            if (cboEndRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a route to view details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Route selectedRoute = routes[cboEndRoute.SelectedIndex];

            string routeInfo = "Route ID: " + selectedRoute.getRouteID() + "\n\n" +
                                "Departure Airport: " + selectedRoute.getDepartureAirport() + "\n\n" +
                                "Arrival Airport: " + selectedRoute.getArrivalAirport() + "\n\n" +
                                "Ticket Price: " + selectedRoute.getTicketPrice() + "\n\n" +
                                "Duration: " + selectedRoute.getDuration() + "\n\n" +
                                "Status: " + selectedRoute.getStatus();

            lblEndRouteDetails.Font = new Font("Segoe UI", 12, FontStyle.Regular);
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
            }
        }
        private void frmEndRoute_Load(object sender, EventArgs e)
        {
            cboEndRoute.Items.Clear();

            List<Route> routes = Route.getRoutes();

            foreach (Route route in routes)
            {
                string routeInfo = route.getRouteID().ToString("D2") + "  " + route.getDepartureAirport() + " - " + route.getArrivalAirport();

                cboEndRoute.Items.Add(routeInfo);
            }
        }
    }
}