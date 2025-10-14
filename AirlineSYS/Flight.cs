﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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

        // Getters
        public string getFlightNumber() { return FlightNumber; }
        public string getOperatorCode() { return OperatorCode; }
        public int getRouteID() { return RouteID; }
        public DateTime getFlightDate() { return FlightDate; }
        public string getFlightTime() { return FlightTime; }
        public string getEstArrTime() { return EstArrTime; }
        public int getNumSeats() { return NumSeats; }
        public int getNumSeatAvail() { return NumSeatAvail; }
        public string getStatus() { return Status; }
        
        //Setters
        public void setFlightNumber(string flightNumber) { FlightNumber = flightNumber; }
        public void setOperatorCode(string operatorCode) { OperatorCode = operatorCode; }
        public void setRouteID(int routeID) { RouteID = routeID; }
        public void setFlightDate(DateTime flightDate) { FlightDate = flightDate; }
        public void setFlightTime(string flightTime) { FlightTime = flightTime; }
        public void setEstArrTime(string estArrTime) { EstArrTime = estArrTime; }
        public void setNumSeats(int numSeats) { NumSeats = numSeats; }
        public void setNumSeatAvail(int numSeatAvail) { NumSeatAvail = numSeatAvail; }
        public void setStatus(string status) { Status = status; }

        //Scheduling Flight
        public void scheduleFlight()
        {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        //Retrieving and incrementing flight number
        public static string getFlightNumber(string selectedOperatorCode)
        {
            string sqlQuery = "SELECT MAX(SUBSTR(FlightNumber, LENGTH('" + selectedOperatorCode + "') + 1)) " + "FROM Flights ";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            int maxFlightNumber = 0;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read() && !reader.IsDBNull(0) && int.TryParse(reader.GetString(0), out maxFlightNumber))
                {
                    maxFlightNumber++;
                }

                string paddedFlightNumber = maxFlightNumber.ToString("D4");
                return selectedOperatorCode + paddedFlightNumber;
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
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return selectedOperatorCode + "0000";
        }
        //Update Flight
        public void updateFlight(string flightNumber)
        {
            string sqlQuery = "UPDATE Flights SET " +
                              "OperatorCode = :operatorCode, " +
                              "FlightDate = :flightDate, " +
                              "FlightTime = :flightTime, " +
                              "EstArrTime = :estArrTime, " +
                              "NumSeats = :numSeats, " +
                              "NumSeatAvail = :numSeatAvail, " +
                              "Status = :status " +
                              "WHERE FlightNumber = :flightNumber";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
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

            string sqlQuery = "SELECT F.FlightNumber, F.OperatorCode, O.Name AS OperatorName, " +
                               "F.RouteID, F.FlightDate, F.FlightTime, F.EstArrTime, " +
                               "F.NumSeats, F.NumSeatAvail, F.Status, " +
                               "R.DeptAirport, R.ArrAirport " +
                               "FROM Flights F " +
                               "JOIN Routes R ON F.RouteID = R.RouteID " +
                               "JOIN Operators O ON F.OperatorCode = O.OperatorCode " +
                               "WHERE F.Status = 'A' AND F.FlightDate > SYSDATE";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

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
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return flights;
        }
        //Cancelling Flight
        public void cancelFlight(string flightNumber)
        {
            string sqlCheckScheduled = "SELECT COUNT(*) FROM Bookings WHERE FlightNumber = :flightNumber AND FlightDate > SYSDATE";
            string sqlCancelFlight = "UPDATE Flights SET Status = 'I' WHERE FlightNumber = :flightNumber";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmdCheck = new OracleCommand(sqlCheckScheduled, conn);
            OracleCommand cmdCancel = new OracleCommand(sqlCancelFlight, conn);

            cmdCheck.Parameters.Add(":flightNumber", OracleDbType.Varchar2).Value = flightNumber;
            cmdCancel.Parameters.Add(":flightNumber", OracleDbType.Varchar2).Value = flightNumber;

            try
            {
                conn.Open();

                //Checking if the flight is Booked by a passenger
                OracleDataReader reader = cmdCheck.ExecuteReader();
                int scheduledCount = 0;
                if (reader.Read())
                {
                    scheduledCount = reader.GetInt32(0);
                }
                reader.Close();

                if (scheduledCount > 0)
                {
                    MessageBox.Show("Cannot cancel the flight as it is already scheduled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // If the flight is not scheduled, then cancel it
                int rowsAffected = cmdCancel.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Flight has been canceled in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //Getting Available flights
        public static List<string[]> getAvailableFlights(int routeID)
        {
            List<string[]> flights = new List<string[]>();

            string sqlQuery = "SELECT f.FlightNumber, r.DeptAirport, r.ArrAirport, f.FlightDate, f.FlightTime, f.EstArrTime " +
                              "FROM Flights f " +
                              "JOIN Routes r ON f.RouteID = r.RouteID " +
                              "WHERE f.Status = 'A' AND r.RouteID = :RouteID AND f.FlightDate > SYSDATE";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            cmd.Parameters.Add(":RouteID", OracleDbType.Int32).Value = routeID;

            try
            {
                conn.Open();                                

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string flightNumber = reader.GetString(0);
                    string deptAirport = reader.GetString(1);
                    string arrAirport = reader.GetString(2);
                    string flightDate = reader.GetDateTime(3).ToString("dd-MMM-yyyy");
                    string flightTime = reader.GetString(4);
                    string estArrTime = reader.GetString(5);

                    flights.Add(new string[] { flightNumber, deptAirport, arrAirport, flightDate, flightTime, estArrTime });
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
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return flights;
        }

        public static List<Flight> getActiveFlights()
        {
            List<Flight> activeFlights = new List<Flight>();

            string sqlQuery = "SELECT FlightNumber, OperatorCode, RouteID, FlightDate, FlightTime, EstArrTime, " +
                              "NumSeats, NumSeatAvail, Status " +
                              "FROM Flights " +
                              "WHERE Status = 'A' AND FlightDate > SYSDATE";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string flightNumber = reader.GetString(0);
                    string operatorCode = reader.GetString(1);
                    int routeID = reader.GetInt32(2);
                    DateTime flightDate = reader.GetDateTime(3);
                    string flightTime = reader.GetString(4);
                    string estArrTime = reader.GetString(5);
                    int numSeats = reader.GetInt32(6);
                    int numSeatAvail = reader.GetInt32(7);
                    string status = reader.GetString(8);

                    Flight flight = new Flight(flightNumber, operatorCode, routeID, flightDate, flightTime, estArrTime, numSeats, numSeatAvail, status);
                    activeFlights.Add(flight);
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
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return activeFlights;
        }

    }
}



