using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirlineSYS
{
    class Route
    {
        public int RouteID;
        public string DepartureAirport;
        public string ArrivalAirport;
        public decimal TicketPrice;
        public int Duration;
        public string Status;

        public Route() {

            this.RouteID = 0;
            this.DepartureAirport = "";
            this.ArrivalAirport = "";
            this.TicketPrice = 0;
            this.Duration = 0;
            this.Status = "";

        }


        public Route(int routeID, string departureAirport, string arrivalAirport, decimal ticketPrice, int duration, string status)
        {

            if (routeID <= 0)
            {
                throw new ArgumentException("Invalid route ID.");
            }

            if (string.IsNullOrEmpty(departureAirport))
            {
                throw new ArgumentException("Departure airport cannot be empty.");
            }

            this.RouteID = routeID;
            this.DepartureAirport = departureAirport;
            this.ArrivalAirport = arrivalAirport;
            this.TicketPrice = ticketPrice;
            this.Duration = duration;
            this.Status = status;
        }

        //Getters
        public int getRouteID() { return this.RouteID; }

        public string getDepartureAirport() {  return this.DepartureAirport; }

        public string getArrivalAirport() { return this.ArrivalAirport; }

        public decimal getTicketPrice () { return this.TicketPrice; }

        public int getDuration () { return this.Duration; }

        public string getStatus() { return this.Status;}

       
        //Setters
        public void setRouteID(int routeID) { this.RouteID = routeID;}

        public void setDepartureAirport(string departureAirport) {

            if (string.IsNullOrEmpty(departureAirport))
            {
                throw new ArgumentException("Departure airport cannot be empty.");
            }

            this.DepartureAirport = departureAirport;
        }
       
        public void setArrivalAirport(string arrivalAirport) { this.ArrivalAirport = arrivalAirport;}

        public void setTicketPrice(decimal ticketPrice) { this.TicketPrice = ticketPrice; }

        public void setDuration(int duration) { this.Duration = duration; }

        public void setStatus(string status) { this.Status = status;}

        public static int getNextRouteID()
        {
            int nextRouteID = 1;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT MAX(RouteID) FROM Routes";
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            nextRouteID = reader.GetInt32(0) + 1;
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

            return nextRouteID;

        }

        public void addRoute()
        {
 
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "INSERT INTO Routes VALUES (" +
                this.RouteID + ",'" +
                this.DepartureAirport + "','" +
                this.ArrivalAirport + "', " +
                this.TicketPrice + ", " +
                this.Duration + ", '" +
                this.Status + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Route has been added to the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static List<Route> getRoutes()
        {
            List<Route> routes = new List<Route>();
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT RouteID, DeptAirport, ArrAirport FROM Routes";
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int routeid = reader.GetInt32(0);
                            string deptAirport = reader.GetString(1);
                            string arrAirport = reader.GetString(2);
                            routes.Add(new Route { RouteID = routeid, DepartureAirport = deptAirport, ArrivalAirport = arrAirport });
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

            return routes;
        }

        public static List<Route> getAllRouteDetails()
        {
            List<Route> routes = new List<Route>();
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT* FROM Routes";
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int routeID = reader.GetInt32(0);
                            string deptAirport = reader.GetString(1);
                            string arrAirport = reader.GetString(2);
                            decimal ticketPrice = reader.GetDecimal(3);
                            int duration = reader.GetInt32(4);
                            string status = reader.GetString(5);
                            routes.Add(new Route { RouteID = routeID, DepartureAirport = deptAirport, ArrivalAirport = arrAirport, TicketPrice = ticketPrice, Duration = duration, Status = status });
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

            return routes;
        }

        public void endRoute(int routeID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "UPDATE Routes SET Status = 'I' WHERE RouteID = '" + routeID + "'";

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }





    }

}

