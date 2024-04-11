using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AirlineSYS
{
    public static class validateFlightUtility
    {
        public static bool ValidateFlightField(ComboBox cboDeptAirport, ComboBox cboArrAirport, ComboBox cboOperatorCode, int numFlightSeats, DateTime deptDate, ComboBox cboDeptTime, string estArrTime)
        {
            if (cboDeptAirport.SelectedItem == null)
            {
                MessageBox.Show("Departure airport must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboArrAirport.SelectedItem == null)
            {
                MessageBox.Show("Arrival airport must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboDeptAirport.SelectedItem.Equals(cboArrAirport.SelectedItem))
            {
                MessageBox.Show("Departure and Arrival Airport cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboOperatorCode.SelectedItem == null)
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

            if (deptDate <= DateTime.Now)
            {
                MessageBox.Show("Departure date must be greater than the current date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboDeptTime.SelectedItem == null)
            {
                MessageBox.Show("Please select a departure time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
