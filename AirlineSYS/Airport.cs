using System;
using System.Collections.Generic;
using System.Linq;
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
        public string GetAirportCode(String countryCode);
        

    
    }
}
