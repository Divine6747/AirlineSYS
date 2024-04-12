using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    string sqlQuery = "SELECT MAX(PassengerID) FROM Passenger";

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
    }
}
