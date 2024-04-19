using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public static class ValidateRoute
    {
        public static bool ValidateRouteFields(string routeID, string departureAirport, string arrivalAirport, string durationStr, string ticketPriceStr, string[] availableAirports)
        {
            int duration;
            decimal ticketPrice;

            // Check if any field is empty
            if (string.IsNullOrEmpty(routeID) || string.IsNullOrEmpty(departureAirport) ||
                string.IsNullOrEmpty(arrivalAirport) || string.IsNullOrEmpty(durationStr) ||
                string.IsNullOrEmpty(ticketPriceStr))
            {
                MessageBox.Show("All required fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if departure and arrival airports are different
            if (departureAirport.Equals(arrivalAirport))
            {
                MessageBox.Show("Departure Airport and Arrival Airport cannot be the same.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if duration is a valid positive number
            if (!int.TryParse(durationStr, out duration) || duration <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if ticket price is a valid positive number
            if (!decimal.TryParse(ticketPriceStr, out ticketPrice) || ticketPrice <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Ticket Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if departure airport is valid
            if (!availableAirports.Contains(departureAirport))
            {
                MessageBox.Show("Departure airport is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if arrival airport is valid
            if (!availableAirports.Contains(arrivalAirport))
            {
                MessageBox.Show("Arrival airport is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }          

            return true;
        }

    }
}
