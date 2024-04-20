using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public static class ValidateOperator
    {
        public static bool ValidateOperatorFields(string operatorCode, string operatorName, string operatorCity, string operatorCountry)
        {
            if (string.IsNullOrWhiteSpace(operatorCode) || string.IsNullOrWhiteSpace(operatorName) ||
                string.IsNullOrWhiteSpace(operatorCity) || string.IsNullOrWhiteSpace(operatorCountry))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operatorCode.Length != 2 || !operatorCode.All(char.IsUpper))
            {
                MessageBox.Show("Operator Code must be a valid TWO UPPERCASE LETTER Operator Code.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operatorName.Length > 60 || !operatorName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Operator Name may only contain letters with a maximum length of 60", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operatorCity.Length > 65 || !operatorCity.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Operator City may only contain letters, digits, or spaces with a maximum length of 65", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operatorCountry.Length > 30 || !operatorCountry.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Operator Country must be letters with a maximum length of 30", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
