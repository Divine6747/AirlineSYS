using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AirlineSYS
{
    public partial class frmYearlyRevenueAnalysis : Form
    {
        frmAirlineMainMenu parent;
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmYearlyRevenueAnalysis(frmAirlineMainMenu parent)
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
        private void btnYearlyRevenueAnalysisSearch_Click(object sender, EventArgs e)
        {
            string selectedYear = cboYearlyRevenueAnalysisYears.SelectedItem.ToString();

            string query = "SELECT TO_CHAR(FlightDate, 'MM') AS Month, SUM(AmountPaid) AS TotalAmount " +
               "FROM Bookings " +
               "WHERE EXTRACT(YEAR FROM FlightDate) = '" + selectedYear + "' " +
               "GROUP BY TO_CHAR(FlightDate, 'MM') " +
               "ORDER BY TO_CHAR(FlightDate, 'MM')";


            DataTable dt = new DataTable();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

            List<string> months = new List<string>();
            List<decimal> amounts = new List<decimal>();

            for (int i = 1; i <= 12; i++)
            {
                months.Add(getMonthName(i));
                amounts.Add(0);
            }

            foreach (DataRow row in dt.Rows)
            {
                int monthIndex = Convert.ToInt32(row["Month"]) - 1;
                amounts[monthIndex] = Convert.ToDecimal(row["TotalAmount"]);
            }

            chtYearlyRevenueAnalysis.Series[0].Points.DataBindXY(months, amounts);
            chtYearlyRevenueAnalysis.Series[0].Label = "#VALY";

            chtYearlyRevenueAnalysis.Titles.Clear();
            chtYearlyRevenueAnalysis.Titles.Add($"Flight Booking Revenue in {selectedYear}");
            chtYearlyRevenueAnalysis.Visible = true;
        }
        private string getMonthName(int month)
        {
            switch (month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "Unknown";
            }
        }

        private void btnRevenueConfirm_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("End of the Analysis!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            chtYearlyRevenueAnalysis.Visible = false;
            btnRevenueConfirm.Visible = false;
            cboYearlyRevenueAnalysisYears.Text = "";
        }
        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            for (int year = 2020; year <= 2025; year++)
            {
                cboYearlyRevenueAnalysisYears.Items.Add(year.ToString());
            }

            //Set's the default selected year as the current year
            cboYearlyRevenueAnalysisYears.SelectedItem = DateTime.Now.Year.ToString();
        }
    }
}
