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
    class Booking
    {
        private int BookingID;
        private int PassengerID;
        private int RouteID;
        private string FlightNumber;
        private string FlightTime;
        private DateTime FlightDate;
        private int SeatNum;
        private int NumBaggage;
        private decimal AmountPaid;
        private string Status;

        public Booking()
        {
            BookingID = 0;
            PassengerID = 0;
            RouteID = 0;
            FlightNumber = "";
            FlightTime = "";
            FlightDate = DateTime.Now;
            SeatNum = 0;
            NumBaggage = 0;
            AmountPaid = 0;
            Status = "";
        }

        public Booking(int bookingID, int passengerID, int routeID, string flightNumber, string flightTime, DateTime flightDate, int seatNum, int numBaggage, decimal amountPaid, string status)
        {
            BookingID = bookingID;
            PassengerID = passengerID;
            RouteID = routeID;
            FlightNumber = flightNumber;
            FlightTime = flightTime;
            FlightDate = flightDate;
            SeatNum = seatNum;
            NumBaggage = numBaggage;
            AmountPaid = amountPaid;
            Status = status;
        }

        // Getter methods
        public int GetBookingID() { return BookingID; }
        public int GetPassengerID() { return PassengerID; }
        public int GetRouteID() { return RouteID; }
        public string GetFlightNumber() { return FlightNumber; }
        public string GetFlightTime() { return FlightTime; }
        public DateTime GetFlightDate() { return FlightDate; }
        public int GetSeatNum() { return SeatNum; }
        public int GetNumBaggage() { return NumBaggage; }
        public decimal GetAmountPaid() { return AmountPaid; }
        public string GetStatus() { return Status; }

        // Setter methods
        public void SetBookingID(int bookingID) { BookingID = bookingID; }
        public void SetPassengerID(int passengerID) { PassengerID = passengerID; }
        public void SetRouteID(int routeID) { RouteID = routeID; }
        public void SetFlightNumber(string flightNumber) { FlightNumber = flightNumber; }
        public void SetFlightTime(string flightTime) { FlightTime = flightTime; }
        public void SetFlightDate(DateTime flightDate) { FlightDate = flightDate; }
        public void SetSeatNum(int seatNum) { SeatNum = seatNum; }
        public void SetNumBaggage(int numBaggage) { NumBaggage = numBaggage; }
        public void SetAmountPaid(decimal amountPaid) { AmountPaid = amountPaid; }
        public void SetStatus(string status) { Status = status; }

        public static int getNextBookingID()
        {
            int nextBookingID = 1;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT MAX(BookingID) FROM Bookings";

                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            nextBookingID = reader.GetInt32(0) + 1;
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
            return nextBookingID;
        }
        public static int getNextSeatNumber(string flightNumber, int routeID)
        {
            int nextSeatNumber = 1;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT MAX(SeatNum) FROM Bookings WHERE FlightNumber = :flightNumber AND RouteID = :routeID";

                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.Parameters.Add(":flightNumber", OracleDbType.Varchar2).Value = flightNumber;
                    cmd.Parameters.Add(":routeID", OracleDbType.Int32).Value = routeID;

                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            nextSeatNumber = reader.GetInt32(0) + 1;
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
            return nextSeatNumber;
        }

        public void addBooking()
        {
            string sqlQuery = "INSERT INTO Bookings (BookingID, PassengerID, RouteID, FlightNumber, FlightTime, FlightDate, SeatNum, NumBaggage, AmountPaid, Status) " +
                              "VALUES (:BookingID, :PassengerID, :RouteID, :FlightNumber, :FlightTime, :FlightDate, :SeatNum, :NumBaggage, :AmountPaid, :Status)";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":BookingID", OracleDbType.Int32).Value = BookingID;
                    cmd.Parameters.Add(":PassengerID", OracleDbType.Int32).Value = PassengerID;
                    cmd.Parameters.Add(":RouteID", OracleDbType.Int32).Value = RouteID;
                    cmd.Parameters.Add(":FlightNumber", OracleDbType.Varchar2).Value = FlightNumber;
                    cmd.Parameters.Add(":FlightTime", OracleDbType.Varchar2).Value = FlightTime;
                    cmd.Parameters.Add(":FlightDate", OracleDbType.Date).Value = FlightDate;
                    cmd.Parameters.Add(":SeatNum", OracleDbType.Int32).Value = SeatNum;
                    cmd.Parameters.Add(":NumBaggage", OracleDbType.Int32).Value = NumBaggage;
                    cmd.Parameters.Add(":AmountPaid", OracleDbType.Decimal).Value = AmountPaid;
                    cmd.Parameters.Add(":Status", OracleDbType.Varchar2).Value = Status;

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Booking has been added to the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public static bool decreaseAvailableSeats(string flightNumber, int seats)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "UPDATE Flights SET NUMSEATAVAIL = NUMSEATAVAIL - :seatsToDecrease WHERE FLIGHTNUMBER = :flightNumber";

                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.Parameters.Add(new OracleParameter("seatsToDecrease", seats));
                    cmd.Parameters.Add(new OracleParameter("flightNumber", flightNumber));

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable findBookingDetails(int bookingID)
        {
            DataTable dt = new DataTable();

            string sqlQuery = "SELECT b.BookingID, b.PassengerID, b.RouteID, b.FlightNumber, b.FlightTime, b.FlightDate, " +
                              "b.SeatNum, b.NumBaggage, b.AmountPaid, " +
                              "p.forename, p.surname, p.Email, p.DateOfBirth, p.Phone, p.Eircode " +
                              "FROM Bookings b " +
                              "JOIN Passengers p ON b.PassengerID = p.PassengerID " +
                              "WHERE b.BookingID = :bookingID";
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.Add(":bookingID", OracleDbType.Int32).Value = bookingID;

                        conn.Open();

                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        adapter.Fill(dt);
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

            return dt;
        }
        public void updateBooking()
        {
            string sqlQuery = "UPDATE Bookings SET " +
                              "PassengerID = :PassengerID, " +
                              "RouteID = :RouteID, " +
                              "FlightNumber = :FlightNumber, " +
                              "FlightTime = :FlightTime, " +
                              "FlightDate = :FlightDate, " +
                              "SeatNum = :SeatNum, " +
                              "NumBaggage = :NumBaggage, " +
                              "AmountPaid = :AmountPaid, " +
                              "Status = :Status " +
                              "WHERE BookingID = :BookingID";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":PassengerID", OracleDbType.Int32).Value = PassengerID;
                    cmd.Parameters.Add(":RouteID", OracleDbType.Int32).Value = RouteID;
                    cmd.Parameters.Add(":FlightNumber", OracleDbType.Varchar2).Value = FlightNumber;
                    cmd.Parameters.Add(":FlightTime", OracleDbType.Varchar2).Value = FlightTime;
                    cmd.Parameters.Add(":FlightDate", OracleDbType.Date).Value = FlightDate;
                    cmd.Parameters.Add(":SeatNum", OracleDbType.Int32).Value = SeatNum;
                    cmd.Parameters.Add(":NumBaggage", OracleDbType.Int32).Value = NumBaggage;
                    cmd.Parameters.Add(":AmountPaid", OracleDbType.Decimal).Value = AmountPaid;
                    cmd.Parameters.Add(":Status", OracleDbType.Varchar2).Value = Status;
                    cmd.Parameters.Add(":BookingID", OracleDbType.Int32).Value = BookingID;

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booking details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Booking ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
        public void cancelBooking(int bookingID, string forename, string surname, string email)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "UPDATE Bookings SET Status = 'CANCELLED' WHERE BookingID = :bookingID AND PassengerID IN (SELECT PassengerID FROM Passengers WHERE Forename = :forename AND Surname = :surname AND Email = :email)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(":bookingID", OracleDbType.Int32).Value = bookingID;
            cmd.Parameters.Add(":forename", OracleDbType.Varchar2).Value = forename;
            cmd.Parameters.Add(":surname", OracleDbType.Varchar2).Value = surname;
            cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Booking cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Booking not found or passenger details incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
