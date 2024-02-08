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
        private String AirportCode;
        private String Name;
        private String Street;
        private String City;
        private String Country;
        private String Eircode;
        private String Address;
        private int Phone;
        private String Email;
        private String Status;

        


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
    
        public String getAirportCode() { return this.AirportCode;}

        public String getName() { return this.Name;}

        public String getStreet() { return this.Street;}

        public String getCity() { return this.City;}

        public String getCountry() { return this.Country;}

        public String getEircode() {  return this.Eircode;}

        public String getAddress() { return this.Address;}

        public int getPhone() { return this.Phone;}
        
        public String getEmail() { return this.Email;}

        public String getStatus() { return this.Status;}


        //These are the setters
        public void setAirportCode(String AirportCode) { this.AirportCode = airportCode;}

        public void setName(String Name) { this.Name = Name;}

        public void setStreet(String Street) { this.Street = Street; }

        public void setCity(String City) { this.City = City; }

        public void setCountry(String Country) { this.Country = Country; }

        public void setEircode(String Eircode) { this.Eircode = Eircode; }

        public void setAddress(String Address) { this.Address = Address; }

        public void setPhone(int Phone) { this.Phone = Phone; }

        public void setEmail(String Email) { this.Email = Email; }

        public void setStatus(String Status) { this.Status = Status; }


    
    }
    class Operators
    {
        private String OperatorCode;
        private String Name;
        private String City;
        private String Country;
        private String Status;

        public Operators()
        {
            this.OperatorCode = "";
            this.Name = "";
            this.City = "";
            this.Country = "";
            this.Status = "";
        }

        public Operators(String operatorCode, String name, String city, String country, String status)
        {
            OperatorCode = operatorCode;
            Name = name;
            City = city;
            Country = country;
            Status = status;
        }

        public String getOperatorCode() {  return OperatorCode; }

        public String getName() { return Name; }

        public String getCity() { return City; }

        public String getCountry() { return Country; }

        public String getStatus() { return Status; }

    }
}
