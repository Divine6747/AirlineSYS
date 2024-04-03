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
    public partial class frmCancelBooking : Form
    {
        frmAirlineMainMenu parent;
        public frmCancelBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmCancelBooking(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {

        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }
    }
}
