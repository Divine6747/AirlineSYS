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
    public partial class frmYearlyFlightAnalysis : Form
    {
        frmAirlineMainMenu parent;
        public frmYearlyFlightAnalysis()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmYearlyFlightAnalysis(frmAirlineMainMenu parent)
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

        private void frmYearlyFlightAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void btnYearlyFlightAnalysisSearch_Click(object sender, EventArgs e)
        {
            chtYearlyFlightAnalysis.Visible = true;
            btnYearlyFlightAnalysisSearch.Visible = true;
            chtYearlyFlightAnalysis.Series.Clear();
            grpFlightAnalysis.Visible = false;

            int[] numJourney = { };
            string[] flightNumbers = { "AA4732", "JL8915", "EK2468", "FR5739" };

            if (cboYearlyFlightAnalysis.SelectedIndex >= 0 && cboYearlyFlightAnalysis.SelectedIndex < 4)
            {
                if (cboYearlyFlightAnalysis.SelectedIndex == 0)
                {
                    numJourney = new int[] { 500, 600, 700, 800, 900 };
                }
                else if (cboYearlyFlightAnalysis.SelectedIndex == 1)
                {
                    numJourney = new int[] { 400, 700, 600, 200, 700 };
                }
                else if (cboYearlyFlightAnalysis.SelectedIndex == 2) 
                {
                    numJourney = new int[] { 300, 800, 500, 800, 900 };
                }
                else if (cboYearlyFlightAnalysis.SelectedIndex == 3)
                {
                    numJourney = new int[] { 200, 900, 400, 800, 900 };
                }
            }
            else
            {
                MessageBox.Show("Invalid selection year Selected. Please choose a valid year.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Series series = new Series("Yearly Flight Analysis");
            series.ChartType = SeriesChartType.Column;
            series["PointWidth"] = "0.6";
            series.Color = System.Drawing.Color.Teal;

            for (int i = 0; i < flightNumbers.Length; i++)
            {
                series.Points.AddXY(flightNumbers[i], numJourney[i]);
            }

            chtYearlyFlightAnalysis.Series.Add(series);
            chtYearlyFlightAnalysis.ChartAreas[0].AxisX.Interval = 1;
            chtYearlyFlightAnalysis.ChartAreas[0].AxisX.Title = "Flight Number";
            chtYearlyFlightAnalysis.ChartAreas[0].AxisY.Title = "Number of Journeys";
            chtYearlyFlightAnalysis.Titles.Clear();
            chtYearlyFlightAnalysis.Titles.Add("Flight Analysis Chart");
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("End of the Analysis!",
                           "Success!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            chtYearlyFlightAnalysis.Visible = false;
            btnConfirm.Visible = false;
            cboYearlyFlightAnalysis.Text = "";
        }
    }
}