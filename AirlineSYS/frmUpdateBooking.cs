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
            DataTable dt = Passenger.findBookingDetails(bookingID);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // Populate text boxes with booking data
                lblFlightNumberDetail.Text = row["FlightNumber"].ToString();
                cboDeptimeDetail.Text = row["FlightTime"].ToString();
                dptUpdateBookingDate.Text = ((DateTime)row["FlightDate"]).ToString();
                lblSeatNumDetail.Text = row["SeatNum"].ToString();
                nudNumBaggage.Text = row["NumBaggage"].ToString();
                lbFlightlBookingPriceDetail.Text = row["AmountPaid"].ToString();

                // Populate labels with passenger data
                txtForeName.Text = row["forename"].ToString();
                txtSurname.Text = row["surname"].ToString();
                txtCreateBookingEmail.Text = row["Email"].ToString();
                dtpDOB.Text = ((DateTime)row["DateOfBirth"]).ToString();
                txtCreateBooingPhone.Text = row["Phone"].ToString();
                txtCreateBookingEircode.Text = row["Eircode"].ToString();
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
