using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AirlineSYS
{
    public static class ValidateFlightUtility
    {
        public static bool ValidateFlightField(ComboBox cboDeptAirport, ComboBox cboArrAirport, ComboBox cboOperatorCode, string txtNumFlightSeats, DateTime deptDate, ComboBox cboDeptTime, string estArrTime)
        {
            int numFlightSeats;
            if (!int.TryParse(txtNumFlightSeats, out numFlightSeats))
            {
                MessageBox.Show("Number of seats must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cboDeptAirport.Text))
            {
                MessageBox.Show("Departure airport must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cboArrAirport.Text))
            {
                MessageBox.Show("Arrival airport must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboDeptAirport.Text.Equals(cboArrAirport.Text))
            {
                MessageBox.Show("Departure and Arrival Airport cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboOperatorCode.SelectedItem == null || string.IsNullOrEmpty(cboOperatorCode.Text))
            {
                MessageBox.Show("Please enter an operator code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numFlightSeats <= 0)
            {
                MessageBox.Show("Number of seats must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numFlightSeats < 70)
            {
                MessageBox.Show("Number of seats must be greater than or equal to 70.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numFlightSeats > 100) 
            {
                MessageBox.Show("Number of seats must not exceed 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (deptDate <= DateTime.Now)
            {
                MessageBox.Show("Departure date must be greater than the current date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboDeptTime.SelectedItem == null || string.IsNullOrEmpty(cboDeptTime.Text))
            {
                MessageBox.Show("Please select a departure time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
