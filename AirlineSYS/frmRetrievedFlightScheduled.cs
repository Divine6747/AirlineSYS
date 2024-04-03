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
        public frmRetrievedFlightScheduled()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmRetrievedFlightScheduled(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }

        private void frmRetrievedFlightScheduled_Load(object sender, EventArgs e) 
        {
            grgRetrievedFlightScheduled.Columns.Add("FlightNumber", "Flight Number");
            grgRetrievedFlightScheduled.Columns.Add("DeptAirport", "Departure Airport");
            grgRetrievedFlightScheduled.Columns.Add("ArrAirport", "Arrival Airport");
            grgRetrievedFlightScheduled.Columns.Add("FlightDate", "Flight Date");
            grgRetrievedFlightScheduled.Columns.Add("FlightTime", "Flight Time");

            foreach (DataGridViewColumn column in grgRetrievedFlightScheduled.Columns)
            {
                column.Width = 215;
            }

            grgRetrievedFlightScheduled.Font = new Font("Segoe UI", 10);
            grgRetrievedFlightScheduled.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            grgRetrievedFlightScheduled.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            grgRetrievedFlightScheduled.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grgRetrievedFlightScheduled.DefaultCellStyle.Font = new Font("Segoe UI", 15);
            grgRetrievedFlightScheduled.DefaultCellStyle.BackColor = Color.LightBlue;
            grgRetrievedFlightScheduled.DefaultCellStyle.ForeColor = Color.Black;
            grgRetrievedFlightScheduled.DefaultCellStyle.SelectionBackColor = Color.Plum;
            grgRetrievedFlightScheduled.DefaultCellStyle.SelectionForeColor = Color.Black;
            grgRetrievedFlightScheduled.RowTemplate.Height = 35;
            grgRetrievedFlightScheduled.ColumnHeadersHeight = 35;
            grgRetrievedFlightScheduled.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grgRetrievedFlightScheduled.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grgRetrievedFlightScheduled.GridColor = Color.Black;

            grgRetrievedFlightScheduled.Dock = DockStyle.Fill;

            List<string[]> flightinfo = Flight.GetAvailableFlights();
            foreach (string[] flightInfo in flightinfo)
            {
                grgRetrievedFlightScheduled.Rows.Add(flightInfo);
            }
        }
    }
}
