using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public static class UpdateFlightValidation
    {
        public static bool ValidateFields(ComboBox cboDeptAirport, ComboBox cboArrAirport, ComboBox cboOperatorCode, ComboBox cboDeptTime, string numSeats)
        {
            if (cboDeptAirport.SelectedItem == null || cboArrAirport.SelectedItem == null ||
                cboOperatorCode.SelectedItem == null || cboDeptTime.SelectedItem == null ||
                string.IsNullOrEmpty(numSeats))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int numFlightSeats;

            if (!int.TryParse(numSeats, out numFlightSeats) || numFlightSeats <= 0)
            {
                MessageBox.Show("Number of seats must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
