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
        public static bool ValidateFields(ComboBox deptAirportCombo, ComboBox arrAirportCombo, ComboBox operatorCodeCombo, ComboBox deptTimeCombo, string numSeatsText)
        {
            if (deptAirportCombo.SelectedItem == null || arrAirportCombo.SelectedItem == null ||
                operatorCodeCombo.SelectedItem == null || deptTimeCombo.SelectedItem == null ||
                string.IsNullOrEmpty(numSeatsText))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int numFlightSeats;
            if (!int.TryParse(numSeatsText, out numFlightSeats) || numFlightSeats <= 0)
            {
                MessageBox.Show("Number of seats must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
