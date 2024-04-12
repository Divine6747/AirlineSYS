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
        private string numBaggage;
        public frmBookingPersonalDetails(string flightNumber, string deptAirport, string arrAirport, DateTime flightDate, string flightTime, string numBaggage)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //Passing the selected row of the  Data Grid View in these variables
            this.flightNumber = flightNumber;
            this.deptAirport = deptAirport;
            this.arrAirport = arrAirport;
            this.flightDate = flightDate;
            this.flightTime = flightTime;
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
        public void RefreshFlightInfo(string flightNumber, string deptAirport, string arrAirport, DateTime flightDate, string flightTime, string numBaggage)
        {
            this.flightNumber = flightNumber;
            this.deptAirport = deptAirport;
            this.arrAirport = arrAirport;
            this.flightDate = flightDate;
            this.flightTime = flightTime;
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
            lblPassengerIdDetail.Text = Passenger.getNextPassengerID().ToString("00");
            if (lblDeptAirportDetail!= null && lblArrAirportDetail!= null)
            {
                string deptAirport = lblDeptAirportDetail.Text;
                string arrAirport = lblArrAirportDetail.Text;
                lblBookingFlightPriceDetail.Text = "€" + Passenger.getRoutePrice(deptAirport,arrAirport);
            }
        }

        private void btnFlightBookingConfirm_Click(object sender, EventArgs e)
        {
            string deptAirport = lblDeptAirportDetail.Text;
            string arrAirport = lblArrAirportDetail.Text;
            decimal paymentAmount = Passenger.getRoutePrice(deptAirport, arrAirport);

            string flightPriceText = lblBookingFlightPriceDetail.Text;

            decimal routePrice = Passenger.getRoutePrice(deptAirport, arrAirport);

            if (!validateBookingPersonalDetails.ValidateBookingField(txtForeName.Text, txtSurname.Text, dtpBookingDOB.Value, txtBookingEmail.Text, txtBookingPhone.Text, txtBookingEircode.Text, paymentAmount, routePrice, flightPriceText))
            {
                return;
            }
            else
            {
                string userData = $"First Name: {txtForeName.Text}\n" +
                            $"Surname: {txtSurname.Text}\n" +
                            $"Date of Birth: {dtpBookingDOB.Value.ToShortDateString()}\n" +
                            $"Email: {txtBookingEmail.Text}\n" +
                            $"Phone: {txtBookingPhone.Text}\n" +
                            $"Eircode: {txtBookingEircode.Text}";
                MessageBox.Show($"Your flight booking information:\n\n{userData}", "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
