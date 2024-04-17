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
    public partial class frmBookingPersonalDetails : Form
    {
        private string flightNumber;
        private string deptAirport;
        private string arrAirport;
        private DateTime flightDate;
        private string flightTime;
        private string estArrTime;
        private string numBaggage;
        public frmBookingPersonalDetails(string flightNumber, string deptAirport, string arrAirport, DateTime flightDate, string flightTime, string estArrTime,string numBaggage)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //Passing the selected row of the  Data Grid View in these variables
            this.flightNumber = flightNumber;
            this.deptAirport = deptAirport;
            this.arrAirport = arrAirport;
            this.flightDate = flightDate;
            this.flightTime = flightTime;
            this.estArrTime = estArrTime;
            this.numBaggage = numBaggage;
            PopulateFlightInfo();
        }

        private void PopulateFlightInfo()
        {
            //Putting the selected row of the Data Grid View data on labels
            lblFlightNumberDetail.Text = flightNumber;
            lblDeptAirportDetail.Text = deptAirport;
            lblArrAirportDetail.Text = arrAirport;
            lblFlightDateDetails.Text = flightDate.ToString("dd-MMM-yyyy");
            lblFlightTimedetail.Text = flightTime;
            lblEstArrTimeDetail.Text = estArrTime;
            lblNumBaggageDetail.Text = numBaggage;
            checkRoutExist();
        }
        public bool checkRoutExist()
        {
            if (lblArrAirportDetail != null && lblDeptAirportDetail != null)
            {
                string dept = lblDeptAirportDetail.Text.ToString();
                string arr = lblArrAirportDetail.Text.ToString();
                Route checkRoutExist = new Route();
                int routeID = checkRoutExist.getRouteID(dept, arr);

                if (routeID != -1)
                {
                    lblBookingRouteIDDetail.Text = routeID.ToString();

                    return true;
                }
            }
            return false;
        }
        public void RefreshFlightInfo(string flightNumber, string deptAirport, string arrAirport, DateTime flightDate, string flightTime, string estArrTime,string numBaggage)
        {
            this.flightNumber = flightNumber;
            this.deptAirport = deptAirport;
            this.arrAirport = arrAirport;
            this.flightDate = flightDate;
            this.flightTime = flightTime;
            this.estArrTime = estArrTime;
            this.numBaggage = numBaggage;

            PopulateFlightInfo();
        }
        public frmBookingPersonalDetails()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frmBookingPersonalDetails_Load(object sender, EventArgs e)
        {
            lblPassengerIdDetail.Text = Passenger.getNextPassengerID().ToString();
            if (lblDeptAirportDetail != null && lblArrAirportDetail != null)
            {
                string deptAirport = lblDeptAirportDetail.Text;
                string arrAirport = lblArrAirportDetail.Text;
                lblBookingFlightPriceDetail.Text = "€" + Passenger.getRoutePrice(deptAirport, arrAirport);
            } 
            int routeID = Convert.ToInt32(lblBookingRouteIDDetail.Text);
            string flightNumber = Convert.ToString(lblFlightNumberDetail.Text);
            lblBookingIdDetail.Text = Booking.getNextBookingID().ToString();
            lblFlightSeatNumberDetail.Text = Booking.getNextSeatNumber(flightNumber,routeID).ToString();
        }
        private void btnFlightBookingConfirm_Click(object sender, EventArgs e)
        {
            string deptAirport = lblDeptAirportDetail.Text;
            string arrAirport = lblArrAirportDetail.Text;
            decimal paymentAmount = Passenger.getRoutePrice(deptAirport, arrAirport);
            string flightPriceText = lblBookingFlightPriceDetail.Text;

            string paymentAmountText = txtPayBookingFlightPrice.Text;
            string bookingEircode = txtBookingEircode.Text.ToUpper();


            if (!ValidateBookingPersonalDetails.ValidateBookingField(txtForeName.Text, txtSurname.Text, dtpBookingDOB.Value, txtBookingEmail.Text, txtBookingPhone.Text, txtBookingEircode.Text, paymentAmountText, paymentAmount, flightPriceText))
            {
                return;
            }
            else
            {
                Passenger passenger = new Passenger(Convert.ToInt32(lblPassengerIdDetail.Text), txtForeName.Text, txtSurname.Text, dtpBookingDOB.Value, txtBookingEmail.Text, int.Parse(txtBookingPhone.Text), bookingEircode);
                passenger.addPassenger();

                Booking booking = new Booking(Convert.ToInt32(lblBookingIdDetail.Text), Convert.ToInt32(lblPassengerIdDetail.Text), Convert.ToInt32(lblBookingRouteIDDetail.Text), lblFlightNumberDetail.Text,
                                              lblFlightTimedetail.Text, DateTime.Parse(lblFlightDateDetails.Text), Convert.ToInt32(lblFlightSeatNumberDetail.Text), Convert.ToInt32(lblNumBaggageDetail.Text),
                                              Convert.ToDecimal(txtPayBookingFlightPrice.Text), "CONFIRMED");
                booking.addBooking();

                bool isSeatDecreaseSuccessful = Booking.decreaseAvailableSeats(lblFlightNumberDetail.Text, 1);

                if (isSeatDecreaseSuccessful)
                {
                    MessageBox.Show("Booking successfully! Seats have been decreased.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to confirm booking. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DialogResult bookingAnotherFlight = MessageBox.Show("Do you want to book another flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (bookingAnotherFlight == DialogResult.Yes)
            {
                frmCreateBooking frmCreateBooking = new frmCreateBooking();
                frmCreateBooking.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
