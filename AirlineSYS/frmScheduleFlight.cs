﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class frmScheduleFlight : Form
    {
        frmAirlineMainMenu parent;
        public frmScheduleFlight()
        {
            InitializeComponent();
            cboDeptAirportFlight.SelectedIndexChanged += cboDeptAirportFlight_SelectedIndexChanged;
            cboDeptTime.SelectedIndexChanged += cboDeptTime_SelectedIndexChanged;
        }
        public frmScheduleFlight(frmAirlineMainMenu parent)
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
        private void btnFlightConfirm_Click(object sender, EventArgs e)
        {
            if (!validateFlightUtility.ValidateFlightField(cboDeptAirportFlight, cboArrAirportFlight, cboOperatorCodeFlight.Text, txtNumFlightSeats.Text, txtTicketPriceFlight.Text, dtpDeptFlight.Value, cboDeptTime))
            {
                return;
            }
            else
            {
                string dept = cboDeptAirportFlight.SelectedItem.ToString();

                string arr = cboArrAirportFlight.SelectedItem.ToString();

                Route getRouteID = new Route();

                int routeID = getRouteID.getRouteID(dept, arr);

                if (routeID != -1)
                {
                    MessageBox.Show("Flight has been scheduled", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Route ID is: " + routeID.ToString() + "\n\n" +
                                     lblFlightNumberDetail + "\n\n" +
                                     cboOperatorCodeFlight.SelectedItem + "\n\n" +
                                     txtNumFlightSeats.Text + "\n\n" +
                                     txtTicketPriceFlight.Text + "\n\n" +
                                     dtpDeptFlight.Text + "\n\n" +
                                     cboDeptTime.SelectedItem, "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboArrAirportFlight.SelectedIndex = -1;
                    cboDeptAirportFlight.SelectedIndex = -1;
                    cboOperatorCodeFlight.SelectedIndex = -1;
                    txtNumFlightSeats.Clear();
                    dtpDeptFlight.Value = DateTime.Now;
                    cboDeptTime.SelectedIndex = -1;
                    txtTicketPriceFlight.Clear();
                    txtTicketPriceFlight.Text = "0.00";
                }
                else
                {
                    MessageBox.Show("No RouteID Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboOperatorCodeFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOperatorCodeFlight.SelectedIndex != -1)
            {
                string selectedOperator = cboOperatorCodeFlight.SelectedItem.ToString();

                string increflightNumber = Flight.getFlightNumber(selectedOperator);

                int numericPart = int.Parse(increflightNumber.Substring(selectedOperator.Length));

                int nextFlightNumberPart = numericPart;

                string nextFlightNumber = selectedOperator + nextFlightNumberPart.ToString("D4");

                lblFlightNumberDetail.Text = nextFlightNumber;
            }
        }
        private void frmScheduleFlight_Load(object sender, EventArgs e)
        {
            cboOperatorCodeFlight.Items.Clear();
            cboDeptAirportFlight.Items.Clear();
            cboArrAirportFlight.Items.Clear();
            cboDeptTime.Items.Clear();

            List<Operator> operators = Operator.getOperators();

            foreach (Operator opCode in operators)
            {
                cboOperatorCodeFlight.Items.Add(opCode.getOperatorCode());
            }

            cboOperatorCodeFlight.SelectedIndexChanged += cboOperatorCodeFlight_SelectedIndexChanged;

            List<Route> routes = Route.getRoutes();
            //Checking for duplicate elements to store unique departureAirports and arrivalAirports(so filtering both sets of airports)
            List<string> departureAirports = new List<string>();
            List<string> arrivalAirports = new List<string>();

            foreach (Route route in routes)
            {   //Contains is cheking if the airport being added is already in the combo box
                if (!departureAirports.Contains(route.getDepartureAirport()))
                    departureAirports.Add(route.getDepartureAirport());

                if (!arrivalAirports.Contains(route.getArrivalAirport()))
                    arrivalAirports.Add(route.getArrivalAirport());
            }

            cboDeptAirportFlight.Items.AddRange(departureAirports.ToArray());

            cboArrAirportFlight.Items.AddRange(arrivalAirports.ToArray());

            List<FlightTimes> times = FlightTimes.getFlightTimes();

            foreach (FlightTimes time in times)
            {
                cboDeptTime.Items.Add(time.getFlightTime());
            }
        }
        public bool checkRoutExist()
        {
            if (cboDeptAirportFlight.SelectedItem != null && cboArrAirportFlight.SelectedItem != null)
            {
                string dept = cboDeptAirportFlight.SelectedItem.ToString();
                string arr = cboArrAirportFlight.SelectedItem.ToString();
                Route checkRoutExist = new Route();
                int routeID = checkRoutExist.getRouteID(dept, arr);

                if (routeID != -1)
                {                    
                    lblRouteIdDetails.Text = routeID.ToString();
                    MessageBox.Show("Route ID is: " + routeID.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    lblRouteIdDetails.Text = "does not exist";
                    MessageBox.Show("Route does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void cboDeptAirportFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkRoutExist();
            checkDuration();
        }
        private void cboArrAirportFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkRoutExist();
            checkDuration();
        }
        private void checkDuration()
        {
            if (cboDeptAirportFlight.SelectedItem != null && cboArrAirportFlight.SelectedItem != null)
            {
                string dept = cboDeptAirportFlight.SelectedItem.ToString();
                string arr = cboArrAirportFlight.SelectedItem.ToString();

                Route route = new Route();
                int duration = route.getDuration(dept, arr);

                if (duration != -1)
                {
                    lbRouteDuration.Text = duration.ToString();
                }
                else
                {
                    lbRouteDuration.Text = "Not found";
                }
            }
        }
        private void calculateEstArrTime()
        {
            if (cboDeptTime.SelectedItem != null && lbRouteDuration.Text != "Not found")
            {
                string selectedDeptTime = cboDeptTime.SelectedItem.ToString();
                int duration = int.Parse(lbRouteDuration.Text);

                DateTime deptTime;

                DateTime.TryParseExact(selectedDeptTime, "hh:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out deptTime);

                DateTime estimatedArrivalTime = deptTime.AddMinutes(duration);

                lblEstArrTimeDetail.Text = estimatedArrivalTime.ToString("hh:mm tt");
            
            }
            else
            {
                lblEstArrTimeDetail.Text = "cannot be calculated";
            }
        }

        private void cboDeptTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateEstArrTime();
        }

        private void grpAirportDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}