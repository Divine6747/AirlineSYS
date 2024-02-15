using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class frmEndRoute : Form
    {
        frmAirlineMainMenu parent;

        // Define a list of valid routes
        List<string> validRoutes = new List<string>
        {
            "DUB - SHA",
            "JFK - SHA",
            "SHA - PEK",
            "SNN - FCO",
            "DUB - BGY"
        };

        public frmEndRoute()
        {
            InitializeComponent();
        }

        public frmEndRoute(frmAirlineMainMenu parent)
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

        private void btnRouteSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEndRouteConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the route?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            string successMessage = "Route has been Ended";
            string failureMessage = "Route has not been ended";

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(successMessage, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(failureMessage, "End not Ended!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            grpEndRouteDetails.Visible = false;
            cboEndRoute.Text = "";
        }
    }
}
