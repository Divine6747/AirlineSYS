using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AirlineSYS
{
    public partial class frmYearlyRouteAnalysis : Form
    {
        frmAirlineMainMenu parent;
        public frmYearlyRouteAnalysis()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmYearlyRouteAnalysis(frmAirlineMainMenu parent)
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

        private void btnYearlyFlightAnalysisSearch_Click_1(object sender, EventArgs e)
        {
            chtYearlyRouteAnalysis.Visible = true;
            btnYearlyFlightAnalysisSearch.Visible = true;
            chtYearlyRouteAnalysis.Series.Clear();
            btnYearlyFlightAnalysisSearch.Visible = false;

            string selectedYear = cboYearlyFlightAnalysis.SelectedItem.ToString();

            string query = $"SELECT r.DeptAirport || ' - ' || r.ArrAirport AS Route, COUNT(*) AS NumJourneys " +
                           $"FROM Flights f " +
                           $"JOIN Routes r ON f.RouteID = r.RouteID " +
                           $"WHERE TO_CHAR(f.FlightDate, 'YYYY') = :selectedYear " +
                           $"GROUP BY r.DeptAirport, r.ArrAirport";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":selectedYear", OracleDbType.Varchar2).Value = selectedYear;

            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();

                Series series = new Series("Yearly Route Analysis");
                series.ChartType = SeriesChartType.Column;
                series["PointWidth"] = "0.6";
                series.Color = System.Drawing.Color.Teal;

                // Populate the chart with the fetched data
                while (reader.Read())
                {
                    string route = reader["Route"].ToString();
                    int numJourneys = Convert.ToInt32(reader["NumJourneys"]);
                    series.Points.AddXY(route, numJourneys);
                }

                chtYearlyRouteAnalysis.Series.Add(series);
                chtYearlyRouteAnalysis.ChartAreas[0].AxisX.Interval = 1;
                chtYearlyRouteAnalysis.ChartAreas[0].AxisX.Title = "Route";
                chtYearlyRouteAnalysis.ChartAreas[0].AxisY.Title = "Number of Journeys";
                chtYearlyRouteAnalysis.Titles.Clear();
                chtYearlyRouteAnalysis.Titles.Add("Route Analysis Chart");
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Oracle Exception: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("End of the Analysis!",
                           "Success!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            chtYearlyRouteAnalysis.Visible = false;
            btnConfirm.Visible = false;
            cboYearlyFlightAnalysis.Text = "";

        }
    }
}
