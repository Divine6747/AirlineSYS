using System;
using System.Collections.Generic;

namespace SeatNumbers
{
    class flightSeats
    {
        public static void FlightSeat()
        {
            Dictionary<string, int> seatAssign = new Dictionary<string, int>();

            seatAssign.Add("1A", 1);
            seatAssign.Add("1B", 2);
            seatAssign.Add("2A", 3);

            try
            {
                seatAssign.Add("1A", 1);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Seat 1A is already occupied.");
            }

            Console.WriteLine("Passenger in seat 2A: {0}", seatAssign["2A"]);
            seatAssign["2A"] = 4;

            seatAssign["3C"] = 5;

            //Accessing a passenger that doesn't exist
            try
            {
                Console.WriteLine("Passenger in seat 4D: {0}", seatAssign["4D"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Seat 4D is not found in the seat.");
            }
            //Use TryGetValue to retrieve passenger for a seat.
            int passenger;

            if (seatAssign.TryGetValue("3C", out passenger))
            {
                Console.WriteLine("Passenger in seat 3C: {0}", passenger);
            }
            else
            {
                Console.WriteLine("Seat 3C is not found in the seat.");
            }

            //checking if a seat exists before adding a passenger.
            if (!seatAssign.ContainsKey("4F"))
            {
                seatAssign.Add("4F", 6);
                Console.WriteLine("Passenger added to seat 4F: {0}", seatAssign["4F"]);
            }

            //printiing  the flight seat.
            Console.WriteLine("\nFlight seats:");
            foreach (KeyValuePair<string, int> kvp in seatAssign)
            {
                Console.WriteLine("Seat: {0}, Passenger ID: {1}", kvp.Key, kvp.Value);
            }

            //removing a passenger from the seat.
            Console.WriteLine("\nRemoving passenger from seat 3C.");

            seatAssign.Remove("3C");

            //verifying if the passenger was removed successfully.
            if (!seatAssign.ContainsKey("3C"))
            {
                Console.WriteLine("Passenger successfully removed from seat 3C.");
            }
        }
    }
}
