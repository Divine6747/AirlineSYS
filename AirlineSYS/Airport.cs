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
    class Airport
    {
        private string AirportCode;
        private string Name;
        private string Street;
        private string City;
        private string Country;
        private string Eircode;
        private string Phone;
        private string Email;

        public Airport()
        {
            this.AirportCode = "";
            this.Name = "";
            this.Street = "";
            this.City = "";
            this.Country = "";
            this.Eircode = "";
            this.Phone = "";
            this.Email = "";
        }

        public Airport(string airportCode, string name, string street, string city, string country, string eircode, string phone, string email)
        {
            this.AirportCode = airportCode;
            this.Name = name;
            this.Street = street;
            this.City = city;
            this.Country = country;
            this.Eircode = eircode;
            this.Phone = phone;
            this.Email = email;
        }

        //These are the getters

        public string getAirportCode() { return this.AirportCode; }
        public string getName() { return this.Name; }
        public string getStreet() { return this.Street; }
        public string getCity() { return this.City; }
        public string getCountry() { return this.Country; }
        public string getEircode() { return this.Eircode; }
        public string getPhone() { return this.Phone; }
        public string getEmail() { return this.Email; }

        //These are the setters
        public void setAirportCode(string AirportCode) { this.AirportCode = AirportCode; }
        public void setName(string Name) { this.Name = Name; }
        public void setStreet(string Street) { this.Street = Street; }
        public void setCity(string City) { this.City = City; }
        public void setCountry(string Country) { this.Country = Country; }
        public void setEircode(string Eircode) { this.Eircode = Eircode; }
        public void setPhone(string Phone) { this.Phone = Phone; }
        public void setEmail(string Email) { this.Email = Email; }

        //Add Airport Method
        public void addAirport()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "INSERT INTO Airports VALUES (:AirportCode, :Name, :Street, :City, :Country, :Eircode, :Phone, :Email)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(":AirportCode", OracleDbType.Varchar2).Value = AirportCode;
            cmd.Parameters.Add(":Name", OracleDbType.Varchar2).Value = Name;
            cmd.Parameters.Add(":Street", OracleDbType.Varchar2).Value = Street;
            cmd.Parameters.Add(":City", OracleDbType.Varchar2).Value = City;
            cmd.Parameters.Add(":Country", OracleDbType.Varchar2).Value = Country;
            cmd.Parameters.Add(":Eircode", OracleDbType.Varchar2).Value = Eircode;
            cmd.Parameters.Add(":Phone", OracleDbType.Varchar2).Value = Phone;
            cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = Email;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Airport was added successfully!", "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                conn.Close();
            }
        }
        public static List<string> getAvailAirports()
        {
            List<string> availAirports = new List<string>();

            string sqlQuery = "SELECT AirportCode FROM Airports";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            try
            {
                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string airportCode = reader.GetString(0);
                    availAirports.Add(airportCode);
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

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return availAirports;
        }
        public static bool checkAirportExists(string airportCode)
        {
            string sqlQuery = "SELECT AirportCode FROM Airports WHERE AirportCode = :AirportCode";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            cmd.Parameters.Add(":AirportCode", OracleDbType.Varchar2).Value = airportCode;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                return reader.Read();
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
        }
    }
}
