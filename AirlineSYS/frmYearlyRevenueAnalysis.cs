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
            chtYearlyRevenueAnalysis.Visible = true;
            btnYearlyRevenueAnalysisSearch.Visible = true;
            chtYearlyRevenueAnalysis.Series.Clear();
            grpFlightAnalysis.Visible = false;

            int[] AmountOfMoney = { };
            string[] flightNumbers = { "AA4732", "JL8915", "EK2468", "FR5739" };

            if (cboYearlyRevenueAnalysis.SelectedIndex >= 0 && cboYearlyRevenueAnalysis.SelectedIndex < 4)
            {
                if (cboYearlyRevenueAnalysis.SelectedIndex == 0)
                {
                    AmountOfMoney = new int[] { 2535000, 6474300, 7488300, 9983400, 9056220 };
                }
                else if (cboYearlyRevenueAnalysis.SelectedIndex == 1)
                {
                    AmountOfMoney = new int[] { 4856900, 7746800, 3564500, 2367300, 7784500 };
                }
                else if (cboYearlyRevenueAnalysis.SelectedIndex == 2)
                {
                    AmountOfMoney = new int[] { 3678700, 8340240, 5334400, 8462300, 9234500 };
                }
                else if (cboYearlyRevenueAnalysis.SelectedIndex == 3)
                {
                    AmountOfMoney = new int[] { 3522600, 934067, 4464500, 8179800, 9686790 };
                }
            }
            else
            {
                MessageBox.Show("Invalid selection year Selected. Please choose a valid year.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Series series = new Series("Yearly Revenue Analysis");
            series.ChartType = SeriesChartType.Column;
            series["PointWidth"] = "0.6";
            series.Color = System.Drawing.Color.Teal;

            for (int i = 0; i < flightNumbers.Length; i++)
            {
                series.Points.AddXY(flightNumbers[i], AmountOfMoney[i]);
            }

            chtYearlyRevenueAnalysis.Series.Add(series);
            chtYearlyRevenueAnalysis.ChartAreas[0].AxisX.Interval = 1;
            chtYearlyRevenueAnalysis.ChartAreas[0].AxisX.Title = "Flight Number";
            chtYearlyRevenueAnalysis.ChartAreas[0].AxisY.Title = "Number of Journeys";
            chtYearlyRevenueAnalysis.Titles.Clear();
            chtYearlyRevenueAnalysis.Titles.Add("Renenue Analysis Chart");
        }

        private void btnRevenueConfirm_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("End of the Analysis!",
                           "Success!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            chtYearlyRevenueAnalysis.Visible = false;
            btnRevenueConfirm.Visible = false;
            cboYearlyRevenueAnalysis.Text = "";
        }
    }
}
