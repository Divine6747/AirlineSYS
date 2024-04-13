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
    class Passenger
    {
        private int PassengerID;
        private string Forename;
        private string Surname;
        private DateTime DateOfBirth;
        private string Email;
        private long Phone;
        private string Eircode;

        public Passenger()
        {
            PassengerID = 0;
            Forename = "";
            Surname = "";
            DateOfBirth = DateTime.Now;
            Email = "";
            Phone = 0;
            Eircode = "";
        }

        public Passenger(int passengerID, string forename, string surname, DateTime dateOfBirth, string email, long phone, string eircode)
        {
            PassengerID = passengerID;
            Forename = forename;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Email = email;
            Phone = phone;
            Eircode = eircode;
        }

        // Getter methods
        public int getPassengerID() { return PassengerID; }
        public string getForename() { return Forename; }
        public string getSurname() { return Surname; }
        public DateTime getDateOfBirth() { return DateOfBirth; }
        public string getEmail() { return Email; }
        public long getPhone() { return Phone; }
        public string getEircode() { return Eircode; }

        // Setter methods
        public void setPassengerID(int passengerID) { PassengerID = passengerID; }
        public void setForename(string forename) { Forename = forename; }
        public void setSurname(string surname) { Surname = surname; }
        public void setDateOfBirth(DateTime dateOfBirth) { DateOfBirth = dateOfBirth; }
        public void setEmail(string email) { Email = email; }
        public void setPhone(long phone) { Phone = phone; }
        public void setEircode(string eircode) { Eircode = eircode; }

        public static int getNextPassengerID()
        {
            int nextPassengerID = 1;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT MAX(PassengerID) FROM Passengers";

                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            nextPassengerID = reader.GetInt32(0) + 1;
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
            return nextPassengerID;
        }
        public static decimal getRoutePrice(string departureAirport, string arrivalAirport)
        {
            decimal ticketPrice = 0;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT TicketPrice FROM Routes WHERE DeptAirport = :deptAirport AND ArrAirport = :arrAirport";
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.Parameters.Add(":deptAirport", departureAirport);
                    cmd.Parameters.Add(":arrAirport", arrivalAirport);

                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ticketPrice = reader.GetDecimal(0);
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

            return ticketPrice;
        }
        public void addPassenger()
        {
            string sqlQuery = "INSERT INTO PASSENGERS (PASSENGERID, FORENAME, SURNAME, DATEOFBIRTH, EMAIL, PHONE, EIRCODE) " +
                              "VALUES (:PassengerID, :Forename, :Surname, :DateOfBirth, :Email, :Phone, :Eircode)";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":PassengerID", OracleDbType.Int32).Value = PassengerID;
                    cmd.Parameters.Add(":Forename", OracleDbType.Varchar2).Value = Forename;
                    cmd.Parameters.Add(":Surname", OracleDbType.Varchar2).Value = Surname;
                    cmd.Parameters.Add(":DateOfBirth", OracleDbType.Date).Value = DateOfBirth;
                    cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = Email;
                    cmd.Parameters.Add(":Phone", OracleDbType.Int32).Value = Phone;
                    cmd.Parameters.Add(":Eircode", OracleDbType.Varchar2).Value = Eircode;

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Passenger has been added to the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void updatePassenger(int passengerID)
        {
            string sqlQuery = "UPDATE Passengers SET " +
                              "Forename = :Forename, " +
                              "Surname = :Surname, " +
                              "DateOfBirth = :DateOfBirth, " +
                              "Email = :Email, " +
                              "Phone = :Phone, " +
                              "Eircode = :Eircode " +
                              "WHERE PassengerID = :PassengerID";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":Forename", OracleDbType.Varchar2).Value = Forename;
                    cmd.Parameters.Add(":Surname", OracleDbType.Varchar2).Value = Surname;
                    cmd.Parameters.Add(":DateOfBirth", OracleDbType.Date).Value = DateOfBirth;
                    cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = Email;
                    cmd.Parameters.Add(":Phone", OracleDbType.Int64).Value = Phone;
                    cmd.Parameters.Add(":Eircode", OracleDbType.Varchar2).Value = Eircode;
                    cmd.Parameters.Add(":PassengerID", OracleDbType.Int32).Value = passengerID;

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Passenger details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Passenger ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
  

    } /*catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
}
