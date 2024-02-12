using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;

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

        public void addAirport()
        {

            //Opens the db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "INSERT INTO Airports (AirportCode, Name, Street, City, Country, Eircode, Phone, Email) VALUES (" +
                "'" + this.AirportCode + "', '" +
                this.Name + "', '" +
                this.Street + "', '" +
                this.City + "', '" +
                this.Country + "', '" +
                this.Eircode + "', '" +
                this.Phone + "', '" +
                this.Email + "')";


            //Execute the SQL query to be executed
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();


        }

    }

}
