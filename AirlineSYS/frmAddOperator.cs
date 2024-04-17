using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{    
    public partial class frmAddOperator : Form
    {
        public frmAddOperator()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }
        private void btnOperatorConfirm_Click(object sender, EventArgs e)
        {
            if (txtOperatorCode.Text.Equals("") || txtOperatorName.Text.Equals("") || txtOperatorCity.Text.Equals("") ||
                                                    txtOperatorCountry.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorCode.Focus();

                return;
            }
            else if (txtOperatorCode.Text.Length != 2 || !txtOperatorCode.Text.All(char.IsUpper))
            {
                MessageBox.Show("Operator Code must be a valid TWO UPPERCASE LETTER Operator Code.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorCode.Focus();
                return;

            }
            else if (txtOperatorName.Text.Length > 60 || !txtOperatorName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Operator Name may only contain letters with the maximum length of 60", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorName.Focus();
                return;
            }
            else if (txtOperatorCountry.Text.Length > 30 || !txtOperatorCountry.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Operator Country must be letter", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorCountry.Focus();
                return;
            }
            else
            {
                Operator anOperator = new Operator(txtOperatorCode.Text, txtOperatorName.Text, txtOperatorCity.Text, txtOperatorCountry.Text);
                anOperator.addOperator();
                txtOperatorCode.Clear();
                txtOperatorName.Clear();
                txtOperatorCity.Clear();
                txtOperatorCountry.Clear();
            }
        }
    }
}

