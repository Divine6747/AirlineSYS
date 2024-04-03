using System;
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
        public frmCreateBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Set the start position to center screen

        }
        public frmCreateBooking(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {

            

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
            //getting both dept and arr Airpor
            string deptAirport= cboDeptAirportBooking.SelectedItem.ToString();
            string arrAirport = cboArrAirportBooking.SelectedItem.ToString();

            //checking of both the dept and arr aiport were selected
            if (deptAirport != null && arrAirport != null)
            {
                //instance of Route
                Route route = new Route();

                //getting the routeId using the selected
                int routeID = route.getRouteID(deptAirport, arrAirport);

                if (routeID != -1)
                {
                    frmRetrievedFlightScheduled frmRetrievedFlightScheduled = new frmRetrievedFlightScheduled();
                    frmRetrievedFlightScheduled.Show();
                }
                else
                {
                    MessageBox.Show("Sorry but route does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select both departure and arrival airports and date of departure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
