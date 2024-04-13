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
    public partial class frmUpdateBooking : Form
    {
        frmAirlineMainMenu parent;
        public frmUpdateBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmUpdateBooking(frmAirlineMainMenu parent)
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

        private void btnUpadateBookingConfirm_Click(object sender, EventArgs e)
        {
        }
        private void btnUpdateBookingIDSearch_Click(object sender, EventArgs e)
        {
            int bookingID = Convert.ToInt32(txtBookingID.Text);
            var (booking, passenger) = Passenger.findBookingDetails(bookingID);

            if (booking != null && passenger != null)
            {
                // Populate text boxes with booking data
                lblFlightNumberDetail.Text = booking.GetFlightNumber();
                cboDeptimeDetail.Text = booking.GetFlightTime();
                dptUpdateBookingDate.Text = booking.GetFlightDate().ToString();
                lblSeatNumDetail.Text = booking.GetSeatNum().ToString();
                nudNumBaggage.Text = booking.GetNumBaggage().ToString();
                lbFlightlBookingPriceDetail.Text = booking.GetAmountPaid().ToString();

                // Populate labels with passenger data
                txtForeName.Text = passenger.getForename();
                txtSurname.Text = passenger.getSurname();
                txtCreateBookingEmail.Text = passenger.getEmail();
                dtpDOB.Text = passenger.getDateOfBirth().ToString();
                txtCreateBooingPhone.Text = passenger.getPhone().ToString();
                txtCreateBookingEircode.Text = passenger.getEircode();
            }
            else
            {
                MessageBox.Show("No booking found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmUpdateBooking_Load(object sender, EventArgs e)
        {
        }
    }
}
