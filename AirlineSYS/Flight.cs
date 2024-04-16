using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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
        private string FlightTime;
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
            FlightTime = "";
            EstArrTime = "";
            NumSeats = 0;
            NumSeatAvail = 0;
            Status = "";

        }
        public Flight(string flightNumber, string operatorCode, int routeID, DateTime flightDate, string flightTime, string estArrTime, int numSeats, int numSeatAvail, string status)
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
        public string getFlightTime() { return FlightTime; }
        public string getEstArrTime() { return EstArrTime; }
        public int getNumSeats() { return NumSeats; }
        public int getNumSeatAvail() { return NumSeatAvail; }
        public string getStatus() { return Status; }

        // Setter methods
        public void setFlightNumber(string flightNumber) { FlightNumber = flightNumber; }
        public void setOperatorCode(string operatorCode) { OperatorCode = operatorCode; }
        public void setRouteID(int routeID) { RouteID = routeID; }
        public void setFlightDate(DateTime flightDate) { FlightDate = flightDate; }
        public void setFlightTime(string flightTime) { FlightTime = flightTime; }
        public void setEstArrTime(string estArrTime) { EstArrTime = estArrTime; }
        public void setNumSeats(int numSeats) { NumSeats = numSeats; }
        public void setNumSeatAvail(int numSeatAvail) { NumSeatAvail = numSeatAvail; }
        public void setStatus(string status) { Status = status; }

        public void scheduleFlight()
        {
            string flightDateFormat = FlightDate.ToString("dd-MMM-yy", CultureInfo.InvariantCulture).ToUpper();

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            
            string sqlQuery = "INSERT INTO FLIGHTS (FlightNumber, OperatorCode, RouteID, FlightDate, FlightTime, EstArrTime, NumSeats, NumSeatAvail, Status) " +
                                "VALUES (:flightNumber, :operatorCode, :routeID, :flightDate, :flightTime, :estArrTime, :numSeats, :numSeatsAvail, :status)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(":flightNumber", OracleDbType.Varchar2).Value = FlightNumber;
            cmd.Parameters.Add(":operatorCode", OracleDbType.Varchar2).Value = OperatorCode;
            cmd.Parameters.Add(":routeID", OracleDbType.Int32).Value = RouteID;
            cmd.Parameters.Add(":flightDate", OracleDbType.Date).Value = FlightDate;
            cmd.Parameters.Add(":flightTime", OracleDbType.Varchar2).Value = FlightTime;
            cmd.Parameters.Add(":estArrTime", OracleDbType.Varchar2).Value = EstArrTime;
            cmd.Parameters.Add(":numSeats", OracleDbType.Int32).Value = NumSeats;
            cmd.Parameters.Add(":numSeatsAvail", OracleDbType.Int32).Value = NumSeatAvail;
            cmd.Parameters.Add(":status", OracleDbType.Varchar2).Value = Status;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Flight has been scheduled", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            finally
            {
                conn.Close();
            }            
        }

        //Retrieving and incrementing flight number
        public static string getFlightNumber(string selectedOperatorCode)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT MAX(SUBSTR(FlightNumber, LENGTH('" + selectedOperatorCode + "') + 1)) " + "FROM Flights ";

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

                            maxFlightNumber++;

                            string paddedFlightNumber = maxFlightNumber.ToString("D4");

                            string nextFlightNumber = selectedOperatorCode + paddedFlightNumber;

                            return nextFlightNumber;
                        }
                        else
                        {
                            return selectedOperatorCode + "0000";
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
        public void updateFlight(string flightNumber)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "UPDATE Flights SET " +
                              "OperatorCode = :operatorCode, " +
                              "FlightDate = :flightDate, " +
                              "FlightTime = :flightTime, " +
                              "EstArrTime = :estArrTime, " +
                              "NumSeats = :numSeats, " +
                              "NumSeatAvail = :numSeatAvail, " +
                              "Status = :status " +
                              "WHERE FlightNumber = :flightNumber";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(":operatorCode", OracleDbType.Varchar2).Value = OperatorCode;
            cmd.Parameters.Add(":flightDate", OracleDbType.Date).Value = FlightDate;
            cmd.Parameters.Add(":flightTime", OracleDbType.Varchar2).Value = FlightTime;
            cmd.Parameters.Add(":estArrTime", OracleDbType.Varchar2).Value = EstArrTime;
            cmd.Parameters.Add(":numSeats", OracleDbType.Int32).Value = NumSeats;
            cmd.Parameters.Add(":numSeatAvail", OracleDbType.Int32).Value = NumSeatAvail;
            cmd.Parameters.Add(":status", OracleDbType.Varchar2).Value = Status;
            cmd.Parameters.Add(":flightNumber", OracleDbType.Varchar2).Value = flightNumber;

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Flight details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Flight number not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public static List<Flight> getAllFlightDetails()
        {
            List<Flight> flights = new List<Flight>();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT F.FlightNumber, F.OperatorCode, O.Name AS OperatorName, " +
                                      "F.RouteID, F.FlightDate, F.FlightTime, F.EstArrTime, " +
                                      "F.NumSeats, F.NumSeatAvail, F.Status, " +
                                      "R.DeptAirport, R.ArrAirport " +
                                      "FROM Flights F " +
                                      "JOIN Routes R ON F.RouteID = R.RouteID " +
                                      "JOIN Operators O ON F.OperatorCode = O.OperatorCode";

                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        conn.Open();

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string flightNumber = reader.GetString(0);
                                string operatorCode = reader.GetString(1);
                                int routeID = reader.GetInt32(3);
                                DateTime flightDate = reader.GetDateTime(4);
                                string flightTime = reader.GetString(5);
                                string estArrTime = reader.GetString(6);
                                int numSeats = reader.GetInt32(7);
                                int numSeatAvail = reader.GetInt32(8);
                                string status = reader.GetString(9);

                                flights.Add(new Flight
                                {
                                    FlightNumber = flightNumber,
                                    OperatorCode = operatorCode,
                                    RouteID = routeID,
                                    FlightDate = flightDate,
                                    FlightTime = flightTime,
                                    EstArrTime = estArrTime,
                                    NumSeats = numSeats,
                                    NumSeatAvail = numSeatAvail,
                                    Status = status
                                });
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return flights;
        }


        public int  getAirportDept(int routeID)
        {
            string deptAirport = "";
            string arrAirport = "";

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT DeptAirport, ArrAirport FROM Routes WHERE RouteID = :RouteID";
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.Parameters.Add(":RouteID", OracleDbType.Int32).Value = routeID;
                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            deptAirport = reader.GetString(0);
                            arrAirport = reader.GetString(1);
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return routeID;
        }
        public void cancelFlight(string flightNumber)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "UPDATE Flights SET Status = 'I' WHERE FlightNumber = :flightNumber";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.Parameters.Add(":flightNumber", OracleDbType.Varchar2).Value = flightNumber;

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Flight canceled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Flight number not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static List<string[]> GetAvailableFlights(int routeID)
        {
            List<string[]> flights = new List<string[]>();

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT f.FlightNumber, r.DeptAirport, r.ArrAirport, f.FlightDate, f.FlightTime " +
                              "FROM Flights f " +
                              "JOIN Routes r ON f.RouteID = r.RouteID " +
                              "WHERE f.Status = 'A' AND r.RouteID = :RouteID";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.Parameters.Add(":RouteID", OracleDbType.Int32).Value = routeID;

                try
                {
                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string flightNumber = reader.GetString(0);
                            string deptAirport = reader.GetString(1);
                            string arrAirport = reader.GetString(2);
                            string flightDate = reader.GetDateTime(3).ToString("dd-MMM-yyyy");
                            string flightTime = reader.GetString(4);

                            flights.Add(new string[] { flightNumber, deptAirport, arrAirport, flightDate, flightTime });
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return flights;
        }        
    }
}



