using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            decimal ticketPriceFlight;
            if (cboDeptAirportFlight.Text.Equals("") || cboArrAirportFlight.Text.Equals("") || cboOperatorCodeFlight.Text.Equals("") ||
                txtNumFlightSeats.Text.Equals("") || txtTicketPriceFlight.Text.Equals("") || cboDeptTime.Text.Equals("") )
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

            else if (cboOperatorCodeFlight.SelectedIndex == - 1)
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
                MessageBox.Show("Flight has been scheduled", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboArrAirportFlight.SelectedIndex = -1;
                cboDeptAirportFlight.SelectedIndex = -1;
                cboOperatorCodeFlight.SelectedIndex = -1;
                cboDeptTime.SelectedIndex = -1;
                txtTicketPriceFlight.Clear();
                txtNumFlightSeats.Clear();

            }

        }

        private void frmScheduleFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
