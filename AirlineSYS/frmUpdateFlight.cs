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

            List<Operator> operators = Operator.getOperators();

           

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
                cboUpdateDeptAirportFlight.SelectedItem = route.getDepartureAirport();
                cboUpdateArrAirportFlight.SelectedItem = route.getArrivalAirport();
            }
            else
            {
                MessageBox.Show("Selected route details are not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            if (!UpdateFlightValidation.ValidateFields(cboUpdateDeptAirportFlight, cboUpdateArrAirportFlight, cboUpdateOperatorCodeFlight, cboUpdateDeptTime, txtUpdateNumFlightSeats.Text))
            {
                return;
            }

            string dept = cboUpdateDeptAirportFlight.SelectedItem.ToString();
            string arr = cboUpdateArrAirportFlight.SelectedItem.ToString();

            Route getRouteID = new Route();
            int routeID = getRouteID.getRouteID(dept, arr);

            if (routeID != -1)
            {
                Flight updateFlightSchedule = new Flight(lblUpdateFlightNumberDetail.Text, cboUpdateOperatorCodeFlight.SelectedItem.ToString(), int.Parse(lblUpdateFlightRouteIdDetails.Text), dtpUpdateDeptFlight.Value,
                                                    cboUpdateDeptTime.SelectedItem.ToString(), lblUpdateFlightEstArrTimeDetail.Text, int.Parse(txtUpdateNumFlightSeats.Text), int.Parse(txtUpdateNumFlightSeats.Text), "A");

                updateFlightSchedule.updateFlight(lblUpdateFlightNumberDetail.Text);

                MessageBox.Show(lblUpdateFlightNumberDetail.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

               /* MessageBox.Show("Route ID is: " + routeID.ToString() + "\n\n" +
                                lblUpdateFlightNumberDetail + "\n\n" +
                                cboUpdateOperatorCodeFlight.SelectedItem + "\n\n" +
                                txtUpdateNumFlightSeats.Text + "\n\n" +
                                dtpUpdateDeptFlight.Text + "\n\n" +
                                cboUpdateDeptTime.SelectedItem, "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

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

            List<Route> routes = Route.getRoutes();

            //Checking for duplicate elements to store unique departureAirports and arrivalAirports(so filtering both sets of airports)
            List<string> departureAirports = new List<string>();
            List<string> arrivalAirports = new List<string>();

            foreach (Route route in routes)
            {   //Contains is cheking if the airport being added is already in the combo box
                //https://learn.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-8.0
                if (!departureAirports.Contains(route.getDepartureAirport()))
                    departureAirports.Add(route.getDepartureAirport());

                if (!arrivalAirports.Contains(route.getArrivalAirport()))
                    arrivalAirports.Add(route.getArrivalAirport());
            }
            //https://www.tutorialspoint.com/merge-two-arrays-using-chash-addrange-method
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
            checkRoutExist();
            checkDuration();
            calculateEstArrTime();
            ReviewUpdateFlightDetails();
        }

        private void cboUpdateArrAirportFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkRoutExist();
            checkDuration();
            calculateEstArrTime();
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
            calculateEstArrTime();
        }
        private void calculateEstArrTime()
        {
            if (cboUpdateDeptTime.SelectedItem != null)
            {
                string selectedDeptTime = cboUpdateDeptTime.SelectedItem.ToString();

                int duration;
                if (int.TryParse(lblUpdateFlightRouteDurationDetail.Text, out duration))
                {
                    DateTime deptTime;
                    if (DateTime.TryParseExact(selectedDeptTime, "HH:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out deptTime))
                    {
                        DateTime estimatedArrivalTime = deptTime.AddMinutes(duration);
                        lblUpdateFlightEstArrTimeDetail.Text = estimatedArrivalTime.ToString("HH:mm tt", CultureInfo.InvariantCulture).ToUpper();
                    }
                }
                else
                {
                    // Handling the error When duration parsing fails
                    lblUpdateFlightEstArrTimeDetail.Text = "Cannot Be Calculated";
                }
            }
            else
            {
                lblUpdateFlightEstArrTimeDetail.Text = "Cannot Be Calculated";
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

        private void cboUpdateOperatorCodeFlight_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ReviewUpdateFlightDetails();
        }
    }
}
