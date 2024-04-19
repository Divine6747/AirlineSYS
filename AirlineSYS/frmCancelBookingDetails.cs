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
    public partial class frmCancelBookingDetails : Form
    {
        public string flightNumber;
        public frmCancelBookingDetails(string flightNumber)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.flightNumber = flightNumber; // Initialize flightNumber with the passed value
            lblCancelBookingPersonalFlightNumberDetail.Text = flightNumber;
        }

        private void btnFlightBookingConfirm_Click(object sender, EventArgs e)
        {
            Booking cancelBooking = new Booking();

            cancelBooking.cancelBooking(Convert.ToInt32(txtCancelBookingID.Text),txtCancelForeName.Text,txtCancelSurname.Text, txtCancelEmail.Text);
            
            bool isSeatIncreaseSuccessful = Booking.increaseAvailableSeats(lblCancelBookingPersonalFlightNumberDetail.Text, 1);

            if (isSeatIncreaseSuccessful)
            {
                MessageBox.Show("Cancel Booking successfully! Seats have been increased.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to cancel booking. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
