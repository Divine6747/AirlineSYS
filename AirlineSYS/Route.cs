using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    class Route
    {
        private int RouteID;
        private string DepartureAirport;
        private string ArrivalAirport;
        private decimal TicketPrice;
        private int Duration;
        private string Status;
        public Route()
        {
            this.RouteID = 0;
            this.DepartureAirport = "";
            this.ArrivalAirport = "";
            this.TicketPrice = 0;
            this.Duration = 0;
            this.Status = "";
        }

        public Route(int routeID, string departureAirport, string arrivalAirport, decimal ticketPrice, int duration, string status)
        {
            this.RouteID = routeID;
            this.DepartureAirport = departureAirport;
            this.ArrivalAirport = arrivalAirport;
            this.TicketPrice = ticketPrice;
            this.Duration = duration;
            this.Status = status;
        }

        //Getters
        public int getRouteID() { return RouteID; }
        public string getDepartureAirport() { return this.DepartureAirport; }
        public string getArrivalAirport() { return this.ArrivalAirport; }
        public decimal getTicketPrice() { return this.TicketPrice; }
        public int getDuration() { return this.Duration; }
        public string getStatus() { return this.Status; }

        //Setters
        public void setRouteID(int routeID) { this.RouteID = routeID; }
        public void setDepartureAirport(string departureAirport) { }
        public void setArrivalAirport(string arrivalAirport) { this.ArrivalAirport = arrivalAirport; }
        public void setTicketPrice(decimal ticketPrice) { this.TicketPrice = ticketPrice; }
        public void setDuration(int duration) { this.Duration = duration; }
        public void setStatus(string status) { this.Status = status; }

        //Getting next route ID
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
        //Adding Route
        public void addRoute()
        {
            string sqlQuery = "INSERT INTO Routes (RouteID, DeptAirport, ArrAirport, TicketPrice, Duration, Status) " +
                              "VALUES (:RouteID, :DepartureAirport, :ArrivalAirport, :TicketPrice, :Duration, :Status)";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    cmd.Parameters.Add(":RouteID", OracleDbType.Int32).Value = RouteID;
                    cmd.Parameters.Add(":DepartureAirport", OracleDbType.Varchar2).Value = DepartureAirport;
                    cmd.Parameters.Add(":ArrivalAirport", OracleDbType.Varchar2).Value = ArrivalAirport;
                    cmd.Parameters.Add(":TicketPrice", OracleDbType.Decimal).Value = TicketPrice;
                    cmd.Parameters.Add(":Duration", OracleDbType.Decimal).Value = Duration;
                    cmd.Parameters.Add(":Status", OracleDbType.Varchar2).Value = Status;

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
                }
            }
        }

        //Getting All Routes from database
        public static List<Route> getRoutes()
        {
            List<Route> routes = new List<Route>();
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT RouteID, DeptAirport, ArrAirport FROM Routes WHERE Status = 'A'";

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

        //Retrieving all Route Details from database
        public static List<Route> getAllRouteDetails()
        {
            List<Route> routes = new List<Route>();
            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT * FROM Routes";
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
        //Ending Routes
        public void endRoute(int routeID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQueryCheckFlights = "SELECT COUNT(*) FROM Flights WHERE RouteID = :routeID AND Status = 'A'";
                string sqlQueryUpdateRoute = "UPDATE Routes SET Status = 'I' WHERE RouteID = :routeID";

                try
                {
                    conn.Open();

                    OracleCommand cmdCheckFlights = new OracleCommand(sqlQueryCheckFlights, conn);
                    cmdCheckFlights.Parameters.Add(":routeID", OracleDbType.Int32).Value = routeID;

                    int activeFlightCount = Convert.ToInt32(cmdCheckFlights.ExecuteScalar());

                    if (activeFlightCount > 0)
                    {
                        MessageBox.Show("Cannot end route. There are active flights associated with it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        OracleCommand cmdUpdateRoute = new OracleCommand(sqlQueryUpdateRoute, conn);
                        cmdUpdateRoute.Parameters.Add(":routeID", OracleDbType.Int32).Value = routeID;
                        cmdUpdateRoute.ExecuteNonQuery();

                        MessageBox.Show("Route has been ended in the Database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }
        //Checking the database to check for route existance
        public static bool doesRouteExist(string deptAirport, string arrAiport)
        {
            bool routeExistance = false;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT COUNT(*) FROM Routes WHERE DeptAirport = '" + deptAirport + "' AND ArrAirport = '" + arrAiport + "'";
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int count = reader.GetInt32(0);
                            routeExistance = count > 0;
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
            return routeExistance;
        }
        //Getting route Id by using depature and arrival airport
        public int getRouteID(string dept, string arr)
        {
            int routeID = -1;

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT RouteID FROM Routes " + "WHERE DeptAirport = :dept AND ArrAirport = :arr";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                cmd.Parameters.Add(":dept", dept);
                cmd.Parameters.Add(":arr", arr);

                try
                {
                    conn.Open();
                    OracleDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        routeID = Convert.ToInt32(reader["RouteID"]);
                    }
                    reader.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return routeID;
        }

        //Getting the duration of a route from the Routes table
        public int getDuration(string dept, string arr)
        {
            int duration = -1;

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string sqlQuery = "SELECT Duration FROM Routes WHERE DeptAirport = :dept AND ArrAirport = :arr";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                cmd.Parameters.Add(":dept", dept);
                cmd.Parameters.Add(":arr", arr);

                try
                {
                    conn.Open();
                    OracleDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        duration = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return duration;
        }
        public static Route getAirportsByID(int routeID)
        {
            Route route = null;

            try
            {
                using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                {
                    string sqlQuery = "SELECT DeptAirport, ArrAirport FROM Routes WHERE RouteID = :RouteID";
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.Parameters.Add(":RouteID", OracleDbType.Int32).Value = routeID;
                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string deptAirport = reader.GetString(0);
                            string arrAirport = reader.GetString(1);
                            route = new Route { RouteID = routeID, DepartureAirport = deptAirport, ArrivalAirport = arrAirport };
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

            return route;
        }
    }
}