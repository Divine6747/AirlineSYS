using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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
            if (!validateFlightUtility.ValidateFlightField(cboUpdateDeptAirportFlight, cboUpdateArrAirportFlight, cboUpdateOperatorCodeFlight, int.Parse(txtUpdateNumFlightSeats.Text), dtpUpdateDeptFlight.Value, cboUpdateDeptTime, lblUpdateFlightEstArrTimeDetail.Text))
            {
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
                     cboUpdateDeptTime.SelectedItem.ToString(),lblUpdateFlightEstArrTimeDetail.Text, int.Parse(txtUpdateNumFlightSeats.Text),int.Parse(txtUpdateNumFlightSeats.Text), "A");

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
                string message = $"{flight.getFlightNumber()}";
                cboUpdateFlight.Items.Add(message);
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
        }
    }
}
