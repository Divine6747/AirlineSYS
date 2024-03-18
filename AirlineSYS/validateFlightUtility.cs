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
        public static bool validateFlightField(ComboBox cboDeptAirport, ComboBox cboArrAirport, string operatorCode, string numFlightSeats, string ticketPrice, DateTime deptDate, ComboBox cboDeptTime)
        {
            if (cboDeptAirport.SelectedItem == null || cboArrAirport.SelectedItem == null || string.IsNullOrEmpty(operatorCode) || string.IsNullOrEmpty(numFlightSeats) || string.IsNullOrEmpty(ticketPrice) || deptDate <= DateTime.Now || cboDeptTime.SelectedItem == null)
            {
                return false;
            }

            if (cboDeptAirport.SelectedItem.Equals(cboArrAirport.SelectedItem))
            {
                MessageBox.Show("Departure and Arrival Airport can not be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(!int.TryParse(numFlightSeats, out int flightSeats) || flightSeats < 70)
            {
                MessageBox.Show("Number of seats must be greater than 69 seats and ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(!decimal.TryParse(ticketPrice, out decimal DecimalTcketPrice))
            {
                MessageBox.Show("Ticket Price must be decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;            
        }
    }
}
