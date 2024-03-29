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
            if (txtUpdateFlightNumber.Text.Length == 6 && (txtUpdateFlightNumber.Text != "AA4732" && txtUpdateFlightNumber.Text != "JL8915" &&
                txtUpdateFlightNumber.Text != "EK2468" && txtUpdateFlightNumber.Text != "BA5739"))
            {
                MessageBox.Show("Flight number does not exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateFlightNumber.Focus();
                txtUpdateFlightNumber.Clear();
                return;
            }
            else if (txtUpdateFlightNumber.Text.Length != 6)
            {
                MessageBox.Show("Flight Number must be 6 characters long", "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateFlightNumber.Focus();
                txtUpdateFlightNumber.Clear();
                return;
            }
            else
            {
                grpUpdateFlightDetails.Visible = true;

                if (txtUpdateFlightNumber.Text.Equals("AA4732"))
                {
                    cboDeptAirportFlight.Text = "JFK";
                    cboArrAirportFlight.Text = "SNN";
                    cboOperatorCodeFlight.Text = "AA - American Airlines";
                    txtNumFlightSeats.Text = "150";
                    dtpDeptFlight.Text = "09-12-2035";
                    cboDeptTime.Text = "18:00 PM";
                    txtTicketPriceFlight.Text = "740.00";
                }

                else if (txtUpdateFlightNumber.Text.Equals("JL8915"))
                {
                    cboDeptAirportFlight.Text = "PEK";
                    cboArrAirportFlight.Text = "NRT";
                    cboOperatorCodeFlight.Text = "JL - Japan Airlines";
                    txtNumFlightSeats.Text = "200";
                    dtpDeptFlight.Text = "09-01-2025";
                    cboDeptTime.Text = "08:00 AM";
                    txtTicketPriceFlight.Text = "990.20";
                }

                else if (txtUpdateFlightNumber.Text.Equals("EK2468"))
                {
                    cboDeptAirportFlight.Text = "DXB";
                    cboArrAirportFlight.Text = "DUB";
                    cboOperatorCodeFlight.Text = "EK - Emirate";
                    txtNumFlightSeats.Text = "300.98";
                    dtpDeptFlight.Text = "07-05-2055";
                    cboDeptTime.Text = "07:00 AM";
                    txtTicketPriceFlight.Text = "1240.00";
                }

                else if (txtUpdateFlightNumber.Text.Equals("FR5739"))
                {
                    cboDeptAirportFlight.Text = "CDG";
                    cboArrAirportFlight.Text = "SNN";
                    cboOperatorCodeFlight.Text = "FR - Ryanair";
                    txtNumFlightSeats.Text = "580.67";
                    dtpDeptFlight.Text = "19-06-2030";
                    cboDeptTime.Text = "18:00 PM";
                    txtTicketPriceFlight.Text = "790.00";
                }


            }


        }

        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            decimal ticketPriceFlight;

            if (cboDeptAirportFlight.Text.Equals("") || cboArrAirportFlight.Text.Equals("") || cboOperatorCodeFlight.Text.Equals("") ||
                txtNumFlightSeats.Text.Equals("") || txtTicketPriceFlight.Text.Equals("") || cboDeptTime.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDeptAirportFlight.Focus();

                return;
            }
            else if (dtpDeptFlight.Value <= DateTime.Now)
            {
                MessageBox.Show("Date picked must be greater than current date", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDeptFlight.Focus();
            }


            else if (cboDeptAirportFlight.Text.Equals(cboArrAirportFlight.Text) || cboArrAirportFlight.Text.Equals(cboDeptAirportFlight.Text))
            {
                MessageBox.Show("Departure or Arrival Airports can not be the same", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDeptAirportFlight.SelectedIndex = -1;
                cboArrAirportFlight.SelectedIndex = -1;
                return;
            }

            else if (cboOperatorCodeFlight.SelectedIndex == -1)
            {
                MessageBox.Show("Operator Code must be selected.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboOperatorCodeFlight.Focus();
                return;

            }

            else if (!txtNumFlightSeats.Text.All(char.IsDigit) || int.Parse(txtNumFlightSeats.Text) < 70)
            {
                MessageBox.Show("Number of seats must be 70 or more and NUMERIC", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumFlightSeats.Focus();
                return;
            }



            else if (!decimal.TryParse(txtTicketPriceFlight.Text, out ticketPriceFlight) || txtTicketPriceFlight.Text.Length > 999)
            {
                MessageBox.Show("Ticket price must be a valid decimal format and MAXIMUM value of €999.00", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTicketPriceFlight.Focus();
                return;
            }

            else
            {

                DialogResult result = MessageBox.Show("Are you sure you want to Update the flight?",
                                      "Confirmation",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Flight has been Updated",
                                    "Success!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    grpUpdateFlightDetails.Visible = false;
                    txtUpdateFlightNumber.Text = "";
                }
                else
                {
                    MessageBox.Show("Flight has not been Updated",
                                    "Flight not Updated!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    grpUpdateFlightDetails.Visible = true;
                }

            }
        }

        private void frmUpdateFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
