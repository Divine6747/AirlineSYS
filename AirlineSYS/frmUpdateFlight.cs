using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
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
            List<Flight> flights = Flight.getAllFlightDetails();
            if (cboUpdateFlight.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flight to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Flight selectedFlight = flights[cboUpdateFlight.SelectedIndex];
            lblUpdateFlightNumberDetail.Text = selectedFlight.getFlightNumber();
            lblUpdateFlightRouteIdDetails.Text = selectedFlight.getRouteID().ToString();
            lblUpdateFlightEstArrTimeDetail.Text = selectedFlight.getEstArrTime();
            //cboUpdateDeptAirportFlight.Text = selectedFlight.get
           // cboUpdateArrAirportFlight
            cboUpdateOperatorCodeFlight.Text = selectedFlight.getOperatorCode();
            txtUpdateNumFlightSeats.Text = selectedFlight.getNumSeats().ToString();
            dtpUpdateDeptFlight.Text = selectedFlight.getFlightDate().ToString();
            cboUpdateDeptTime.Text = selectedFlight.getFlightTime();
            //txtUpdateTicketPriceFlight.Text = selectedFlight.get
            grpUpdateFlightDetails.Visible = true;
            btnUpdateFlightConfirm.Visible = true;
            grpViewUpdateFlightDetails.Visible = true;

        }
        //This is just a draft is update. Not edited from schedule flight yet
        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            if (!validateFlightUtility.ValidateFlightField(cboUpdateDeptAirportFlight, cboUpdateArrAirportFlight, cboUpdateOperatorCodeFlight.Text, txtUpdateNumFlightSeats.Text, txtUpdateTicketPriceFlight.Text, dtpUpdateDeptFlight.Value, cboUpdateDeptTime))
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
                    Flight scheduleFlight = new Flight(lblUpdateFlightNumberDetail.Text, cboUpdateOperatorCodeFlight.SelectedItem.ToString(),
                              int.Parse(lblUpdateFlightRouteIdDetails.Text), dtpUpdateDeptFlight.Value, cboUpdateDeptTime.SelectedItem.ToString(),
                              lblUpdateFlightEstArrTimeDetail.Text, int.Parse(txtUpdateNumFlightSeats.Text), int.Parse(txtUpdateNumFlightSeats.Text), "A");
                    scheduleFlight.scheduleFlight();

                    MessageBox.Show("Route ID is: " + routeID.ToString() + "\n\n" +
                                     lblUpdateFlightNumberDetail + "\n\n" +
                                     cboUpdateOperatorCodeFlight.SelectedItem + "\n\n" +
                                     txtUpdateNumFlightSeats.Text + "\n\n" +
                                     txtUpdateTicketPriceFlight.Text + "\n\n" +
                                     dtpUpdateDeptFlight.Text + "\n\n" +
                                     cboUpdateDeptTime.SelectedItem, "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboUpdateArrAirportFlight.SelectedIndex = -1;
                    cboUpdateDeptAirportFlight.SelectedIndex = -1;
                    cboUpdateOperatorCodeFlight.SelectedIndex = -1;
                    txtUpdateNumFlightSeats.Clear();
                    dtpUpdateDeptFlight.Value = DateTime.Now;
                    cboUpdateDeptTime.SelectedIndex = -1;
                    txtUpdateTicketPriceFlight.Clear();
                    txtUpdateTicketPriceFlight.Text = "0.00";
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

            List<Flight> retrievedFlights = Flight.retrievingScheduledFlights();

            foreach (Flight flight in retrievedFlights)
            {
                string message = $"{flight.FlightNumber2}   {flight.DepartureAirport} - {flight.ArrivalAirport}";
                cboUpdateFlight.Items.Add(message);
            }
        }
    }
}
