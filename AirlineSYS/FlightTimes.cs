using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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

            string sqlQuery = "SELECT FLIGHTTIME FROM FLIGHTTIMES";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery,conn);
            OracleDataReader reader = null;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string flightTime = reader.GetString(0);
                    flightTimes.Add(new FlightTimes { FlightTime = flightTime });
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
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return flightTimes;
        }
    }
}
    
