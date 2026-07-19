using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BriteSparx_POS_System
{
    public partial class Edit_Customer_Form : Form
    {
        public Edit_Customer_Form()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string customerName = txtCustomerName.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z]+$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderName.SetError(txtCustomerName, "Please enter a valid name containing only alphabets.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderName.SetError(txtCustomerName, string.Empty);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Customer_Form_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'g17Wst2024DataSet.SALE' table. You can move, or remove it, as needed.
            this.sALETableAdapter.Fill(this.g17Wst2024DataSet.SALE);
            //txtCustomerPassword.PasswordChar = '*';

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
          
                bool hasErrors = false;

            // List of all ErrorProvider instances on the form
            // Define a dictionary with ErrorProvider as the key and a list of associated controls as the value
            var errorProviderMap = new Dictionary<ErrorProvider, List<Control>>
{
    { errorProviderSurname, new List<Control> { txtCustomerSurname } },
    { errorProviderPassword, new List<Control> { txtCustomerPassword } },
    { errorProviderSuburb, new List<Control> { txtCustomerSuburb } },
    { errorProviderPostalCode, new List<Control> { txtPostalCode } },
    { errorProviderCellPhoneNumber, new List<Control> { txtEmployeeCellphoneNumber } },
    { errorProviderStreetName, new List<Control> { txtCustomerStreetname } },
    { errorProviderTown, new List<Control> { txtCustTown } },
    { errorProviderEmail, new List<Control> { txtCustomerEmail } },
    { errorProviderName, new List<Control> { txtCustomerName } }
};


            // Check each ErrorProvider for errors
            foreach (var kvp in errorProviderMap)
                {

                ErrorProvider errorProvider = kvp.Key;
                List<Control> controls = kvp.Value;


                foreach (Control control in controls)
                {
                    if (HasErrors(errorProvider, control))
                    {
                        hasErrors = true;
                        break;
                    }
                }
            }
           
               if (hasErrors)
                {
                    // If there are errors, show a message to the user
                    MessageBox.Show("Please correct the errors before adding the customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                customerTableAdapter1.InsertQuery((string) txtCustomerName.Text, (string)txtCustomerSurname.Text, (string)txtEmployeeCellphoneNumber.Text, (string)txtCustomerEmail.Text, (string)txtCustomerPassword.Text, (string)txtCustomerStreetname.Text, (string)txtCustomerSuburb.Text, (string)txtCustTown.Text, (string)txtPostalCode.Text, (string)comboBoxArchiveStatus.Text);
                MessageBox.Show("New Customer Profile Added.");
                }
            

        }


        private void txtCustTown_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtCustTown.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z\s]+$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderTown.SetError(txtCustTown, "Please enter a valid Town containing only alphabets.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderTown.SetError(txtCustTown, string.Empty);
            }
        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtPostalCode.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^\d{4}$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderPostalCode.SetError(txtPostalCode, "Please enter a valid Postal Code thats 4 digits");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderPostalCode.SetError(txtPostalCode, string.Empty);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            customerTableAdapter1.FillBy(g17Wst2024DataSet.CUSTOMER, txtCustomerSearch.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            bool hasErrors = false;

            // List of all ErrorProvider instances on the form
            // Define a dictionary with ErrorProvider as the key and a list of associated controls as the value
            var errorProviderMap = new Dictionary<ErrorProvider, List<Control>>
{
    { errorProviderSurname, new List<Control> { txtCustomerSurname } },
    { errorProviderPassword, new List<Control> { txtCustomerPassword } },
    { errorProviderSuburb, new List<Control> { txtCustomerSuburb } },
    { errorProviderPostalCode, new List<Control> { txtPostalCode } },
    { errorProviderCellPhoneNumber, new List<Control> { txtEmployeeCellphoneNumber } },
    { errorProviderStreetName, new List<Control> { txtCustomerStreetname } },
    { errorProviderTown, new List<Control> { txtCustTown } },
    { errorProviderEmail, new List<Control> { txtCustomerEmail } },
    { errorProviderName, new List<Control> { txtCustomerName } }
};


            // Check each ErrorProvider for errors
            foreach (var kvp in errorProviderMap)
            {

                ErrorProvider errorProvider = kvp.Key;
                List<Control> controls = kvp.Value;


                foreach (Control control in controls)
                {
                    if (HasErrors(errorProvider, control))
                    {
                        hasErrors = true;
                        break;
                    }
                }
            }

            if (hasErrors)
            {
                // If there are errors, show a message to the user
                MessageBox.Show("Please correct the errors before updating the customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    
                    customerTableAdapter1.UpdateQuery((string)txtCustomerName.Text, (string)txtCustomerSurname.Text, (string)txtEmployeeCellphoneNumber.Text, (string)txtCustomerEmail.Text, (string)txtCustomerStreetname.Text, (string)txtCustomerSuburb.Text, (string)txtCustTown.Text, (string)txtPostalCode.Text, (string)comboBoxArchiveStatus.Text, (int)dgvCustomer.CurrentRow.Cells[0].Value, (int)dgvCustomer.CurrentRow.Cells[0].Value);
                    MessageBox.Show("Successfully Updated Customer Profile");
                }
                catch
                {
                    MessageBox.Show("Failed to update customer profile");
                };
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCustomerSurname_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtCustomerSurname.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z]+$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderSurname.SetError(txtCustomerSurname, "Please enter a valid Surname containing only alphabets.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderSurname.SetError(txtCustomerSurname, string.Empty);
            }
        }

        private void txtCustomerSuburb_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtCustomerSuburb.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z\s]+$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderSuburb.SetError(txtCustomerSuburb, "Please enter a valid Suburb containing only alphabets.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderSuburb.SetError(txtCustomerSuburb, string.Empty);
            }
        }

        private void txtCustomerPassword_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtCustomerPassword.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&.#])[A-Za-z\d@$!%*?&.#]{8,}$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderPassword.SetError(txtCustomerPassword, "Please enter a password with :  Minimum length (e.g., at least 8 characters)" +
                    "  At least one uppercase letter " +
                    " At least one lowercase letter" +
                    "At least one digit" +
                    "At least one special character (e.g., @, #, $, etc.)");

            }
            else
            {
                // Clear the error if the text is valid
                errorProviderPassword.SetError(txtCustomerPassword, string.Empty);
            }
        }

        private void txtEmployeeCellphoneNumber_TextChanged(object sender, EventArgs e)
        {
            string cellphoneNumber = txtEmployeeCellphoneNumber.Text;

            // Regex pattern to validate a South African cellphone number
            string pattern = @"^0(6|7|8)\d{8}$";

            if (!Regex.IsMatch(cellphoneNumber, pattern))
            {
                // If the current text is invalid, show an error using the ErrorProvider
                errorProviderCellPhoneNumber.SetError(txtEmployeeCellphoneNumber, "Please enter a valid South African cellphone number (e.g., 0821234567).");
            }
            else
            {
                // Clear the error if the cellphone number is valid
                errorProviderCellPhoneNumber.SetError(txtEmployeeCellphoneNumber, string.Empty);
            }
        }

        private void txtCustomerEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtCustomerEmail.Text;

            // Regex pattern to validate an email address
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";

            if (!Regex.IsMatch(email, pattern))
            {
                // If the current text is invalid, show an error using the ErrorProvider
                errorProviderEmail.SetError(txtCustomerEmail, "Please enter a valid email address (e.g., example@example.com).");
            }
            else
            {
                // Clear the error if the email address is valid
                errorProviderEmail.SetError(txtCustomerEmail, string.Empty);
            }
        }

        private void txtCustomerStreetname_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtCustomerStreetname.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^\d+ [a-zA-Z\s]+$"
;

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderStreetName.SetError(txtCustomerStreetname, "Please enter a valid Street Name with house number , then space then street name (eg. 252 West Street).");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderStreetName.SetError(txtCustomerStreetname, string.Empty);
            }
        }

        


        


        private bool HasErrors(ErrorProvider errorProvider, Control control)
        {
            // Check if the ErrorProvider has an error set for the specified control
            return errorProvider.GetError(control) != string.Empty;
        }

        private void txtEmployeeCellphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }

            // Allow only up to 10 digits
            if (txtEmployeeCellphoneNumber.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }

            // Allow only up to 4 digits
            if (txtPostalCode.Text.Length >= 4 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void dgvCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCustomerName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtCustomerSurname.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtEmployeeCellphoneNumber.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            txtCustomerEmail.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            txtCustomerPassword.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtCustomerStreetname.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
            txtCustomerSuburb.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();  
            txtCustTown.Text = dgvCustomer.CurrentRow.Cells[8].Value.ToString();
            txtPostalCode.Text = dgvCustomer.CurrentRow.Cells[9].Value.ToString();
            comboBoxArchiveStatus.Text = dgvCustomer.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
