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
        public Operator()
        {
            this.OperatorCode = "";
            this.Name = "";
            this.City = "";
            this.Country = "";
        }
        public Operator(string operatorCode, string name, string city, string country)
        {
            this.OperatorCode = operatorCode;
            this.Name = name;
            this.City = city;
            this.Country = country;
        }

        //Getters
        public string getOperatorCode() { return this.OperatorCode; }
        public string getName() { return this.Name; }
        public string getCity() { return this.City; }
        public string getCountry() { return this.Country; }

        //Setters
        public void setOperatotCode(string OperatorCode) { this.OperatorCode = OperatorCode; }
        public void setName(string Name) { this.Name = Name; }
        public void setCity(string City) { this.City = City; }
        public void setCountry(string Country) { this.Country = Country; }

        //Add Operetor Method
        public void addOperator()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "INSERT INTO Operators (OperatorCode, Name, City, Country) VALUES (:OperatorCode, :Name, :City, :Country)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(":OperatorCode", OracleDbType.Varchar2).Value = OperatorCode;
            cmd.Parameters.Add(":Name", OracleDbType.Varchar2).Value = Name;
            cmd.Parameters.Add(":City", OracleDbType.Varchar2).Value = City;
            cmd.Parameters.Add(":Country", OracleDbType.Varchar2).Value = Country;

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
            
            string sqlQuery = "SELECT OperatorCode FROM Operators";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            
            try
            {                
                conn.Open();

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string operatorCode = reader.GetString(0);
                    operatorCodes.Add(new Operator { OperatorCode = operatorCode });
                }

                reader.Close();
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
        public static bool checkOperatorExists(string operatorCode)
        {
            string sqlQuery = "SELECT OperatorCode FROM Operators WHERE OperatorCode = :OperatorCode";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = null;

            cmd.Parameters.Add(":OperatorCode", OracleDbType.Varchar2).Value = operatorCode;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                return reader.Read();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Oracle Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
        }

    }
}
