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

        /*
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
     */
        public void setAirportCode(String AirportCode) { this.AirportCode = airportCode;}
        public void setName(String Name) { Name = Name;}
        public void setStreet(String Street) { Street = Street; }
        public void setCity(String City) { City = City; }
        public void setCountry(String Country) { Country = Country; }
        public void setEircode(String Eircode) { Eircode = Eircode; }
        public void setAddress(String Address) { Address = Address; }
        public void setPhone(int Phone) { Phone = Phone; }
        public void setEmail(String Email) { Email = Email; }
        public void setStatus(String Status) { Status = Status; }

        

    
    }
}
