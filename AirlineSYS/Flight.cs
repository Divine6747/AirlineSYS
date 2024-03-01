using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    class Flight
    {
        private string FlightNumber;
        private string OperatorCode;
        private int RouteID;
        private DateTime FlightDate;
        private DateTime FlightTime;
        private string EstArrTime;
        private int NumSeats;
        private int NumSeatAvail;
        private string Status;

        public Flight()
        {
            FlightNumber = "";
            OperatorCode = "";
            RouteID = 0;
            FlightDate = DateTime.Now;
            FlightTime = DateTime.Now;
            EstArrTime = "";
            NumSeats = 0;
            NumSeatAvail = 0;
            Status = "";
        }

        public Flight(string flightNumber, string operatorCode, int routeID, DateTime flightDate, DateTime flightTime, string estArrTime, int numSeats, int numSeatAvail, string status)
        {
            FlightNumber = flightNumber;
            OperatorCode = operatorCode;
            RouteID = routeID;
            FlightDate = flightDate;
            FlightTime = flightTime;
            EstArrTime = estArrTime;
            NumSeats = numSeats;
            NumSeatAvail = numSeatAvail;
            Status = status;
        }

        // Getter methods
        public string getFlightNumber() { return FlightNumber; }

        public string getOperatorCode() { return OperatorCode; }

        public int getRouteID() { return RouteID; }

        public DateTime getFlightDate() { return FlightDate; }

        public DateTime getFlightTime() { return FlightTime; }

        public string getEstArrTime() { return EstArrTime; }

        public int getNumSeats() { return NumSeats; }

        public int getNumSeatAvail() { return NumSeatAvail; }

        public string getStatus() { return Status; }

        // Setter methods
        public void setFlightNumber(string flightNumber) { FlightNumber = flightNumber; }

        public void setOperatorCode(string operatorCode) { OperatorCode = operatorCode; }

        public void setRouteID(int routeID) { RouteID = routeID; }

        public void setFlightDate(DateTime flightDate) { FlightDate = flightDate; }

        public void setFlightTime(DateTime flightTime) { FlightTime = flightTime; }

        public void setEstArrTime(string estArrTime) { EstArrTime = estArrTime; }

        public void setNumSeats(int numSeats) { NumSeats = numSeats; }

        public void setNumSeatAvail(int numSeatAvail) { NumSeatAvail = numSeatAvail; }

        public void setStatus(string status) { Status = status; }


        public static string getFlightNumber(string selectedOperatorCode)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT MAX(SUBSTRING(FlightNumber, 3, LEN(FlightNumber) - 2)) " +
                                  "FROM Flights " +
                                  "WHERE SUBSTRING(FlightNumber, 1, 2) = '" + selectedOperatorCode + "'";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                try
                {
                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            object result = reader[0];

                            int maxFlightNumber;
                            if (result != DBNull.Value && int.TryParse(result.ToString(), out maxFlightNumber))
                            {
                                maxFlightNumber = Convert.ToInt32(result);
                            }
                            else
                            {
                                maxFlightNumber = 0;
                            }

                            string nextFlightNumber = selectedOperatorCode + (maxFlightNumber + 1).ToString("D4");
                            return nextFlightNumber;
                        }
                        else
                        {
                            return selectedOperatorCode + "0001";
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    throw ex;
                }
            }
        }


    }
}
