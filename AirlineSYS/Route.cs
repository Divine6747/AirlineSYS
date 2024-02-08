using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

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
        private string Address;
        private int Phone;
        private string Email;
        private string Status;


        public Airport()
        {
            this.AirportCode = "";
            this.Name = "";
            this.Street = "";
            this.City = "";
            this.Country = "";
            this.Eircode = "";
            this.Address = "";
            this.Phone = 0;
            this.Email = "";
            this.Status = "";
        }

        public Airport(string airportCode, string name, string street, string city, string country, string eircode, string address, int phone, string email, string status)
        {
            AirportCode = airportCode;
            Name = name;
            Street = street;
            City = city;
            Country = country;
            Eircode = eircode;
            Address = address;
            Phone = phone;
            Email = email;
            Status = status;
        }

        //These are the getters
    
        public string getAirportCode() { return this.AirportCode;}

        public string getName() { return this.Name;}

        public string getStreet() { return this.Street;}

        public string getCity() { return this.City;}

        public string getCountry() { return this.Country;}

        public string getEircode() {  return this.Eircode;}

        public string getAddress() { return this.Address;}

        public int getPhone() { return this.Phone;}
        
        public string getEmail() { return this.Email;}

        public string getStatus() { return this.Status;}


        //These are the setters
        public void setAirportCode(string AirportCode) { this.AirportCode = airportCode;}

        public void setName(string Name) { this.Name = Name;}

        public void setStreet(string Street) { this.Street = Street; }

        public void setCity(string City) { this.City = City; }

        public void setCountry(string Country) { this.Country = Country; }

        public void setEircode(string Eircode) { this.Eircode = Eircode; }

        public void setAddress(string Address) { this.Address = Address; }

        public void setPhone(int Phone) { this.Phone = Phone; }

        public void setEmail(string Email) { this.Email = Email; }

        public void setStatus(string Status) { this.Status = Status; }


    
    }
    class Operators
    {
        private string OperatorCode;
        private string Name;
        private string City;
        private string Country;
        private string Status;

        public Operators()
        {
            this.OperatorCode = "";
            this.Name = "";
            this.City = "";
            this.Country = "";
            this.Status = "";
        }

        public Operators(string operatorCode, string name, string city, string country, string status)
        {
            OperatorCode = operatorCode;
            Name = name;
            City = city;
            Country = country;
            Status = status;
        }

        public string getOperatorCode() {  return OperatorCode; }

        public string getName() { return Name; }

        public string getCity() { return City; }

        public string getCountry() { return Country; }

        public string getStatus() { return Status; }

    }
}
