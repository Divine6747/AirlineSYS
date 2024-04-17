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
        public string getName() { return this.Name; }
        public string getCity() { return this.City; }
        public string getCountry() { return this.Country; }
        public string getStatus() { return this.Status; }

        //Setters
        public void setOperatotCode(string OperatorCode) { this.OperatorCode = OperatorCode; }
        public void setName(string Name) { this.Name = Name; }
        public void setCity(string City) { this.City = City; }
        public void setCountry(string Country) { this.Country = Country; }
        public void setStatus(string Status) { this.Status = Status; }

        //Add Operetor Method
        public void addOperator()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "INSERT INTO Operators (OperatorCode, Name, City, Country, Status) VALUES (:OperatorCode, :Name, :City, :Country, :Status)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(":OperatorCode", OracleDbType.Varchar2).Value = OperatorCode;
            cmd.Parameters.Add(":Name", OracleDbType.Varchar2).Value = Name;
            cmd.Parameters.Add(":City", OracleDbType.Varchar2).Value = City;
            cmd.Parameters.Add(":Country", OracleDbType.Varchar2).Value = Country;
            cmd.Parameters.Add(":Status", OracleDbType.Varchar2).Value = Status;

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

        //Get Operator Method
        public static List<Operator> getOperators()
        {
            List<Operator> operatorCodes = new List<Operator>();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            try
            {
                string sqlQuery = "SELECT OperatorCode FROM Operators";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string operatorCode = reader.GetString(0);
                    operatorCodes.Add(new Operator { OperatorCode = operatorCode });
                }

                reader.Close();
                conn.Close();
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
            return operatorCodes;
        }        
     }
}
