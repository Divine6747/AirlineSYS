using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public static class ValidateAirportDetails
    {
        public static bool ValidateAirportFields(string airportCode, string airportName, string airportStreet, string airportCity, string airportCountry, string airportEircode, string airportPhone, string airportEmail)
        {
            if (string.IsNullOrWhiteSpace(airportCode) || string.IsNullOrWhiteSpace(airportName) ||
                string.IsNullOrWhiteSpace(airportStreet) || string.IsNullOrWhiteSpace(airportCity) ||
                string.IsNullOrWhiteSpace(airportCountry) || string.IsNullOrWhiteSpace(airportEircode) ||
                string.IsNullOrWhiteSpace(airportPhone) || string.IsNullOrWhiteSpace(airportEmail))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (airportCode.Length != 3 || !airportCode.All(char.IsUpper))
            {
                MessageBox.Show("Airport Code must be a valid THREE UPPERCASE LETTERS", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (airportName.Length > 60 || !airportName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '.'))
            {
                MessageBox.Show("Airport Name can only contain letters with a maximum length of 60 characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (airportStreet.Length > 60 || !airportStreet.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Airport Street has a MAXIMUM of 60 characters and can contain only alphanumeric characters and spaces.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (airportCity.Length > 60 || !airportCity.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Airport city has a MAXIMUM of 60 characters and can contain only alphanumeric characters and spaces.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (airportCountry.Length > 50 || !airportCountry.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("Airport Country must be Alpha Numeric with a maximum length of 50 characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (airportEircode.Length != 7 || !airportEircode.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Airport Eircode must be Alpha Numeric and have a length of 7 characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(airportPhone) || !IsValidPhoneNumber(airportPhone))
            {
                MessageBox.Show("Invalid phone number format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (airportPhone.Length != 10)
            {
                MessageBox.Show("Invalid phone number length!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (airportEmail.Length > 50 || !IsValidEmail(airportEmail))
            {
                MessageBox.Show("Airport Email must have a maximum length of 50 characters and be a valid email address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, emailPattern);
        }
        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^08[3578]\d{7}$";
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}