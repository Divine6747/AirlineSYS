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
        private int routeID;
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
            //Passing Selected Data Grid View in these variables
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
            //Putting the Data Grid View data in labels
            lblFlightNumberDetail.Text = flightNumber;
            lblDeptAirportDetail.Text = deptAirport;
            lblArrAirportDetail.Text = arrAirport;
            lblFlightDateDetails.Text = flightDate.ToString("dd-MMM-yyyy");
            lblFlightTimedetail.Text = flightTime;
            lblNumBaggageDetail.Text = numBaggage;
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

        private void munBack_Click(object sender, EventArgs e)
        {

        }

        private void grpPersonalCreateBookingDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmBookingPersonalDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
