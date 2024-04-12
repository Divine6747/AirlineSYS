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
    public partial class frmRetrievedFlightScheduled : Form
    {
        private int routeID;
        private string flightNumber;
        private string deptAirport;
        private string arrAirport;
        private DateTime flightDate;
        private string flightTime;
        private int numBaggage;
        public frmRetrievedFlightScheduled()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmRetrievedFlightScheduled(frmAirlineMainMenu parent, int routeID, string flightNumber, string deptAirport, string arrAirport, DateTime flightDate, string flightTime, int numBaggage)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Parent = parent;
            this.routeID = routeID;
            this.flightNumber = flightNumber;
            this.deptAirport = deptAirport;
            this.arrAirport = arrAirport;
            this.flightDate = flightDate;
            this.flightTime = flightTime;
            this.numBaggage = numBaggage;
        }
        private void frmRetrievedFlightScheduled_Load(object sender, EventArgs e)
        {
            // Adds columns to the Data Gri dView for Flight Number, Departure Airport, Arrival Airport and displays flight details
            grgRetrievedFlightScheduled.Columns.Add("FlightNumber", "Flight Number");
            grgRetrievedFlightScheduled.Columns.Add("DeptAirport", "Departure Airport");
            grgRetrievedFlightScheduled.Columns.Add("ArrAirport", "Arrival Airport");
            grgRetrievedFlightScheduled.Columns.Add("FlightDate", "Flight Date");
            grgRetrievedFlightScheduled.Columns.Add("FlightTime", "Flight Time");

            foreach (DataGridViewColumn column in grgRetrievedFlightScheduled.Columns)
            {
                column.Width = 215;
            }

            //Controls header font and background colour
            grgRetrievedFlightScheduled.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            grgRetrievedFlightScheduled.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;

            //Controls font colour
            grgRetrievedFlightScheduled.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Controls font and size
            grgRetrievedFlightScheduled.DefaultCellStyle.Font = new Font("Segoe UI", 15);

            //Control column background colour
            grgRetrievedFlightScheduled.DefaultCellStyle.BackColor = Color.LightBlue;

            //Controls text colour
            grgRetrievedFlightScheduled.DefaultCellStyle.ForeColor = Color.Black;

            //Controls selected row colour
            grgRetrievedFlightScheduled.DefaultCellStyle.SelectionBackColor = Color.Plum;

            //Aligns header and column center
            grgRetrievedFlightScheduled.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grgRetrievedFlightScheduled.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Controls grid Colour 
            grgRetrievedFlightScheduled.GridColor = Color.Black;

            //Control Header Height
            grgRetrievedFlightScheduled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grgRetrievedFlightScheduled.ColumnHeadersHeight = 70;

            //Allow only row select
            grgRetrievedFlightScheduled.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Stops Multple rows for been selected
            grgRetrievedFlightScheduled.MultiSelect = false;

            List<string[]> flightinfo = Flight.GetAvailableFlights(routeID);
            foreach (string[] flightInfo in flightinfo)
            {
                grgRetrievedFlightScheduled.Rows.Add(flightInfo);
            }

            // Automatically adjust column widths and row heights based the information retrieved
            grgRetrievedFlightScheduled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grgRetrievedFlightScheduled.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //No changes can be make by the user
            grgRetrievedFlightScheduled.ReadOnly = true;
        }
        private void ConfirmSelect()
        {
            if(grgRetrievedFlightScheduled.SelectedRows.Count > 0)
    {
                // Retrieve the selected flight info
                DataGridViewRow selectedFlight = grgRetrievedFlightScheduled.SelectedRows[0];

                // Collects data from the selected row
                flightNumber = selectedFlight.Cells["FlightNumber"].Value.ToString();
                deptAirport = selectedFlight.Cells["DeptAirport"].Value.ToString();
                arrAirport = selectedFlight.Cells["ArrAirport"].Value.ToString();
                flightDate = DateTime.Parse(selectedFlight.Cells["FlightDate"].Value.ToString());
                flightTime = selectedFlight.Cells["FlightTime"].Value.ToString();
                DialogResult flightConfirm = MessageBox.Show("Are you sure you want to book the selected flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (flightConfirm == DialogResult.Yes)
                {
                    // Convert numBaggage to integer
                    int numBaggageInt;
                    if (!int.TryParse(numBaggage.ToString(), out numBaggageInt))
                    {
                        // Handle parsing error, maybe show a message to the user
                        MessageBox.Show("Invalid number of baggage.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Passing the selected flight info and number of bags to frmCreateBooking
                    frmCreateBooking frmCreateBooking = new frmCreateBooking(flightNumber, deptAirport, arrAirport, flightDate, flightTime, numBaggageInt);
                    this.Hide();
                    frmCreateBooking.Show();
                    frmCreateBooking.Confirm.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a row before confirming.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFlightBookingConfirm_Click(object sender, EventArgs e)
        {
            ConfirmSelect();            
        }

        private void munBack_Click(object sender, EventArgs e)
        {
            frmCreateBooking frmCreateBooking = Application.OpenForms["frmCreateBooking"] as frmCreateBooking;

            if (frmCreateBooking != null)
            {
                int numBaggageInt = numBaggage;

                DataGridViewRow selectedFlight = grgRetrievedFlightScheduled.SelectedRows[0];

                if (selectedFlight.Index == -1)
                {
                    frmCreateBooking.deptDate.Text = "";

                }
                // Passes numBaggageString to RefreshFlightInfo method
                frmCreateBooking.labelNumBaggage.Visible = true;
                frmCreateBooking.numericUpDownNumBaggage.Visible = true;
                frmCreateBooking.RefreshFlightInfo(flightNumber, deptAirport, arrAirport, flightDate, flightTime, numBaggageInt);

                this.Close();

                frmCreateBooking.Show();                
                frmCreateBooking.lblFlightDateDetails.Text = "";
                frmCreateBooking.nudNumBaggage.Visible = false;
                MessageBox.Show("Please select a fligt properly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}