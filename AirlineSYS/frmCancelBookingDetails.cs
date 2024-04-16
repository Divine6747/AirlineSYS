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
    public partial class frmCancelBookingDetails : Form
    {
        public frmCancelBookingDetails()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnFlightBookingConfirm_Click(object sender, EventArgs e)
        {
            Booking cancelBooking = new Booking();

            cancelBooking.cancelBooking(Convert.ToInt32(txtCancelBookingID.Text),txtCancelForeName.Text,txtCancelSurname.Text, txtCancelEmail.Text);
            this.Close();
        }
    }
}
