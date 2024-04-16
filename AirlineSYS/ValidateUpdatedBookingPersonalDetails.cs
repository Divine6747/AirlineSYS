using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    class ValidateUpdatedBookingPersonalDetails
    {
        public static bool ValidatePersonalDetails(string forename, string surname, DateTime dateOfBirth, string email, string phone, string eircode)
        {
            if (!IsValidName(forename))
            {
                MessageBox.Show("Forename must contain only letters and cannot be empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidName(surname))
            {
                MessageBox.Show("Surname must contain only letters and cannot be empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsPerson18OrOlder(dateOfBirth))
            {
                MessageBox.Show("You must be 18 years or older to make a booking.", "Age Requirement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEircode(eircode))
            {
                MessageBox.Show("Invalid Irish Eircode format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ValidateNumBaggage(int numBaggage)
        {
            if (numBaggage < 0)
            {
                MessageBox.Show("Number of baggage must be equal or greater than zero", "Invalid Number of Baggage", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string phonePattern = @"^08\d{8}$";
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}
