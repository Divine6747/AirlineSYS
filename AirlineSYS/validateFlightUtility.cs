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
        public static bool ValidateFlightField(ComboBox cboDeptAirport, ComboBox cboArrAirport, string operatorCode, string numFlightSeats, string ticketPrice, DateTime deptDate, ComboBox cboDeptTime)
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

            if (string.IsNullOrEmpty(operatorCode))
            {
                MessageBox.Show("Please enter an operator code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(numFlightSeats))
            {
                MessageBox.Show("Please enter the number of flight seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(numFlightSeats, out int flightSeats))
            {
                MessageBox.Show("Number of seats must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (flightSeats < 70)
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

            if (string.IsNullOrEmpty(ticketPrice))
            {
                MessageBox.Show("Please enter the ticket price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(ticketPrice, out decimal decimalTcketPrice))
            {
                MessageBox.Show("Ticket Price must be a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal ticketMinVal = 69.00M;

            if (decimalTcketPrice < ticketMinVal)
            {
                MessageBox.Show($"Ticket Price must be greater than €{ticketMinVal}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
