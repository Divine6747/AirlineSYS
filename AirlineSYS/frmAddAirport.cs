using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class frmAddAirport : Form
    {
        frmAirlineMainMenu parent;
        public frmAddAirport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmAddAirport(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }

        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            if (txtAirportCode.Text.Equals("") || txtAirportName.Text.Equals("") || txtAirportStreet.Text.Equals("") ||
                txtAirportCity.Text.Equals("") || txtAirportCountry.Text.Equals("") || txtAirportEircode.Text.Equals("") ||
                txtAirportPhone.Text.Equals("") || txtAirportEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportCode.Focus();

                return;
            }

            else if (txtAirportCode.Text.Length != 3 || !txtAirportCode.Text.All(char.IsUpper))
            {
                MessageBox.Show("Airport Code must be a valid THREE UPPERCASE LETTERS", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportCode.Focus();
                return;

            }

            else if (txtAirportName.Text.Length > 60 || (!txtAirportName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '.')))
            {
                MessageBox.Show("Airport Name can only contain letter witb the maximum length of 60 characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportName.Focus();
                return;
            }



            else if (txtAirportStreet.Text.Length > 60 || !txtAirportStreet.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Airport Street has a MAXIMUM of 60 characters and can contain only alphanumeric characters and spaces.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportStreet.Focus();
                return;
            }

            else if (txtAirportCity.Text.Length > 60 || !txtAirportCity.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Airport city has a MAXIMUM of 60 characters and can contain only alphanumeric characters and spaces.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportStreet.Focus();
                return;
            }

            else if (txtAirportCountry.Text.Length > 60 || !txtAirportCountry.Text.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("Airport Country must be Alpha Numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportCountry.Focus();
                return;
            }

            else if (txtAirportEircode.Text.Length != 7 || !txtAirportEircode.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Airport Eircode must be Alpha Numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportEircode.Focus();
                return;
            }

            else if (!(txtAirportPhone.Text.StartsWith("08")) || !(txtAirportPhone.Text.Length > 0 && txtAirportPhone.Text.Length <= 15) || !txtAirportPhone.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Airport phone must be Numeric, Starts with (08) and Maxium 15 characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportPhone.Focus();
                return;
            }


            else if (txtAirportEmail.Text.All(char.IsDigit) || txtAirportEmail.Text.Length > 60)
            {
                MessageBox.Show("Airport Email must can not be Numeric and MAXIMUM length of 60", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportEmail.Focus();
                return;
            }


            string email = txtAirportEmail.Text;

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportEmail.Focus();
                return;
            }
            else
            {
                Airport anAirport = new Airport(txtAirportCode.Text,txtAirportName.Text, txtAirportStreet.Text, txtAirportCity.Text, txtAirportCountry.Text, 
                                                txtAirportEircode.Text,txtAirportPhone.Text,txtAirportEmail.Text);

                anAirport.addAirport();

                txtAirportCode.Clear();
                txtAirportName.Clear();
                txtAirportStreet.Clear();
                txtAirportCity.Clear();
                txtAirportCountry.Clear();
                txtAirportEircode.Clear();
                txtAirportPhone.Clear();
                txtAirportEmail.Clear();
            }
        }
    }
}
