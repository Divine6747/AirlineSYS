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

            string selectedFlightNumber = cboUpdateFlight.SelectedItem.ToString();

            // Get all flight details
            List<Flight> flights = Flight.getAllFlightDetails();

            // Search for the flight with the selected flight number
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

            // Displaying flight details
            lblUpdateFlightNumberDetail.Text = selectedFlight.getFlightNumber();
            lblUpdateFlightRouteIdDetails.Text = selectedFlight.getRouteID().ToString();
            lblUpdateFlightEstArrTimeDetail.Text = selectedFlight.getEstArrTime();
            cboUpdateOperatorCodeFlight.Text = selectedFlight.getOperatorCode();
            txtUpdateNumFlightSeats.Text = selectedFlight.getNumSeats().ToString();
            dtpUpdateDeptFlight.Value = selectedFlight.getFlightDate();
            cboUpdateDeptTime.Text = selectedFlight.getFlightTime();
            grpUpdateFlightDetails.Visible = true;
            btnUpdateFlightConfirm.Visible = true;
            grpViewUpdateFlightDetails.Visible = true;
            int routeID = Convert.ToInt32(lblUpdateFlightRouteIdDetails.Text);

            // Get departure and arrival airports using route ID
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
        //This is just a draft is update. Not edited from schedule flight yet
        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            if (cboUpdateDeptAirportFlight.SelectedItem == null || cboUpdateArrAirportFlight.SelectedItem == null || cboUpdateOperatorCodeFlight.SelectedItem == null || cboUpdateDeptTime.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtUpdateNumFlightSeats.Text))
            {
                MessageBox.Show("Please enter the number of flight seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numFlightSeats;
            if (!int.TryParse(txtUpdateNumFlightSeats.Text, out numFlightSeats) || numFlightSeats <= 0)
            {
                MessageBox.Show("Number of seats must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string dept = cboUpdateDeptAirportFlight.SelectedItem.ToString();

                string arr = cboUpdateArrAirportFlight.SelectedItem.ToString();

                Route getRouteID = new Route();

                int routeID = getRouteID.getRouteID(dept, arr);

                if (routeID != -1)
                {
                    Flight scheduleFlight = new Flight(lblUpdateFlightNumberDetail.Text, cboUpdateOperatorCodeFlight.SelectedItem.ToString(), int.Parse(lblUpdateFlightRouteIdDetails.Text), dtpUpdateDeptFlight.Value,
                     cboUpdateDeptTime.SelectedItem.ToString(), lblUpdateFlightEstArrTimeDetail.Text, int.Parse(txtUpdateNumFlightSeats.Text), int.Parse(txtUpdateNumFlightSeats.Text), "A");

                    MessageBox.Show("Route ID is: " + routeID.ToString() + "\n\n" +
                                     lblUpdateFlightNumberDetail + "\n\n" +
                                     cboUpdateOperatorCodeFlight.SelectedItem + "\n\n" +
                                     txtUpdateNumFlightSeats.Text + "\n\n" +
                                     dtpUpdateDeptFlight.Text + "\n\n" +
                                     cboUpdateDeptTime.SelectedItem, "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboUpdateArrAirportFlight.SelectedIndex = -1;
                    cboUpdateDeptAirportFlight.SelectedIndex = -1;
                    cboUpdateOperatorCodeFlight.SelectedIndex = -1;
                    txtUpdateNumFlightSeats.Clear();
                    dtpUpdateDeptFlight.Value = DateTime.Now;
                    cboUpdateDeptTime.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No RouteID Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void frmUpdateFlight_Load(object sender, EventArgs e)
        {
            grpUpdateFlightDetails.Visible = false;
            btnUpdateFlightConfirm.Visible = false;
            grpViewUpdateFlightDetails.Visible = false;
            cboUpdateFlight.Items.Clear();

            List<Flight> retrievedFlights = Flight.getAllFlightDetails();
            foreach (Flight flight in retrievedFlights)
            {
                cboUpdateFlight.Items.Add(flight.getFlightNumber());
            }

            List<Operator> operators = Operator.getOperators();

            foreach (Operator opCode in operators)
            {
                cboUpdateOperatorCodeFlight.Items.Add(opCode.getOperatorCode());
            }

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
            cboUpdateDeptAirportFlight.Items.AddRange(departureAirports.ToArray());

            cboUpdateArrAirportFlight.Items.AddRange(arrivalAirports.ToArray());

            List<FlightTimes> flightTimes = FlightTimes.getFlightTimes();

            foreach (FlightTimes flightTime in flightTimes)
            {
                cboUpdateDeptTime.Items.Add(flightTime.getFlightTime());                                            
            }
            
        }
        private void ReviewUpdateFlightDetails()
        {
            lblDateReview.Text = "";

            StringBuilder flightDetailsBuilder = new StringBuilder();

            if (!string.IsNullOrEmpty(lblUpdateFlightNumberDetail.Text))
            {
                flightDetailsBuilder.Append("Flight Number: ").Append(lblUpdateFlightNumberDetail.Text).Append("\n");
            }

            if (cboUpdateOperatorCodeFlight.SelectedItem != null)
            {
                flightDetailsBuilder.Append("Operator Code: ").Append(cboUpdateOperatorCodeFlight.SelectedItem.ToString()).Append("\n");
            }

            if (!string.IsNullOrEmpty(txtUpdateNumFlightSeats.Text))
            {
                flightDetailsBuilder.Append("Number of Seats: ").Append(txtUpdateNumFlightSeats.Text).Append("\n");
            }

            if (!string.IsNullOrEmpty(lblUpdateFlightRouteIdDetails.Text))
            {
                flightDetailsBuilder.Append("Route ID: ").Append(lblUpdateFlightRouteIdDetails.Text).Append("\n");
            }

            flightDetailsBuilder.Append("Departure Date: ").Append(dtpUpdateDeptFlight.Value.ToShortDateString()).Append("\n");

            if (cboUpdateDeptTime.SelectedItem != null)
            {
                flightDetailsBuilder.Append("Departure Time: ").Append(cboUpdateDeptTime.SelectedItem.ToString()).Append("\n");
            }

            if (!string.IsNullOrEmpty(lblUpdateFlightEstArrTimeDetail.Text))
            {
                flightDetailsBuilder.Append("Estimated Arrival Time: ").Append(lblUpdateFlightEstArrTimeDetail.Text).Append("\n");
            }

            if (cboUpdateDeptAirportFlight.SelectedItem != null)
            {
                flightDetailsBuilder.Append("Departure Airport: ").Append(cboUpdateDeptAirportFlight.SelectedItem.ToString()).Append("\n");
            }

            if (cboUpdateArrAirportFlight.SelectedItem != null)
            {
                flightDetailsBuilder.Append("Arrival Airport: ").Append(cboUpdateArrAirportFlight.SelectedItem.ToString()).Append("\n");
            }

            lblDateReview.Text = flightDetailsBuilder.ToString();
        }
        public bool checkRoutExist()
        {
            if (cboUpdateDeptAirportFlight.SelectedItem != null && cboUpdateArrAirportFlight.SelectedItem != null)
            {
                string dept = cboUpdateDeptAirportFlight.SelectedItem.ToString();
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
            if (!checkRoutExist())
            {
                cboUpdateDeptTime.SelectedIndex = -1;
                return;
            }
            checkDuration();
            ReviewUpdateFlightDetails();
        }

        private void cboUpdateArrAirportFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkRoutExist())
            {
                cboUpdateDeptTime.SelectedIndex = -1;
                return;
            }
            checkDuration();
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
            calculateEstArrTime();
            ReviewUpdateFlightDetails();
        }
        private void cboUpdateOperatorCodeFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUpdateOperatorCodeFlight.SelectedIndex != -1)
            {
                string selectedOperator = cboUpdateOperatorCodeFlight.SelectedItem.ToString();
                
                string currentFlightNumber = lblUpdateFlightNumberDetail.Text;
                
                string numericPart = currentFlightNumber.Substring(selectedOperator.Length);

                string newFlightNumber = selectedOperator + numericPart;

                lblUpdateFlightNumberDetail.Text = newFlightNumber;

                ReviewUpdateFlightDetails();
            }
        }
        private void calculateEstArrTime()
        {
            if (cboUpdateDeptTime.SelectedItem != null && lblUpdateFlightRouteDurationDetail.Text != "Did Not Retrieve")
            {
                string selectedDeptTime = cboUpdateDeptTime.SelectedItem.ToString();
                int duration = int.Parse(lblUpdateFlightRouteDurationDetail.Text);

                DateTime deptTime;

                if (DateTime.TryParseExact(selectedDeptTime, "HH:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out deptTime))
                {
                    DateTime estimatedArrivalTime = deptTime.AddMinutes(duration);

                    lblUpdateFlightEstArrTimeDetail.Text = estimatedArrivalTime.ToString("HH:mm tt", CultureInfo.InvariantCulture).ToUpper();
                }
            }
            else
            {
                lblUpdateFlightEstArrTimeDetail.Text = "Cannot Be Calculated"; // Display a message if estimated arrival time cannot be calculated
            }
        }
        private void checkDuration()
        {
            if (cboUpdateDeptAirportFlight.SelectedItem != null && cboUpdateArrAirportFlight.SelectedItem != null)
            {
                string dept = cboUpdateDeptAirportFlight.SelectedItem.ToString();
                string arr = cboUpdateArrAirportFlight.SelectedItem.ToString();

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
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
