using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public static class ValidateBookingPersonalDetails
    {
        public static bool ValidateBookingField(string txtForeName, string txtSurname, DateTime dtpBookingDOB, string txtBookingEmail, string txtBookingPhone, string txtBookingEircode, string paymentAmountText, decimal routePrice, string flightPriceText)
        {
            if (txtForeName != null)
            {
                txtForeName = txtForeName.Trim();
            }

            if (txtSurname != null)
            {
                txtSurname = txtSurname.Trim();
            }

            if (txtBookingEmail != null)
            {
                txtBookingEmail = txtBookingEmail.Trim();
            }

            if (txtBookingPhone != null)
            {
                txtBookingPhone = txtBookingPhone.Trim();
            }

            if (txtBookingEircode != null)
            {
                txtBookingEircode = txtBookingEircode.Trim();
            }

            if (string.IsNullOrWhiteSpace(txtForeName) || !IsValidName(txtForeName))
            {
                MessageBox.Show("Forename must contain only letters and cannot be empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSurname) || !IsValidName(txtSurname))
            {
                MessageBox.Show("Surname must contain only letters and cannot be empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsPerson18OrOlder(dtpBookingDOB))
            {
                MessageBox.Show("You must be 18 years or older to make a booking.", "Age Requirement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBookingEmail) || !IsValidEmail(txtBookingEmail))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBookingEircode) || !IsValidEircode(txtBookingEircode))
            {
                MessageBox.Show("Invalid Irish Eircode format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBookingPhone) || !IsValidPhoneNumber(txtBookingPhone))
            {
                MessageBox.Show("Invalid phone number format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(paymentAmountText))
            {
                MessageBox.Show("Please pay the price for the flight.", "Price Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(paymentAmountText.Replace("€", ""), out decimal retrievedPrice))
            {
                MessageBox.Show("Error parsing the retrieved price.", "Price Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (retrievedPrice < routePrice)
            {
                MessageBox.Show("Payment amount is insufficient for the price of the flight.", "Price Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (retrievedPrice > routePrice)
            {
                MessageBox.Show("Payment amount exceeds the price of the flight.", "Price Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Length <= 50 && name.All(char.IsLetter);
        }

        private static bool IsPerson18OrOlder(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;

            return age >= 18;
        }

        private static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return !string.IsNullOrWhiteSpace(email) && email.Length <= 70 && Regex.IsMatch(email, emailPattern);
        }

        private static bool IsValidEircode(string eircode)
        {
            string eircodePattern = @"^[A-Za-z0-9]{7}$";
            return !string.IsNullOrWhiteSpace(eircode) && Regex.IsMatch(eircode, eircodePattern);
        }

        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^08[3578]\d{7}$";
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}