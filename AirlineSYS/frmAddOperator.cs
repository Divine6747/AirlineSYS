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
            if (ValidateOperator.ValidateOperatorFields(txtOperatorCode.Text, txtOperatorName.Text, txtOperatorCity.Text, txtOperatorCountry.Text))
            {
                return;
            }
            string operatorCode = txtOperatorCode.Text;
            if (Operator.checkOperatorExists(operatorCode))
            {
                MessageBox.Show("Operator with code " + operatorCode + " already exists!. Please enter a new airport", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

