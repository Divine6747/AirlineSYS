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

        public frmCreateBooking(string flightNumber, string deptAirport, string arrAirport, DateTime flightDate, string flightTime, int numBaggage)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //Passing Selected Data Grid View in these variables
            this.flightNumber = flightNumber;
            this.deptAirport = deptAirport;
            this.arrAirport = arrAirport;
            this.flightDate = flightDate;
            this.flightTime = flightTime;
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
            nudNumBaggage.Value = numBaggage;
        }
        //RefreshFlightInfo() saves the previously selected flight, if user decided to to book another flight but changed their mind
        public void RefreshFlightInfo(string flightNumber, string deptAirport, string arrAirport, DateTime flightDate, string flightTime, int numBaggage)
        {
            this.flightNumber = flightNumber;
            this.deptAirport = deptAirport;
            this.arrAirport = arrAirport;
            this.flightDate = flightDate;
            this.flightTime = flightTime;
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

            }
            else
            {
                nudNumBaggage.Visible = true;
                lblNumBaggage.Visible = true;
                numBaggage = 0;
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

        List<string> check2 = new List<string>();        
        
        private void frmCreateBooking_Load(object sender, EventArgs e)
        {
            List<Route> routes = Route.getRoutes();

            //Checking for duplicate elements to store unique departureAirports and arrivalAirports(so filtering both sets of airports)
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
                    //Passing routeID to frmRetrievedFlightScheduled constructor
                    frmRetrievedFlightScheduled frmRetrievedFlightScheduled = new frmRetrievedFlightScheduled(this.parent, routeID,flightNumber,deptAirport,arrAirport,flightDate,flightTime, numBaggage);
                    frmRetrievedFlightScheduled.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sorry, but route route you choose to go does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select both departure and arrival airports and date of departure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookingFlightConfirm_Click(object sender, EventArgs e)
        {
            // Check if any label is empty
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
            frmBookingPersonalDetails frmBookingPersonalData = new frmBookingPersonalDetails(flightNumber, deptAirport, arrAirport, flightDate, flightTime, numBaggage.ToString());

            frmBookingPersonalData.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
