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
    public partial class Employee_Management : Form
    {
        public Employee_Management()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            taEmployee.Fill(g17Wst2024DataSet.EMPLOYEE);
            txtNewEmployeePassword.PasswordChar = '*';

        }

        private void txtEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            taEmployee.FillBy(g17Wst2024DataSet.EMPLOYEE, txtEmployeeSearch.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string cellphoneNumber = txtNewEmployeeCell.Text;

            // Regex pattern to validate a South African cellphone number
            string pattern = @"^0(6|7|8)\d{8}$";

            if (!Regex.IsMatch(cellphoneNumber, pattern))
            {
                // If the current text is invalid, show an error using the ErrorProvider
                errorProviderCellphoneNumber.SetError(txtNewEmployeeCell, "Please enter a valid South African cellphone number (e.g., 0821234567).");
            }
            else
            {
                // Clear the error if the cellphone number is valid
                errorProviderCellphoneNumber.SetError(txtNewEmployeeCell, string.Empty);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            bool hasErrors = false;

            // List of all ErrorProvider instances on the form
            // Define a dictionary with ErrorProvider as the key and a list of associated controls as the value
            var errorProviderMap = new Dictionary<ErrorProvider, List<Control>>
{
    { errorProviderSurname, new List<Control> { txtNewEmployeeSurname } },
    { errorProviderPassword, new List<Control> { txtNewEmployeePassword } },
    { errorProviderSalary, new List<Control> { txtNewEmployeeSalary } },
    { errorProviderCellphoneNumber, new List<Control> { txtNewEmployeeCell } },
    { errorProviderIDNumber, new List<Control> { txtNewEmployeeIDno } },
    { errorProviderEmail, new List<Control> { txtNewEmployeeEmail } },
    { errorProviderName, new List<Control> { txtNewEmployeeName } }
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
                try
                {
                    taEmployee.InsertQuery((string)txtNewEmployeeName.Text, (string)txtNewEmployeeSurname.Text, (string)txtNewEmployeeCell.Text, (string)txtNewEmployeeEmail.Text, (string)txtNewEmployeePassword.Text, (decimal)Convert.ToDecimal(txtNewEmployeeSalary.Text), (string)txtNewEmployeePosition.Text, (string)txtNewEmployeeIDno.Text, (string)("No"));
                    MessageBox.Show("New Employee Profile successfully added.");
                }
                catch
                {
                    MessageBox.Show("New Employee Profile has FAILED to be added.");
                };
            }
        }

        private void btnUpdateEmployeeInfo_Click(object sender, EventArgs e)
        {
            bool hasErrors = false;

            // List of all ErrorProvider instances on the form
            // Define a dictionary with ErrorProvider as the key and a list of associated controls as the value
            var errorProviderMap = new Dictionary<ErrorProvider, List<Control>>
{
    { errorProviderSurname, new List<Control> { txtNewEmployeeSurname } },
    { errorProviderPassword, new List<Control> { txtNewEmployeePassword } },
    { errorProviderSalary, new List<Control> { txtNewEmployeeSalary } },
    { errorProviderCellphoneNumber, new List<Control> { txtNewEmployeeCell } },
    { errorProviderIDNumber, new List<Control> { txtNewEmployeeIDno } },
    { errorProviderEmail, new List<Control> { txtNewEmployeeEmail } },
    { errorProviderName, new List<Control> { txtNewEmployeeName } }
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
                try
                {
                    DialogResult result = MessageBox.Show("Would you like to update this profile ?", "Update Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        taEmployee.UpdateQuery((string)txtNewEmployeeName.Text, (string)txtNewEmployeeSurname.Text, (string)txtNewEmployeeCell.Text, (string)txtNewEmployeeEmail.Text, (string)txtNewEmployeePassword.Text, (decimal)Convert.ToDecimal(txtNewEmployeeSalary.Text), (string)txtNewEmployeePosition.Text, (string)txtNewEmployeeIDno.Text, (string)cbArchiveStatus.Text, (int)dgvEmployeeManagement.CurrentRow.Cells[0].Value, (string)dgvEmployeeManagement.CurrentRow.Cells[1].Value);
                        taEmployee.Fill(g17Wst2024DataSet.EMPLOYEE);
                        MessageBox.Show("Details successfully updated.");
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Update Cancelled.");
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to Update Profile");
                }
            }
        }

        private void dgvEmployeeManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployeeManagement_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNewEmployeeName.Text = dgvEmployeeManagement.CurrentRow.Cells[1].Value.ToString();
            txtNewEmployeeSurname.Text = dgvEmployeeManagement.CurrentRow.Cells[2].Value.ToString();
            txtNewEmployeeCell.Text = dgvEmployeeManagement.CurrentRow.Cells[3].Value.ToString();
            txtNewEmployeeEmail.Text = dgvEmployeeManagement.CurrentRow.Cells[4].Value.ToString();
            txtNewEmployeePassword.Text = dgvEmployeeManagement.CurrentRow.Cells[5].Value.ToString();
            txtNewEmployeeSalary.Text = dgvEmployeeManagement.CurrentRow.Cells[6].Value.ToString();
            txtNewEmployeePosition.Text = dgvEmployeeManagement.CurrentRow.Cells[7].Value.ToString();
            txtNewEmployeeIDno.Text = dgvEmployeeManagement.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to return to the main menu?", "Confirm return", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewEmployeeName.Text = "";
            txtNewEmployeeSurname.Text = "";
            txtNewEmployeeCell.Text = "";
            txtNewEmployeeEmail.Text = "";
            txtNewEmployeePassword.Text = "";
            txtNewEmployeeSalary.Text = "";
            txtNewEmployeePosition.Text = "";
            txtNewEmployeeIDno.Text = "";
        }


        private bool HasErrors(ErrorProvider errorProvider, Control control)
        {
            // Check if the ErrorProvider has an error set for the specified control
            return errorProvider.GetError(control) != string.Empty;
        }

        private void txtNewEmployeeSurname_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtNewEmployeeSurname.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z]+$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderSurname.SetError(txtNewEmployeeSurname, "Please enter a valid Surname containing only alphabets.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderSurname.SetError(txtNewEmployeeSurname, string.Empty);
            }
        }

        private void txtNewEmployeeName_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtNewEmployeeName.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z]+$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderName.SetError(txtNewEmployeeName, "Please enter a valid name containing only alphabets.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderName.SetError(txtNewEmployeeName, string.Empty);
            }
        }

        private void txtNewEmployeeCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }

            // Allow only up to 10 digits
            if (txtNewEmployeeCell.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void txtNewEmployeeEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtNewEmployeeEmail.Text;

            // Regex pattern to validate an email address
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";

            if (!Regex.IsMatch(email, pattern))
            {
                // If the current text is invalid, show an error using the ErrorProvider
                errorProviderEmail.SetError(txtNewEmployeeEmail, "Please enter a valid email address (e.g., example@example.com).");
            }
            else
            {
                // Clear the error if the email address is valid
                errorProviderEmail.SetError(txtNewEmployeeEmail, string.Empty);
            }
        }

        private void txtNewEmployeePassword_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtNewEmployeePassword.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&.#])[A-Za-z\d@$!%*?&.#]{8,}$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderPassword.SetError(txtNewEmployeePassword, "Please enter a password with :  Minimum length (e.g., at least 8 characters)" +
                    "  At least one uppercase letter " +
                    " At least one lowercase letter" +
                    "At least one digit" +
                    "At least one special character (e.g., @, #, $, etc.)");

            }
            else
            {
                // Clear the error if the text is valid
                errorProviderPassword.SetError(txtNewEmployeePassword, string.Empty);
            }
        }

        private void txtNewEmployeeSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }

            // Allow only up to 7 digits
            if (txtNewEmployeeSalary.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void txtNewEmployeeSalary_TextChanged(object sender, EventArgs e)
        {
            string cellphoneNumber = txtNewEmployeeSalary.Text;

            // Regex pattern to validate a South African cellphone number
            string pattern = @"^[\d\p{P}\s]+$"
;

            if (!Regex.IsMatch(cellphoneNumber, pattern))
            {
                // If the current text is invalid, show an error using the ErrorProvider
                errorProviderSalary.SetError(txtNewEmployeeSalary, "Please enter a valid Salary.");
            }
            else
            {
                // Clear the error if the cellphone number is valid
                errorProviderSalary.SetError(txtNewEmployeeSalary, string.Empty);
            }
        }

        private void txtNewEmployeePosition_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtNewEmployeePosition.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z]+$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderName.SetError(txtNewEmployeePosition, "Please enter a valid name containing only alphabets.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderName.SetError(txtNewEmployeePosition, string.Empty);
            }
        }

        private void txtNewEmployeeIDno_TextChanged(object sender, EventArgs e)
        {
            string cellphoneNumber = txtNewEmployeeIDno.Text;

            // Regex pattern to validate a South African cellphone number
            string pattern = @"^(?!000000)[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01])[0-9]{4}[01][89][0-9]$";

            if (!Regex.IsMatch(cellphoneNumber, pattern))
            {
                // If the current text is invalid, show an error using the ErrorProvider
                errorProviderCellphoneNumber.SetError(txtNewEmployeeIDno, "Please enter a valid South African ID number (e.g., 0208185342087).");
            }
            else
            {
                // Clear the error if the cellphone number is valid
                errorProviderCellphoneNumber.SetError(txtNewEmployeeIDno, string.Empty);
            }
        }

        private void txtNewEmployeeIDno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }

            // Allow only up to 4 digits
            if (txtNewEmployeeIDno.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }
    }
}
