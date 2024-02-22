using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirlineSYS
{
    class Flight
    {
        private string FlightNumber;
        private int RouteID;
        private DateTime FlightDate;
        private DateTime FlightTime;
        private string EstArrTime;
        private int NumSeats;
        private int NumSeatAvail;
        private string Status;


        public Flight(string flightNumber, int routeID, DateTime flightDate, DateTime flightTime, string estArrTime, int numSeats, int numSeatAvail, string status)
        {
            FlightNumber = "";
            RouteID = 0;
            FlightDate = DateTime.Now;
            FlightTime = DateTime.Now;
            EstArrTime = "";
            NumSeats = 0;
            NumSeatAvail = 0;
            Status = "";
        }



        public Flight(string flightNumber, int routeID, DateTime flightDate, DateTime flightTime, string estArrTime, int numSeats, int numSeatAvail, string status)
        {
            this.FlightNumber = flightNumber;
            this.RouteID = routeID;
            this.FlightDate = flightDate;
            this.FlightTime = flightTime;
            this.EstArrTime = estArrTime;
            this.NumSeats = numSeats;
            this.NumSeatAvail = numSeatAvail;
            this.Status = status;
        }


        //Getter
        public string getFlightNumber() { return FlightNumber; }

        public int getRouteID() {  return RouteID; }

        public DateTime getFlightDate() { return FlightDate; }

        public DateTime getFlightTime() {  return FlightTime; }

        public int getNumSeats() {  return NumSeats; }

        public int getNumSeatAvail() {  return NumSeatAvail; }

        public string getStatus() { return Status; }



        //Setters
        public void setFlightNumber(string flightNumber) {  Status = flightNumber; }

        public void setRouteID(int routeID) {  RouteID = routeID; }

        public void setFlightDate(DateTime flightDate) { FlightDate = flightDate; }

        public void setFlightTime(DateTime flightTime) { FlightTime = flightTime; }

        public void setEstArrTime(DateTime estArrTime) {  EstArrTime = estArrTime; }

        public void setNumseats(int numSeats) {  NumSeats = numSeats; }

        public void setNumSeatsAvails(int numSeatsAvails) { NumSeatAvail = numSeatsAvails;}

        public void setStatus(string status) { Status = status; }


        public static string getFlightNumber() 
        {

        }







    }

}
