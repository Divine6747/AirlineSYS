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
        public static bool ValidateFlightField(int numFlightSeats, DateTime deptDate, ComboBox cboDeptTime, string estArrTime)
        {
            if (deptDate <= DateTime.Now)
            { 
                MessageBox.Show("Departure date must be greater than the current date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
