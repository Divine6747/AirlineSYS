using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private string Phone;
        private string Email;


        public Airport()
        {
            this.AirportCode = "";
            this.Name = "";
            this.Street = "";
            this.City = "";
            this.Country = "";
            this.Eircode = "";
            this.Phone = "";
            this.Email = "";
        }

        public Airport(string airportCode, string name, string street, string city, string country, string eircode, string phone, string email)
        {
            this.AirportCode = airportCode;
            this.Name = name;
            this.Street = street;
            this.City = city;
            this.Country = country;
            this.Eircode = eircode;
            this.Phone = phone;
            this.Email = email;
        }

        //These are the getters

        public string getAirportCode() { return this.AirportCode; }

        public string getName() { return this.Name; }

        public string getStreet() { return this.Street; }

        public string getCity() { return this.City; }

        public string getCountry() { return this.Country; }

        public string getEircode() { return this.Eircode; }

        public string getPhone() { return this.Phone; }

        public string getEmail() { return this.Email; }



        //These are the setters
        public void setAirportCode(string AirportCode) { this.AirportCode = AirportCode; }

        public void setName(string Name) { this.Name = Name; }

        public void setStreet(string Street) { this.Street = Street; }

        public void setCity(string City) { this.City = City; }

        public void setCountry(string Country) { this.Country = Country; }

        public void setEircode(string Eircode) { this.Eircode = Eircode; }

        public void setPhone(string Phone) { this.Phone = Phone; }

        public void setEmail(string Email) { this.Email = Email; }



        public void addAirport()
        {

            //Opens the db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "INSERT INTO Airports VALUES (" + "'" +
                this.AirportCode + "', '" +
                this.Name + "', '" +
                this.Street + "', '" +
                this.City + "', '" +
                this.Country + "', '" +
                this.Eircode + "', '" +
                this.Phone + "', '" +
                this.Email + "')";


            //Execute the SQL query to be executed
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();


        }
        public void updateAirport(string airportCode)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "UPDATE Airports SET " +
                              "Name = '" + this.Name + "', " +
                              "Street = '" + this.Street + "', " +
                              "City = '" + this.City + "', " +
                              "Country = '" + this.Country + "', " +
                              "Eircode = '" + this.Eircode + "', " +
                              "Phone = '" + this.Phone + "', " +
                              "Email = '" + this.Email + "' " +
                              "WHERE AirportCode = '" + airportCode + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Airport has been added to the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void findAirportDetails(string airportCode)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "SELECT Name, Street, City, Country, Eircode, Phone, Email FROM Airports WHERE AirportCode = '" + airportCode + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            try
            {
                conn.Open();

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    setName(reader.GetString(0));
                    setStreet(reader.GetString(1));
                    setCity(reader.GetString(2));
                    setCountry(reader.GetString(3));
                    setEircode(reader.GetString(4));
                    setPhone(reader.GetString(5));
                    setEmail(reader.GetString(6));
                }
                else
                {
                    throw new Exception("Airport not found.");


                }
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

        

    }

    class Operator
    {

        private string OperatorCode;
        private string Name;
        private string City;
        private string Country;
        private string Status;


        public Operator()
        {
            this.OperatorCode = "";
            this.Name = "";
            this.City = "";
            this.Country = "";
            this.Status = "";
        }
        public Operator(string operatorCode, string name, string city, string country, string status)
        {
            this.OperatorCode = operatorCode;
            this.Name = name;
            this.City = city;
            this.Country = country;
            this.Status = status;
        }


        //Getters
        public string getOperatorCode() { return this.OperatorCode; }

        public string getName() { return this.Name;}

        public string getCity() { return this.City;}

        public string getCountry() { return this.Country;}

        public string getStatus() { return this.Status;}


        //Setters
        public void setOperatotCode(string OperatorCode) { this.OperatorCode = OperatorCode; }

        public void setName(string Name) { this.Name = Name;}

        public void setCity(string City) {  this.City = City;}

        public void setCountry(string Country) {  this.Country = Country;}

        public void setStatus(string Status) {  this.Status = Status;}



         //Adding Operators
        public void addOperator()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "INSERT INTO Operators Values ('" +
                this.OperatorCode + "', '" +
                this.Name + "', '" +
                this.City + "', '" +
                this.Country + "', '" +
                this.Status + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Operator has been added to the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
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
                    string sqlQuery = "SELECT DeptAirport, ArrAirport FROM Routes";
                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    conn.Open();

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string deptAirport = reader.GetString(0);
                            string arrAirport = reader.GetString(1);
                            routes.Add(new Route { DepartureAirport = deptAirport, ArrivalAirport = arrAirport });
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

        public void endRoute()
        {
            OracleConnection conn = new OracleConnection( DBConnect.oradb);
            string sqlQuery = "UPDATE Routes SET " +
                              "Status = '" + this.Status

        }

    }

}

