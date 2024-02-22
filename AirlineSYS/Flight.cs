using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineSYS
{
    class Flight
    {
        private string FlightNumber;
        private int RouteID;
        private DateTime FlightDate;
        private DateTime FlightTime;
        private string EstArrTime;
        private int numSeats;
        private int numSeatAvail;
        private string Status;


        public string getFlightNumber() { return this.FlightNumber; }
        public int getRouteID() { return this.RouteID; }
        public DateTime getFlightdate() { return this.FlightDate; }
        public int getEstArrTime() { return this.EstArrTime; }
        public int getNumSeats() {  return this.numSeats; }
        public int getNumSeatAvail() { return this.numSeatAvail; }
        public string getStatus() { return this.Status; }



        public Flight() {

            this.FlightNumber = "";
            this.RouteID = 0;
            this.FlightDate = "";
            this.FlightTime = "";
            this.EstArrTime = "";
            this.numSeats = 0;
            this.numSeatAvail = 0;
            this.Status = "";

        }

        public Flight(string flightNumber, int routeID, string flightDate, string flightTime, string estArrTime, int numSeats, int numSeatAvail, string status)
        {
            FlightNumber = flightNumber;
            RouteID = routeID;
            FlightDate = flightDate;
            FlightTime = flightTime;
            EstArrTime = estArrTime;
            this.numSeats = numSeats;
            this.numSeatAvail = numSeatAvail;
            Status = status;
        }


    }
}
