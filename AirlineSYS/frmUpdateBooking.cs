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
    public partial class frmUpdateBooking : Form
    {
        frmAirlineMainMenu parent;
        public frmUpdateBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmUpdateBooking(frmAirlineMainMenu parent)
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

        private void btnUpadateBookingConfirm_Click(object sender, EventArgs e)
        {
        }
        private void btnUpdateBookingIDSearch_Click(object sender, EventArgs e)
        {

        }
        private void frmUpdateBooking_Load(object sender, EventArgs e)
        {
            btnUpadateBookingConfirm.Visible = false;
        }
    }
}
