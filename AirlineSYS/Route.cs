using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static int getNextRouteID()
        {
            int nextRouteID = 1;

            string sqlQuery = "SELECT MAX(RouteID) FROM Routes";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);            
            OracleDataReader reader = null;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read() && !reader.IsDBNull(0))
                {
                    nextRouteID = reader.GetInt32(0) + 1;
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
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return nextRouteID;
        }

        //Adding Route
        public void addRoute()
        {
            string sqlQuery = "INSERT INTO Routes (RouteID, DeptAirport, ArrAirport, TicketPrice, Duration, Status) " +
                              "VALUES (:RouteID, :DepartureAirport, :ArrivalAirport, :TicketPrice, :Duration, :Status)";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

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
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //Getting All Routes from database
        public static List<Route> getRoutes()
        {
            List<Route> routes = new List<Route>();

            string sqlQuery = "SELECT RouteID, DeptAirport, ArrAirport FROM Routes WHERE Status = 'A'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            try
            {                 
                conn.Open();

               reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    int routeid = reader.GetInt32(0);
                    string deptAirport = reader.GetString(1);
                    string arrAirport = reader.GetString(2);
                    routes.Add(new Route { RouteID = routeid, DepartureAirport = deptAirport, ArrivalAirport = arrAirport });
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
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return routes;
        }

        //End Route
        public void endRoute(int routeID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQueryCheckRouteInUse = "SELECT COUNT(*) FROM Flights WHERE RouteID = :routeID AND Status = 'A'";
            string sqlQueryUpdateRoute = "UPDATE Routes SET Status = 'I' WHERE RouteID = :routeID";

            OracleCommand cmdCheckFlights = new OracleCommand(sqlQueryCheckRouteInUse, conn);
            cmdCheckFlights.Parameters.Add(":routeID", OracleDbType.Int32).Value = routeID;

            OracleDataReader reader = null;
            OracleCommand cmdUpdateRoute = null;

            try
            {
                conn.Open();

                cmdCheckFlights.Connection = conn;
                reader = cmdCheckFlights.ExecuteReader();

                int activeFlightCount = 0;
                if (reader.Read())
                {
                    activeFlightCount = reader.GetInt32(0);
                }

                reader.Close();

                if (activeFlightCount > 0)
                {
                    MessageBox.Show("Cannot end route. There are active flights associated with it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmdUpdateRoute = new OracleCommand(sqlQueryUpdateRoute, conn);
                    cmdUpdateRoute.Parameters.Add(":routeID", OracleDbType.Int32).Value = routeID;
                    cmdUpdateRoute.ExecuteNonQuery();

                    MessageBox.Show("Route has success been ended", "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                if (cmdUpdateRoute != null)
                {
                    cmdUpdateRoute.Dispose();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        //Retrieving all Route Details from database
        public static List<Route> getAllRouteDetails()
        {
            List<Route> routes = new List<Route>();            

            string sqlQuery = "SELECT * FROM Routes";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery,conn);
            OracleDataReader reader = null;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

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
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return routes;
        }
        //Checking the database for route existance
        public static bool doesRouteExist(string deptAirport, string arrAirport)
        {
            bool routeExistence = false;

            string sqlQuery = "SELECT COUNT(*) FROM Routes WHERE DeptAirport = :DeptAirport AND ArrAirport = :ArrAirport";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery,conn);
            OracleDataReader reader = null;

            cmd.Parameters.Add(":DeptAirport", OracleDbType.Varchar2).Value = deptAirport;
            cmd.Parameters.Add(":ArrAirport", OracleDbType.Varchar2).Value = arrAirport;           

            try
            {
                conn.Open();

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    routeExistence = count > 0;
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
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return routeExistence;
        }
        //Getting route Id by using depature and arrival airport
        public int getRouteID(string dept, string arr)
        {
            int routeID = -1;

            string sqlQuery = "SELECT RouteID FROM Routes WHERE DeptAirport = :dept AND ArrAirport = :arr";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            cmd.Parameters.Add(":dept", OracleDbType.Varchar2).Value = dept;
            cmd.Parameters.Add(":arr", OracleDbType.Varchar2).Value = arr;


            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    routeID = Convert.ToInt32(reader["RouteID"]);
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
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return routeID;
        }

        //Getting the duration of a route from the Routes table
        public int getDuration(string dept, string arr)
        {
            int duration = -1;

            string sqlQuery = "SELECT Duration FROM Routes WHERE DeptAirport = :dept AND ArrAirport = :arr";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);            
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            cmd.Parameters.Add(":dept", dept);
            cmd.Parameters.Add(":arr", arr);

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

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
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return duration;
        }
        public static Route getAirportsByID(int routeID)
        {
            Route route = null;
            string sqlQuery = "SELECT DeptAirport, ArrAirport FROM Routes WHERE RouteID = :RouteID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);            
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            cmd.Parameters.Add(":RouteID", OracleDbType.Int32).Value = routeID;

            try
            {               
                conn.Open();

                reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    string deptAirport = reader.GetString(0);
                    string arrAirport = reader.GetString(1);
                    route = new Route { RouteID = routeID, DepartureAirport = deptAirport, ArrivalAirport = arrAirport };
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
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return route;
        }
    }
}