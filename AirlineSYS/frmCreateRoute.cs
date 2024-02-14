using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class frmCreateRoute : Form
    {
        frmAirlineMainMenu parent;
        public frmCreateRoute()
        {
            InitializeComponent();
        }
        public frmCreateRoute(frmAirlineMainMenu parent)
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


        private void btnCreateRouteConfirm_Click(object sender, EventArgs e)
        {
            Route route = new Route(Convert.ToInt32(txtRouteID.Text),txtRouteDept.Text,txtRouteArr.Text,Convert.ToDecimal(txtRoutePrice.Text),Convert.ToInt32(txtRouteDur.Text),txtRouteStatus.Text);
            route.addRoute();

            txtRouteID.Text = Route.getNextRouteID().ToString("00");    
            txtRouteDept.Clear();
            txtRouteArr.Clear();
            txtRoutePrice.Clear();
            txtRouteDur.Clear();
            txtRouteStatus.Clear();

        }

        private void frmCreateRoute_Load(object sender, EventArgs e)
        {
            txtRouteID.Text = Route.getNextRouteID().ToString("00");
        }
    }
}
