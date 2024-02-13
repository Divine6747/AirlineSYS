using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

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
                if (string.IsNullOrEmpty(txtUpdateAirport.Text))
                {
                    MessageBox.Show("Please enter an airport code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Airport airport = new Airport();
                airport.findAirportDetails(txtUpdateAirport.Text);

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
            if (txtUpdateAirportName.Text.Equals("") || txtUpdateAirportStreet.Text.Equals("") || txtUpdateAirportCity.Text.Equals("") || 
                txtUpdateAirportCountry.Text.Equals("") || txtUpdateAirportEircode.Text.Equals("") || txtUpdateAirportEircode.Text.Equals("") || txtUpdateAirportEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportName.Focus();

                return;
            }

            else if (txtUpdateAirportName.Text.Length > 60 || !txtUpdateAirportName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))
)
            {
                MessageBox.Show("Airport Name can only contain letter witb the maximum length of 60 characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportName.Focus();
                return;
            }



            else if (txtUpdateAirportStreet.Text.Length > 60 || !txtUpdateAirportStreet.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Airport Street has a MAXIMUM of 60 characters and can contain only alphanumeric characters and spaces.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportStreet.Focus();
                return;
            }

            else if (txtUpdateAirportCity.Text.Length > 60 || !txtUpdateAirportCity.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Airport city has a MAXIMUM of 60 characters and can contain only alphanumeric characters and spaces.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportStreet.Focus();
                return;
            }

            else if (txtUpdateAirportCountry.Text.Length > 60 || !txtUpdateAirportCountry.Text.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("Airport Country must be Alpha Numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportCountry.Focus();
                return;
            }

            else if (txtUpdateAirportEircode.Text.Length != 7 || !txtUpdateAirportEircode.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Airport Eircode must be Alpha Numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportEircode.Focus();
                return;
            }

            else if (!(txtUpdateAirportPhone.Text.StartsWith("08") || txtUpdateAirportPhone.Text.StartsWith("+353")) || !(txtUpdateAirportPhone.Text.Length > 0 && txtUpdateAirportPhone.Text.Length <= 15) || !txtUpdateAirportPhone.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Airport phone must be Numeric, Starts with (08 or +353 ) and Maxium 15 characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateAirportPhone.Focus(); // Corrected focus
                return;
            }


            else if (txtUpdateAirportEmail.Text.All(char.IsDigit) || txtUpdateAirportEmail.Text.Length > 60)
            {
                MessageBox.Show("Airport Email must can not be Numeric and MAXIMUM length of 60", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                Airport airport = new Airport();

                airport.setName(txtUpdateAirportName.Text);
                airport.setStreet(txtUpdateAirportStreet.Text);
                airport.setCity(txtUpdateAirportCity.Text);
                airport.setCountry(txtUpdateAirportCountry.Text);
                airport.setEircode(txtUpdateAirportEircode.Text);
                airport.setPhone(txtUpdateAirportPhone.Text);
                airport.setEmail(txtUpdateAirportEmail.Text);

                airport.updateAirport();

                MessageBox.Show("Airport has been added to the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*txtUpdateAirportName.Clear();
                txtUpdateAirportStreet.Clear();
                txtUpdateAirportCity.Clear();
                txtUpdateAirportCountry.Clear();
                txtUpdateAirportEircode.Clear();
                txtUpdateAirportPhone.Clear();
                txtUpdateAirportEmail.Clear();**/
            
 
                            
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
