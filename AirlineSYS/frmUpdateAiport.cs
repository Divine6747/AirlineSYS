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
    public partial class frmUpdateAiport : Form
    {
        frmAirlineMainMenu parent;
        public frmUpdateAiport()
        {
            InitializeComponent();
        }

        public frmUpdateAiport(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnAirportCodeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUpdateAirportCode.Text))
                {
                    MessageBox.Show("Please enter an airport code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Airport airport = new Airport();
                airport.findAirportDetails(txtUpdateAirportCode.Text);

                txtUpdateAirportName.Text = airport.getName();
                txtUpdateAirportStreet.Text = airport.getStreet();
                txtUpdateAirportCity.Text = airport.getCity();
                txtUpdateAirportCountry.Text = airport.getCountry();
                txtUpdateAirportEircode.Text = airport.getEircode();
                txtUpdateAirportPhone.Text = airport.getPhone();
                txtUpdateAirportEmail.Text = airport.getEmail();

                grpUpdateAirportDetails.Visible = true;
                btnUpdateAirportConfirm.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }

        }


        private void btnUpdateAirportConfirm_Click(object sender, EventArgs e)
        {
            // Validate if any required fields are empty
            if (string.IsNullOrWhiteSpace(txtUpdateAirportName.Text) || string.IsNullOrWhiteSpace(txtUpdateAirportStreet.Text) || string.IsNullOrWhiteSpace(txtUpdateAirportCity.Text) || 
                string.IsNullOrWhiteSpace(txtUpdateAirportCountry.Text) || string.IsNullOrWhiteSpace(txtUpdateAirportEircode.Text) ||string.IsNullOrWhiteSpace(txtUpdateAirportPhone.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateAirportEmail.Text) || string.IsNullOrWhiteSpace(txtUpdateAirportCode.Text))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Airport Name
            else if (txtUpdateAirportName.Text.Length > 60 || (!txtUpdateAirportName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '.')))
            {
                MessageBox.Show("Airport Name can only contain letters with a maximum length of 60 characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportName.Focus();
                return;
            }

            // Validate Airport Street
            if (txtUpdateAirportStreet.Text.Length > 60 || !txtUpdateAirportStreet.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Airport Street has a maximum length of 60 characters and can contain only alphanumeric characters and spaces.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportStreet.Focus();
                return;
            }

            // Validate Airport City
            if (txtUpdateAirportCity.Text.Length > 60 || !txtUpdateAirportCity.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Airport City has a maximum length of 60 characters and can contain only alphanumeric characters and spaces.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportCity.Focus();
                return;
            }

            // Validate Airport Country
            if (txtUpdateAirportCountry.Text.Length > 60 || !txtUpdateAirportCountry.Text.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("Airport Country must be alphanumeric.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportCountry.Focus();
                return;
            }

            // Validate Airport Eircode
            if (txtUpdateAirportEircode.Text.Length != 7 || !txtUpdateAirportEircode.Text.Replace(" ", "").All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Airport Eircode must be alphanumeric and have a length of 7 characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportEircode.Focus();
                return;
            }


            // Validate Airport Phone
            if (!(txtUpdateAirportPhone.Text.StartsWith("08") || txtUpdateAirportPhone.Text.Length < 10 ) || !txtUpdateAirportPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Airport phone must start with '08', and have a length of 10 characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportPhone.Focus();
                return;
            }

            // Validate Airport Email
            if (txtUpdateAirportEmail.Text.Length > 60 || !Regex.IsMatch(txtUpdateAirportEmail.Text.Trim(), @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Invalid email format or maximum length exceeded (60 characters).", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportEmail.Focus();
                return;
            }

            string email = txtUpdateAirportEmail.Text;

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportEmail.Focus();
                return;
            }
            else
            { 
                // All validations passed, proceed with updating the airport
                Airport airport = new Airport();

                airport.setName(txtUpdateAirportName.Text);
                airport.setStreet(txtUpdateAirportStreet.Text);
                airport.setCity(txtUpdateAirportCity.Text);
                airport.setCountry(txtUpdateAirportCountry.Text);
                airport.setEircode(txtUpdateAirportEircode.Text);
                airport.setPhone(txtUpdateAirportPhone.Text);
                airport.setEmail(txtUpdateAirportEmail.Text);

                airport.updateAirport(txtUpdateAirportCode.Text);

                // Clear the textboxes after successful update
                txtUpdateAirportName.Clear();
                txtUpdateAirportStreet.Clear();
                txtUpdateAirportCity.Clear();
                txtUpdateAirportCountry.Clear();
                txtUpdateAirportEircode.Clear();
                txtUpdateAirportPhone.Clear();
                txtUpdateAirportEmail.Clear();
                txtUpdateAirportCode.Clear();
            }
                
        }


        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }

        private void frmUpdateAiport_Load(object sender, EventArgs e)
        {
            grpUpdateAirportDetails.Visible = false;
            btnUpdateAirportConfirm.Visible = false;
            
            
            
        }
    }
}
