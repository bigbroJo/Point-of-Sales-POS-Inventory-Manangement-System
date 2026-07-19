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
    public partial class Inventory_Management : Form
    {
        public Inventory_Management()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pRODUCTTableAdapter.Fill(g17Wst2024DataSet.PRODUCT);

        }

        private void txtsearchProduct_TextChanged(object sender, EventArgs e)
        {
            pRODUCTTableAdapter.FillByName(g17Wst2024DataSet.PRODUCT, txtsearchProduct.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool hasErrors = false;

            // List of all ErrorProvider instances on the form
            // Define a dictionary with ErrorProvider as the key and a list of associated controls as the value
            var errorProviderMap = new Dictionary<ErrorProvider, List<Control>>
{
    { errorProviderProductName, new List<Control> { txtNewProdName } },
    { errorProviderProductDescription, new List<Control> { txtNewProdDescription } },
    
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
                MessageBox.Show("Please correct the errors before adding the new product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    pRODUCTTableAdapter.InsertQuery((string)txtNewProdName.Text, (string)txtNewProdDescription.Text, (int)Convert.ToInt32(txtNewProdAvailStock.Text), (decimal)Convert.ToDecimal(txtNewProdSalePrice.Text), (int)Convert.ToInt32(txtNewProdReoder.Text), (string)txtNewProdArchiveStat.Text);
                    MessageBox.Show("New Product added successfully");
                    pRODUCTTableAdapter.Fill(g17Wst2024DataSet.PRODUCT);
                }
                catch
                {
                    MessageBox.Show("New Product failed to be added.");
                }
            }





            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool hasErrors = false;

            // List of all ErrorProvider instances on the form
            // Define a dictionary with ErrorProvider as the key and a list of associated controls as the value
            var errorProviderMap = new Dictionary<ErrorProvider, List<Control>>
{
    { errorProviderProductName, new List<Control> { txtNewProdName } },
    { errorProviderProductDescription, new List<Control> { txtNewProdDescription } },

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
                MessageBox.Show("Please correct the errors before adding the new product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Would you like to update the product information?", "Confirm update", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        pRODUCTTableAdapter.UpdateQuery((string)txtNewProdName.Text, (string)txtNewProdDescription.Text, (int)Convert.ToInt32(txtNewProdAvailStock.Text), (decimal)Convert.ToDecimal(txtNewProdSalePrice.Text), (int)Convert.ToInt32(txtNewProdReoder.Text), (string)txtNewProdArchiveStat.Text, (int)dgvProductManage.CurrentRow.Cells[0].Value, (string)dgvProductManage.CurrentRow.Cells[1].Value);
                        MessageBox.Show("Product Successfully Updated.");
                    }
                    catch
                    {
                        MessageBox.Show("Failed to update Product, Please ensure all details are filled in correctly");
                    }
                }
                else
                {
                    MessageBox.Show("Product update has failed.");
                }
            }



           

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to return to the main menu?", "Confirm return", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvProductManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductManage_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNewProdName.Text = dgvProductManage.CurrentRow.Cells[1].Value.ToString();
            txtNewProdDescription.Text = dgvProductManage.CurrentRow.Cells[2].Value.ToString();
            txtNewProdAvailStock.Text = dgvProductManage.CurrentRow.Cells[3].Value.ToString();
            txtNewProdSalePrice.Text = dgvProductManage.CurrentRow.Cells[4].Value.ToString();
            txtNewProdReoder.Text = dgvProductManage.CurrentRow.Cells[5].Value.ToString();
            txtNewProdArchiveStat.Text = dgvProductManage.CurrentRow.Cells[6].Value.ToString();
        }

        private void txtNewProdName_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtNewProdName.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z0-9 ]*$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderProductName.SetError(txtNewProdName, "Please enter a valid item name containing only alphabets.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderProductName.SetError(txtNewProdName, string.Empty);
            }
        }

        private void txtNewProdDescription_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtNewProdDescription.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z0-9 ]*$";
;

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderProductDescription.SetError(txtNewProdDescription, "Please enter a valid description containing only alphabets and spaces.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderProductDescription.SetError(txtNewProdDescription, string.Empty);
            }
        }

        private void txtNewProdAvailStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }

            // Allow only up to 4 digits
            if (txtNewProdAvailStock.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void txtNewProdSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }

            // Allow only up to 4 digits
            if (txtNewProdSalePrice.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void txtNewProdReoder_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }

            // Allow only up to 4 digits
            if (txtNewProdReoder.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }


        private bool HasErrors(ErrorProvider errorProvider, Control control)
        {
            // Check if the ErrorProvider has an error set for the specified control
            return errorProvider.GetError(control) != string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pRODUCTTableAdapter.FillByDescription(g17Wst2024DataSet.PRODUCT, txtSearchProductDescription.Text);
        }
    }
}
