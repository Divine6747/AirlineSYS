using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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

        public static int getNextSeatNumber(string flightNumber)
        {
            int nextSeatNumber = 1;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT MAX(SeatNum) FROM Bookings WHERE FlightNumber = :flightNumber";

                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.Parameters.Add("flightNumber", OracleDbType.Varchar2).Value = flightNumber;

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

    }
}
