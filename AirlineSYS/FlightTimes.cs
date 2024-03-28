using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    class FlightTimes
    {
        private string FlightTime;
        
        public FlightTimes()
        {
            FlightTime = "";
        }

        public FlightTimes(string flightTime)
        {
            FlightTime = flightTime;
        }
        //Getter
        public string getFlightTime() { return FlightTime; }
        //setter
        public void setFlightTime(string flightTime) {  FlightTime = flightTime; }

        //Geting Flight Tiime from the database
        public static List<FlightTimes> getFlightTimes()
        {
            List<FlightTimes> flightTimes = new List<FlightTimes>();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT SUBSTR(FLIGHTTIME, 1, 5) AS FLIGHTTIME FROM FLIGHTTIMES";

                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string flightT = reader.GetString(0);
                            flightTimes.Add(new FlightTimes { FlightTime = flightT });
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flightTimes;
        }
    }
}
    
