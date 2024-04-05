using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.VisualBasic;


namespace AirlineSYS
{
    public partial class frmRetrievedFlightScheduled : Form
    {
        private int routeID;
        public frmRetrievedFlightScheduled()
        {
            InitializeComponent();
        }
        public frmRetrievedFlightScheduled(frmAirlineMainMenu parent, int routeID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Parent = parent;
            this.routeID = routeID;
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
        private void grgRetrievedFlightScheduled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ConfirmSelect()
        {                    
            //https://www.aspsnippets.com/Articles/2882/Pass-Send-selected-DataGridView-Row-from-one-Form-to-another-using-C-and-VBNet/
           if (grgRetrievedFlightScheduled.SelectedRows.Count > 0)
           {
                // Retrieve the selected flight info
                DataGridViewRow selectedFlight = grgRetrievedFlightScheduled.SelectedRows[0];

                // Collects data from the selected row
                string flightNumber = selectedFlight.Cells["FlightNumber"].Value.ToString();
                string deptAirport = selectedFlight.Cells["DeptAirport"].Value.ToString();
                string arrAirport = selectedFlight.Cells["ArrAirport"].Value.ToString();
                DateTime flightDate = DateTime.Parse(selectedFlight.Cells["FlightDate"].Value.ToString());
                string flightTime = selectedFlight.Cells["FlightTime"].Value.ToString();
                DialogResult flightConfirm = MessageBox.Show("Are you sure you want to book the selected flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (flightConfirm == DialogResult.Yes)
                {
                    // Passing the selected flight info and number of bags to frmCreateBooking
                    frmCreateBooking frmCreateBooking = new frmCreateBooking(flightNumber, deptAirport, arrAirport, flightDate, flightTime);
                    this.Hide();
                    frmCreateBooking.Show();                    
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
            this.Close();
            frmCreateBooking frmCreateBooking = new frmCreateBooking();
            frmCreateBooking.Show();
        }
    }
}