using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirlineSYS
{
    public partial class frmCreateBooking : Form
    {
        frmAirlineMainMenu parent;
        //Class level
        private string flightNumber;
        private string deptAirport;
        private string arrAirport;
        private DateTime flightDate;
        private string flightTime;
        private string estArrTime;
        private int numBaggage;
        public Label labelNumBaggage
        {
            get
            {
                return lblNumBaggage;
            }
        }
        public NumericUpDown numericUpDownNumBaggage
        {
            get
            {
                return nudNumBaggage;
            }
        }
        public Label deptDate
        {
            get
            {
                return lblFlightDateDetails;
            }
        }
        public System.Windows.Forms.Button Confirm => btnBookingFlightConfirm;

        public frmCreateBooking(string flightNumber, string deptAirport, string arrAirport, DateTime flightDate, string flightTime, string estArrTime, int numBaggage)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //Passing Selected Data Grid View in these variables
            this.flightNumber = flightNumber;
            this.deptAirport = deptAirport;
            this.arrAirport = arrAirport;
            this.flightDate = flightDate;
            this.flightTime = flightTime;
            this.estArrTime = estArrTime;
            this.numBaggage = numBaggage;

            PopulateFlightInfo();
            baggage();
        }

        private void PopulateFlightInfo()
        {
            //Putting the Data Grid View data in labels
            lblFlightNumberDetail.Text = flightNumber;
            lblDeptAirportDetail.Text = deptAirport;
            lblArrAirportDetail.Text = arrAirport;
            lblFlightDateDetails.Text = flightDate.ToString("dd-MMM-yyyy");
            lblFlightTimedetail.Text = flightTime;
            lblEstArrTimeDetails.Text = estArrTime;
            nudNumBaggage.Value = numBaggage;
        }
        //RefreshFlightInfo() saves the previously selected flight, if user decided to to book another flight but changed their mind
        public void RefreshFlightInfo(string flightNumber, string deptAirport, string arrAirport, DateTime flightDate, string flightTime, string estArrTime, int numBaggage)
        {
            this.flightNumber = flightNumber;
            this.deptAirport = deptAirport;
            this.arrAirport = arrAirport;
            this.flightDate = flightDate;
            this.flightTime = flightTime;
            this.estArrTime = estArrTime;
            this.numBaggage = numBaggage;
            nudNumBaggage.Value = numBaggage;
            PopulateFlightInfo();
        }
        private void baggage()
        {
            DialogResult baggageConfirm = MessageBox.Show("Will you bring baggage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (baggageConfirm == DialogResult.Yes)
            {
                nudNumBaggage.Visible = true;
                lblNumBaggage.Visible = true;
                numBaggage = (int)nudNumBaggage.Value;
                nudNumBaggage.Value = 1;
            }
            else
            {
                nudNumBaggage.Visible = true;
                lblNumBaggage.Visible = true;
                numBaggage = (int)nudNumBaggage.Value;
                nudNumBaggage.Value = 0;
            }
        }
        public frmCreateBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmCreateBooking(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }
        private void frmCreateBooking_Load(object sender, EventArgs e)
        {
            List<Route> routes = Route.getRoutes();

            //Filtering both sets of airports duplicate elements to store unique departureAirports and arrivalAirports(so )
            List<string> departureAirports = new List<string>();

            List<string> arrivalAirports = new List<string>();

            foreach (Route route in routes)
            {
                //Contains is cheking if the airport being added is already in the combo box
                if (!departureAirports.Contains(route.getDepartureAirport()))

                    departureAirports.Add(route.getDepartureAirport());

                if (!arrivalAirports.Contains(route.getArrivalAirport()))

                    arrivalAirports.Add(route.getArrivalAirport());
            }

            cboDeptAirportBooking.Items.AddRange(departureAirports.ToArray());

            cboArrAirportBooking.Items.AddRange(arrivalAirports.ToArray());
        }

        private void btnUpdateFlightSearch_Click(object sender, EventArgs e)
        {
            string deptAirport = null;
            string arrAirport = null;

            if (cboDeptAirportBooking.SelectedItem != null)
            {
                deptAirport = cboDeptAirportBooking.SelectedItem.ToString();
            }

            if (cboArrAirportBooking.SelectedItem != null)
            {
                arrAirport = cboArrAirportBooking.SelectedItem.ToString();
            }

            //checking if both the dept and arr airport were selected
            if (!string.IsNullOrEmpty(deptAirport) && !string.IsNullOrEmpty(arrAirport))
            {
                Route route = new Route();

                //getting the routeId using the selected airports
                int routeID = route.getRouteID(deptAirport, arrAirport);

                if (routeID != -1)
                {
                    // Check if flights are available for the specified route ID
                    List<string[]> availableFlights = Flight.getAvailableFlights(routeID);

                    if (availableFlights.Count == 0)
                    {
                        MessageBox.Show("No flights found for the specified route.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Passing routeID to frmRetrievedFlightScheduled constructor
                        frmRetrievedFlightScheduled frmRetrievedFlightScheduled = new frmRetrievedFlightScheduled(parent, routeID, flightNumber, deptAirport, arrAirport, flightDate, flightTime, estArrTime, numBaggage);
                        frmRetrievedFlightScheduled.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, but the route you selected does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select both departure and arrival airports.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBookingFlightConfirm_Click(object sender, EventArgs e)
        {
            //Checking if any labels are empty
            if (string.IsNullOrWhiteSpace(lblFlightNumberDetail.Text) ||
                string.IsNullOrWhiteSpace(lblDeptAirportDetail.Text) ||
                string.IsNullOrWhiteSpace(lblArrAirportDetail.Text) ||
                string.IsNullOrWhiteSpace(lblFlightDateDetails.Text) ||
                string.IsNullOrWhiteSpace(lblFlightTimedetail.Text))
            {
                MessageBox.Show("Please select a flight before confirming.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            numBaggage = (int)nudNumBaggage.Value;
            frmBookingPersonalDetails frmBookingPersonalData = new frmBookingPersonalDetails(flightNumber, deptAirport, arrAirport, flightDate, flightTime, estArrTime, numBaggage.ToString());
            
            frmBookingPersonalData.Show();
            this.Close();
   
        }
    }
}
