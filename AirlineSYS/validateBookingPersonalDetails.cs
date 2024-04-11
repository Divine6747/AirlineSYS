using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public static class validateBookingPersonalDetails
    {
        public static bool ValidateBookingField(string txtForeName, string txtSurname, DateTime dtpBookingDOB, string txtBookingEmail, string txtBookingPhone, string txtBookingEircode)
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
            return true;
        }

        // Function to check if a person is 18 or older based on date of birth
        private static bool IsPerson18OrOlder(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;

            return age >= 18;
        }

        private static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter);
        }

        private static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private static bool IsValidEircode(string eircode)
        {
            string eircodePattern = @"^[A-Za-z0-9]{7}$";
            return Regex.IsMatch(eircode, eircodePattern);
        }

        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^08[3579]\d{7}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

    }
}
