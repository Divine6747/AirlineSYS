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
    public partial class frmCancelFlight : Form
    {
        frmAirlineMainMenu parent;

        public frmCancelFlight()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmCancelFlight(frmAirlineMainMenu parent)
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
            List<Flight> flights = Flight.getAllFlightDetails();

            if (cboCancelFlightNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flight to view details and cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Flight selectedFlight = flights[cboCancelFlightNumber.SelectedIndex];

            string flightInfo = "Flight Number: " + selectedFlight.getFlightNumber() + "\n\n" +
                                "Operator Code: " + selectedFlight.getOperatorCode() + "\n\n" +
                                "Route ID: " + selectedFlight.getRouteID() + "\n\n" +
                                "Departure Date: " + selectedFlight.getFlightDate().ToString("yyyy-MM-dd") + "\n\n" +
                                "Departure Time: " + selectedFlight.getFlightTime() + "\n\n" +
                                "Estimated Arrival Time: " + selectedFlight.getEstArrTime() + "\n\n" +
                                "Number of Seats: " + selectedFlight.getNumSeats() + "\n\n" +
                                "Number of Seats Available: " + selectedFlight.getNumSeatAvail() + "\n\n" +
                                "Status: " + selectedFlight.getStatus();

            lblCancelFlightDetails.Text = flightInfo;
            lblCancelFlightDetails.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblCancelFlightDetails.Location = new System.Drawing.Point(208, 31);
            btnCancelFlightConfirm.Visible = false;
            btnCancelFlightConfirm.Visible = true;
        }
        private void frmCancelFlight_Load(object sender, EventArgs e)
        {
            cboCancelFlightNumber.Items.Clear();
            btnCancelFlightConfirm.Visible = false;

            List<Flight> flights = Flight.getAllFlightDetails();

            foreach (Flight flight in flights)
            {
                cboCancelFlightNumber.Items.Add(flight.getFlightNumber());
            }

       }
        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            if (cboCancelFlightNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flight to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to cancel the flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string selectedFlightNumber = cboCancelFlightNumber.SelectedItem.ToString();

                Flight flight = new Flight();
                flight.cancelFlight(selectedFlightNumber);
            }
        }
    }
}
