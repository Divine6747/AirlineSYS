using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirlineSYS
{
    public partial class frmUpdateFlight : Form
    {
        frmAirlineMainMenu parent;
        public frmUpdateFlight()
        {
            InitializeComponent();
        }
        public frmUpdateFlight(frmAirlineMainMenu parent)
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
        private void btnFlightSearch_Click(object sender, EventArgs e)
        {
            if (cboUpdateFlight.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid flight to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gets the selected flightNumber
            string selectedFlightNumber = cboUpdateFlight.SelectedItem.ToString();

            List<Flight> flights = Flight.getAllFlightDetails();
           

            // Searching for the flight with the selected flight number
            Flight selectedFlight = null;

            foreach (Flight flight in flights)
            {
                if (flight.getFlightNumber() == selectedFlightNumber)
                {
                    selectedFlight = flight;
                    break;
                }
            }

            if (selectedFlight == null)
            {
                MessageBox.Show("Selected flight details are not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblUpdateFlightNumberDetail.Text = selectedFlight.getFlightNumber().ToString();
            lblUpdateFlightRouteIdDetails.Text = selectedFlight.getRouteID().ToString();
            lblUpdateFlightEstArrTimeDetail.Text = selectedFlight.getEstArrTime();
            cboUpdateOperatorCodeFlight.Text = selectedFlight.getOperatorCode();
            txtUpdateNumFlightSeats.Text = selectedFlight.getNumSeats().ToString();
            dtpUpdateDeptFlight.Value = selectedFlight.getFlightDate();
            cboUpdateDeptTime.SelectedItem = selectedFlight.getFlightTime();
            grpUpdateFlightDetails.Visible = true;
            btnUpdateFlightConfirm.Visible = true;
            grpViewUpdateFlightDetails.Visible = true;

            // Get dept and arr airports using routeID
            int routeID = Convert.ToInt32(lblUpdateFlightRouteIdDetails.Text);
            Route route = Route.getAirportsByID(routeID);

            if (route != null)
            {
                cboUpdateDeptAirportFlight.Text = route.getDepartureAirport();
                cboUpdateArrAirportFlight.Text = route.getArrivalAirport();
            }
            else
            {
                MessageBox.Show("Selected route details are not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmUpdateFlight_Load(object sender, EventArgs e)
        {
            grpUpdateFlightDetails.Visible = false;
            btnUpdateFlightConfirm.Visible = false;
            grpViewUpdateFlightDetails.Visible = false;
            cboUpdateFlight.Items.Clear();
            cboUpdateDeptTime.Items.Clear();

            List<Flight> retrievedFlights = Flight.getAllFlightDetails();
            foreach (Flight flight in retrievedFlights)
            {
                cboUpdateFlight.Items.Add(flight.getFlightNumber());
            }

            List<FlightTimes> flightTimes = FlightTimes.getFlightTimes();

            foreach (FlightTimes flightTime in flightTimes)
            {
                cboUpdateDeptTime.Items.Add(flightTime.getFlightTime());                                            
            }

        }
        private void ReviewUpdateFlightDetails()
        {
            //https://codebuns.com/csharp-basics/stringbuilder/#:~:text=C%23%20StringBuilder%20Append%20method%20appends,of%20the%20current%20StringBuilder%20object.&text=Note%3A%20The%20capacity%20of%20the,append%20to%20add%20more%20strings.
            lblDateReview.Text = "";

            StringBuilder flightDetails = new StringBuilder();

            if (!string.IsNullOrEmpty(lblUpdateFlightNumberDetail.Text))
            {
                flightDetails.Append("Flight Number: ").Append(lblUpdateFlightNumberDetail.Text).Append("\n");
            }

            if (cboUpdateOperatorCodeFlight.SelectedItem != null)
            {
                flightDetails.Append("Operator Code: ").Append(cboUpdateOperatorCodeFlight.SelectedItem.ToString()).Append("\n");
            }

            if (!string.IsNullOrEmpty(txtUpdateNumFlightSeats.Text))
            {
                flightDetails.Append("Number of Seats: ").Append(txtUpdateNumFlightSeats.Text).Append("\n");
            }

            if (!string.IsNullOrEmpty(lblUpdateFlightRouteIdDetails.Text))
            {
                flightDetails.Append("Route ID: ").Append(lblUpdateFlightRouteIdDetails.Text).Append("\n");
            }

            flightDetails.Append("Departure Date: ").Append(dtpUpdateDeptFlight.Value.ToShortDateString()).Append("\n");

            if (cboUpdateDeptTime.SelectedItem != null)
            {
                flightDetails.Append("Departure Time: ").Append(cboUpdateDeptTime.SelectedItem.ToString()).Append("\n");
            }

            if (!string.IsNullOrEmpty(lblUpdateFlightEstArrTimeDetail.Text))
            {
                flightDetails.Append("Estimated Arrival Time: ").Append(lblUpdateFlightEstArrTimeDetail.Text).Append("\n");
            }

            if (cboUpdateDeptAirportFlight.SelectedItem != null)
            {
                flightDetails.Append("Departure Airport: ").Append(cboUpdateDeptAirportFlight.SelectedItem.ToString()).Append("\n");
            }

            if (cboUpdateArrAirportFlight.SelectedItem != null)
            {
                flightDetails.Append("Arrival Airport: ").Append(cboUpdateArrAirportFlight.SelectedItem.ToString()).Append("\n");
            }

            lblDateReview.Text = flightDetails.ToString();
        }
        public bool checkRoutExist()
        {
            if (cboUpdateDeptAirportFlight.SelectedItem != null && cboUpdateArrAirportFlight.SelectedItem != null)
            {
                string dept = cboUpdateDeptAirportFlight.Text.ToString();
                string arr = cboUpdateArrAirportFlight.SelectedItem.ToString();
                Route checkRoutExist = new Route();
                int routeID = checkRoutExist.getRouteID(dept, arr);

                if (routeID != -1)
                {
                    lblUpdateFlightRouteIdDetails.Text = routeID.ToString();
                    cboUpdateDeptTime.Enabled = true;
                    return true;
                }
                else
                {
                    lblUpdateFlightRouteIdDetails.Text = "Does Not Exist";
                    lblUpdateFlightRouteDurationDetail.Text = "Not Retrieved";
                    lblUpdateFlightEstArrTimeDetail.Text = "Cannot Be Calculated";
                    cboUpdateDeptTime.Enabled = false;
                    return false;
                }
            }
            cboUpdateDeptTime.Enabled = false;
            return false;
        }
        private void cboUpdateDeptAirportFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkRoutExist();
            checkDuration();
            ReviewUpdateFlightDetails();
        }

        private void cboUpdateArrAirportFlight_SelectedIndexChanged(object sender, EventArgs e)
        {

            ReviewUpdateFlightDetails();
        }

        private void dtpUpdateDeptFlight_ValueChanged(object sender, EventArgs e)
        {
            ReviewUpdateFlightDetails();
        }

        private void txtUpdateNumFlightSeats_TextChanged(object sender, EventArgs e)
        {
            ReviewUpdateFlightDetails();
        }
        private void cboUpdateDeptTime_SelectedIndexChanged(object sender, EventArgs e)
        {            
            ReviewUpdateFlightDetails();
        }
        
        private void checkDuration()
        {
            if (cboUpdateDeptAirportFlight.Text != "" && cboUpdateArrAirportFlight.Text != "")
            {
                string dept = cboUpdateDeptAirportFlight.Text;
                string arr = cboUpdateArrAirportFlight.Text;

                Route route = new Route();
                int duration = route.getDuration(dept, arr);

                if (duration != -1)
                {
                    lblUpdateFlightRouteDurationDetail.Text = duration.ToString();
                }
                else
                {
                    lblUpdateFlightRouteDurationDetail.Text = "Does Not Retrieve";
                    cboUpdateDeptTime.Enabled = false;
                }
            }
        }

        private void cboUpdateOperatorCodeFlight_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ReviewUpdateFlightDetails();
        }

        private void btnUpdateFlightConfirm_Click(object sender, EventArgs e)
        {
            if (!UpdateFlightValidation.ValidateFlightField(int.Parse(txtUpdateNumFlightSeats.Text), dtpUpdateDeptFlight.Value, cboUpdateDeptTime, lblUpdateFlightEstArrTimeDetail.Text))
            {
                return;
            }
            string dept = cboUpdateDeptAirportFlight.Text;
            string arr = cboUpdateArrAirportFlight.Text;

            Route getRouteID = new Route();
            int routeID = getRouteID.getRouteID(dept, arr);

            if (routeID != -1)
            {
                // Create updateFlightSchedule only if all necessary values are available
                Flight updateFlightSchedule = new Flight(lblUpdateFlightNumberDetail.Text, cboUpdateOperatorCodeFlight.Text, routeID, dtpUpdateDeptFlight.Value,
                    cboUpdateDeptTime.Text, lblUpdateFlightEstArrTimeDetail.Text, int.Parse(txtUpdateNumFlightSeats.Text), int.Parse(txtUpdateNumFlightSeats.Text), "A");

                // Call updateFlight method
                updateFlightSchedule.updateFlight(lblUpdateFlightNumberDetail.Text);

                MessageBox.Show("Flight details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear controls
                cboUpdateArrAirportFlight.SelectedIndex = -1;
                cboUpdateDeptAirportFlight.SelectedIndex = -1;
                cboUpdateOperatorCodeFlight.SelectedIndex = -1;
                txtUpdateNumFlightSeats.Clear();
                cboUpdateDeptTime.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No RouteID Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboUpdateDeptAirportFlight_TextChanged(object sender, EventArgs e)
        {
            checkRoutExist();
            checkDuration();
        }

        private void cboUpdateArrAirportFlight_TextChanged(object sender, EventArgs e)
        {
            checkRoutExist();
            checkDuration();
        }
    }
}
