using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class frmScheduleFlight : Form
    {
        frmAirlineMainMenu parent;
        public frmScheduleFlight()
        {
            InitializeComponent();
            cboDeptAirportFlight.SelectedIndexChanged += cboDeptAirportFlight_SelectedIndexChanged;
            cboDeptTime.SelectedIndexChanged += cboDeptTime_SelectedIndexChanged;
            this.StartPosition = FormStartPosition.CenterScreen;
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
        private void btnFlightConfirm_Click(object sender, EventArgs e)
        {
            if (!validateFlightUtility.ValidateFlightField(cboDeptAirportFlight, cboArrAirportFlight, cboOperatorCodeFlight, int.Parse(txtNumFlightSeats.Text), dtpDeptFlight.Value, cboDeptTime, lblFlightNumberDetail.Text))
            {
                return;
            }
            else
            {
                string dept = cboDeptAirportFlight.SelectedItem.ToString();

                string arr = cboArrAirportFlight.SelectedItem.ToString();

                Route getRouteID = new Route();

                int routeID = getRouteID.getRouteID(dept, arr);

                if (routeID != -1)
                {
                    Flight scheduleFlight = new Flight(lblFlightNumberDetail.Text, cboOperatorCodeFlight.SelectedItem.ToString(),
                              int.Parse(lblRouteIdDetails.Text), dtpDeptFlight.Value, cboDeptTime.SelectedItem.ToString(),
                              lblEstArrTimeDetail.Text, int.Parse(txtNumFlightSeats.Text), int.Parse(txtNumFlightSeats.Text), "A");
                    scheduleFlight.scheduleFlight();

                    MessageBox.Show("Route ID is: " + routeID.ToString() + "\n\n" +
                                     lblFlightNumberDetail + "\n\n" +
                                     cboOperatorCodeFlight.SelectedItem + "\n\n" +
                                     txtNumFlightSeats.Text + "\n\n" +
                                     dtpDeptFlight.Text + "\n\n" +
                                     cboDeptTime.SelectedItem, "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboArrAirportFlight.SelectedIndex = -1;
                    cboDeptAirportFlight.SelectedIndex = -1;
                    cboOperatorCodeFlight.SelectedIndex = -1;
                    txtNumFlightSeats.Clear();
                    dtpDeptFlight.Value = DateTime.Now;
                    cboDeptTime.SelectedIndex = -1;
                   
                }
                else
                {
                    MessageBox.Show("No RouteID Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cboOperatorCodeFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOperatorCodeFlight.SelectedIndex != -1)
            {
                string selectedOperator = cboOperatorCodeFlight.SelectedItem.ToString();

                string increflightNumber = Flight.getFlightNumber(selectedOperator);

                int numericPart = int.Parse(increflightNumber.Substring(selectedOperator.Length));

                int nextFlightNumberPart = numericPart;

                string nextFlightNumber = selectedOperator + nextFlightNumberPart.ToString("D4");
                lblFlightNumberDetail.Text = nextFlightNumber;
                ReviewUpdateFlightDetails();
            }
        }
        private void frmScheduleFlight_Load(object sender, EventArgs e)
        {
            cboOperatorCodeFlight.Items.Clear();
            cboDeptAirportFlight.Items.Clear();
            cboArrAirportFlight.Items.Clear();
            cboDeptTime.Items.Clear();
            cboArrAirportFlight.Enabled = false;

            List<Operator> operators = Operator.getOperators();

            foreach (Operator opCode in operators)
            {
                cboOperatorCodeFlight.Items.Add(opCode.getOperatorCode());
            }

            cboOperatorCodeFlight.SelectedIndexChanged += cboOperatorCodeFlight_SelectedIndexChanged;

            List<Route> routes = Route.getRoutes();

            //Checking for duplicate elements to store unique departureAirports and arrivalAirports(so filtering both sets of airports)
            List<string> departureAirports = new List<string>();
            List<string> arrivalAirports = new List<string>();

            foreach (Route route in routes)
            {   
                //Contains is cheking if the airport being added is already in the combo box
                if (!departureAirports.Contains(route.getDepartureAirport()))
                    departureAirports.Add(route.getDepartureAirport());

                if (!arrivalAirports.Contains(route.getArrivalAirport()))
                    arrivalAirports.Add(route.getArrivalAirport());
            }

            cboDeptAirportFlight.Items.AddRange(departureAirports.ToArray());

            cboArrAirportFlight.Items.AddRange(arrivalAirports.ToArray());

            List<FlightTimes> times = FlightTimes.getFlightTimes();

            foreach (FlightTimes time in times)
            {
                cboDeptTime.Items.Add(time.getFlightTime());
            }
            cboDeptTime.Enabled = false;
            ReviewUpdateFlightDetails();
        }
        public bool checkRoutExist()
        {
            if (cboDeptAirportFlight.SelectedItem != null && cboArrAirportFlight.SelectedItem != null)
            {
                string dept = cboDeptAirportFlight.SelectedItem.ToString();
                string arr = cboArrAirportFlight.SelectedItem.ToString();
                Route checkRoutExist = new Route();
                int routeID = checkRoutExist.getRouteID(dept, arr);

                if (routeID != -1)
                {
                    lblRouteIdDetails.Text = routeID.ToString();
                    cboDeptTime.Enabled = true;
                    return true;
                }
                else
                {
                    lblRouteIdDetails.Text = "Does Not Exist";
                    MessageBox.Show("Route Doesn't Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblRouteDurationDetail.Text = "Not Retrieved";
                    lblEstArrTimeDetail.Text = "Cannot Be Calculated";
                    cboDeptTime.Enabled = false;
                    return false;
                }
            }
            cboDeptTime.Enabled = false;
            return false;
        }
        private void cboDeptAirportFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeptAirportFlight.SelectedIndex != -1)
            {
                cboArrAirportFlight.Enabled = true;
            }

            if (!checkRoutExist())
            {
                cboDeptTime.SelectedIndex = -1;
                return;
            }
        }
        private void cboArrAirportFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkRoutExist())
            {
                cboDeptTime.SelectedIndex = -1;
                return;
            }
            checkDuration();
            ReviewUpdateFlightDetails();
        }
        private void checkDuration()
        {
            if (cboDeptAirportFlight.SelectedItem != null && cboArrAirportFlight.SelectedItem != null)
            {
                string dept = cboDeptAirportFlight.SelectedItem.ToString();
                string arr = cboArrAirportFlight.SelectedItem.ToString();

                Route route = new Route();
                int duration = route.getDuration(dept, arr);

                if (duration != -1)
                {
                    lblRouteDurationDetail.Text = duration.ToString();
                }
                else
                {
                    lblRouteDurationDetail.Text = "Does Not Exist";
                    cboDeptTime.Enabled = false;
                }
            }
        }
        private void calculateEstArrTime()
        {
            if (cboDeptTime.SelectedItem != null && lblRouteDurationDetail.Text != "Does Not Exist")
            {
                string selectedDeptTime = cboDeptTime.SelectedItem.ToString();
                int duration = int.Parse(lblRouteDurationDetail.Text);

                DateTime deptTime;

                if (DateTime.TryParseExact(selectedDeptTime, "HH:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out deptTime))
                {
                    DateTime estimatedArrivalTime = deptTime.AddMinutes(duration);

                    lblEstArrTimeDetail.Text = estimatedArrivalTime.ToString("HH:mm tt", CultureInfo.InvariantCulture).ToUpper();                 
                }
            }
            else
            {
                lblEstArrTimeDetail.Text = "Cannot Be Calculated";
            }
        }
        private void cboDeptTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateEstArrTime();
        }

        private void ReviewUpdateFlightDetails()
        {
            //https://codebuns.com/csharp-basics/stringbuilder/#:~:text=C%23%20StringBuilder%20Append%20method%20appends,of%20the%20current%20StringBuilder%20object.&text=Note%3A%20The%20capacity%20of%20the,append%20to%20add%20more%20strings.
            lblDateReview.Text = "";

            StringBuilder viewFlightDetails = new StringBuilder();

            if (!string.IsNullOrEmpty(lblFlightNumberDetail.Text))
            {
                viewFlightDetails.Append("Flight Number: ").Append(lblFlightNumberDetail.Text).Append("\n\n");
            }

            if (cboOperatorCodeFlight.SelectedItem != null)
            {
                viewFlightDetails.Append("Operator Code: ").Append(cboOperatorCodeFlight.SelectedItem.ToString()).Append("\n\n");
            }

            if (!string.IsNullOrEmpty(txtNumFlightSeats.Text))
            {
                viewFlightDetails.Append("Number of Seats: ").Append(txtNumFlightSeats.Text).Append("\n\n");
            }

            if (!string.IsNullOrEmpty(lblRouteIdDetails.Text))
            {
                viewFlightDetails.Append("Route ID: ").Append(lblRouteIdDetails.Text).Append("\n\n");
            }
                
            viewFlightDetails.Append("Departure Date: ").Append(dtpDeptFlight.Value.ToShortDateString()).Append("\n\n");

            if (cboDeptTime.SelectedItem != null)
            {
                viewFlightDetails.Append("Departure Time: ").Append(cboDeptTime.SelectedItem.ToString()).Append("\n\n");
            }

            if (!string.IsNullOrEmpty(lblEstArrTimeDetail.Text))
            {
                viewFlightDetails.Append("Estimated Arrival Time: ").Append(lblEstArrTimeDetail.Text).Append("\n\n");
            }

            if (cboDeptAirportFlight.SelectedItem != null)
            {
                viewFlightDetails.Append("Departure Airport: ").Append(cboDeptAirportFlight.SelectedItem.ToString()).Append("\n\n");
            }

            if (cboArrAirportFlight.SelectedItem != null)
            {
                viewFlightDetails.Append("Arrival Airport: ").Append(cboArrAirportFlight.SelectedItem.ToString()).Append("\n\n");
            }

            lblDateReview.Text = viewFlightDetails.ToString();
        }

        private void txtNumFlightSeats_TextChanged(object sender, EventArgs e)
        {
            ReviewUpdateFlightDetails();
        }
        private void dtpDeptFlight_ValueChanged(object sender, EventArgs e)
        {
            ReviewUpdateFlightDetails();
        }
    }
}