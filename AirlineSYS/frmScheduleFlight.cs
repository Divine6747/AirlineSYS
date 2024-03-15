using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineSYS;

namespace AirlineSYS
{
    public partial class frmScheduleFlight : Form
    {
        frmAirlineMainMenu parent;
        public frmScheduleFlight()
        {
            InitializeComponent();
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
            if (validateFlightUtility.validateFlightField(cboArrAirportFlight, cboDeptAirportFlight, cboOperatorCodeFlight.Text,txtNumFlightSeats.Text,txtTicketPriceFlight.Text,dtpDeptFlight.Value))
            {
                MessageBox.Show("Please fill all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Flight has been scheduled", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboArrAirportFlight.SelectedIndex = -1;
                cboDeptAirportFlight.SelectedIndex = -1;
                cboOperatorCodeFlight.SelectedIndex = -1;
                txtNumFlightSeats.Clear();
                dtpDeptFlight.Value = DateTime.Now;
                cboDeptTime.SelectedIndex = -1;
                txtTicketPriceFlight.Clear();
            }
        }
        private void cboOperatorCodeFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboOperatorCodeFlight.SelectedIndex != -1)
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

            //HashSetdoes not allow duplicate elements
            //It is going to store unique departureAirports and arrivalAirports(so filtering both airports)
            HashSet<string> departureAirports = new HashSet<string>();
            HashSet<string> arrivalAirports = new HashSet<string>();

            foreach (Route route in routes)
            {   //Contains is cheking if the airport been added is already in the combo box
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

        private void lblFlightsRouteIdDetails_Click(object sender, EventArgs e)
        {
            if (cboDeptAirportFlight.SelectedItem != null && cboArrAirportFlight.SelectedItem != null)
            {
                string dept = cboDeptAirportFlight.SelectedItem.ToString();
                string arr = cboArrAirportFlight.SelectedItem.ToString();
                Flight flight = new Flight();
                int routeID = flight.getRouteID(dept, arr);

                if (routeID != -1)
                {
                    lblFlightsRouteIdDetails.Text = routeID.ToString();
                    MessageBox.Show("Primary Key: " + routeID.ToString(), "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblFlightsRouteIdDetails.Text = "Not Found";
                    MessageBox.Show("No Primary Key found: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
