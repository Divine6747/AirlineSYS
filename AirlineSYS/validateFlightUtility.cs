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
        public static bool validateFlightField(ComboBox cboDeptAirport, ComboBox cboArrAirport, string operatorCode, string numFlightSeats, string ticketPrice, DateTime deptDateTime)
        {
            if (cboDeptAirport.SelectedItem == null || cboArrAirport.SelectedItem == null || string.IsNullOrEmpty(operatorCode) || string.IsNullOrEmpty(numFlightSeats) || string.IsNullOrEmpty(ticketPrice) || deptDateTime <= DateTime.Now || 
                cboDeptAirport.SelectedItem.ToString().Equals(cboDeptAirport.SelectedItem.ToString()) || cboArrAirport.SelectedItem.ToString().Equals(cboArrAirport.SelectedItem.ToString()) || !numFlightSeats.All(char.IsDigit) || int.Parse(numFlightSeats) < 70 || !decimal.TryParse(ticketPrice, out decimal ticketPriceDecimal) ||ticketPrice.Length > 900)
            {
                return true;
            }
            return false;
        }
    }
}
