using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BriteSparx_POS_System
{



    public partial class Process_Sale_Form : Form
    {
        public Process_Sale_Form()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;



        }

        private void Form3_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'g17Wst2024DataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.g17Wst2024DataSet.EMPLOYEE);
            this.productTableAdapter1.Fill(this.g17Wst2024DataSet.PRODUCT);
            this.cUSTOMERTableAdapter.Fill(this.g17Wst2024DataSet.CUSTOMER);

            comboBoxEmployeeID.Text = global.employee_id;
        }




        private void txtProductDescrip_TextChanged(object sender, EventArgs e)
        {


            string customerName = txtProductDescrip.Text;

            // Regex pattern to match only alphabets (both uppercase and lowercase)
            string pattern = @"^[a-zA-Z]+$";

            if (!Regex.IsMatch(customerName, pattern))
            {
                // If the current text is invalid, show an error or handle it accordingly
                errorProviderProductSearch.SetError(txtProductDescrip, "Please enter a valid product name containing only alphabets.");
            }
            else
            {
                // Clear the error if the text is valid
                errorProviderProductSearch.SetError(txtProductDescrip, string.Empty);
            }
            productTableAdapter1.FillByName(g17Wst2024DataSet.PRODUCT, txtProductDescrip.Text);


        }

        private decimal getTotal()
        {
            decimal sum = 0;
            for (int i = 0; i < dgvCart.Rows.Count - 1; i++)
            {
                sum += (Convert.ToDecimal(dgvCart.Rows[i].Cells[3].Value)) * (Convert.ToDecimal(dgvCart.Rows[i].Cells[4].Value));
            }
            return sum;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvProductSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DataRow dr;
                dr = g17Wst2024DataSet.PRODUCTcart.NewRow();
                for (int i = 0; i < dr.ItemArray.Length; i++)
                {
                    dr[i] = dgvProductSearch.CurrentRow.Cells[i].Value;
                    GlobalVariables.CurrentCartSize++;
                }
                g17Wst2024DataSet.PRODUCTcart.Rows.Add(dr);
            }
            catch
            {
                MessageBox.Show("Please select another item.");
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            txtTotal.Text = getTotal().ToString();
        }

        private void dgvCart_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dgvCart_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            txtTotal.Text = getTotal().ToString();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            txtTotal.Text = getTotal().ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            g17Wst2024DataSet.Clear();
            txtTotal.Text = "";
            txtProductDescrip.Text = "";
            this.productTableAdapter1.Fill(this.g17Wst2024DataSet.PRODUCT);
            this.cUSTOMERTableAdapter.Fill(this.g17Wst2024DataSet.CUSTOMER);
            GlobalVariables.CurrentCartSize = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductDescrip.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Form Edit_Customer_Form = new Edit_Customer_Form();
            Edit_Customer_Form.Show();

        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            cUSTOMERTableAdapter.FillBy(g17Wst2024DataSet.CUSTOMER, (string)txtCustomerSearch.Text);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtCustomerID.Text = dgvCustIDSearch.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvCustIDSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnFinaliseSale_Click(object sender, EventArgs e)
        {
            /*
                       if (txtCustomerID.Text == "")
                       {

                           errorProviderCustomerID.SetError(txtCustomerID, "Please entire a valid customer ID");
                       }
                       else
                       {

                           errorProviderCustomerID.SetError(comboBoxPaymentMethod, string.Empty);

                       }
           */



            if (comboBoxPaymentMethod.SelectedIndex != 0 && comboBoxPaymentMethod.SelectedIndex != 1)
            {
                errorProviderPaymentMethod.SetError(comboBoxPaymentMethod, "Please select a payment method before proceeding");
            }
            else
            {
                errorProviderPaymentMethod.SetError(comboBoxPaymentMethod, string.Empty);
            }


            if (comboBoxCollectionMethod.SelectedIndex != 0 && comboBoxCollectionMethod.SelectedIndex != 1)
            {
                errorProviderCollectionMethod.SetError(comboBoxCollectionMethod, "Please select a Collection method before proceeding");
            }
            else
            {
                errorProviderCollectionMethod.SetError(comboBoxCollectionMethod, string.Empty);
            }


            for (int i = 0; i < dgvCart.Rows.Count - 1; i++)
            {
                double AvailableQuantity = Convert.ToDouble(dgvCart.Rows[i].Cells[5].Value);
                double qty = Convert.ToDouble(dgvCart.Rows[i].Cells[4].Value);
                if (qty > AvailableQuantity)
                {
                    MessageBox.Show("Too many of an item have been selected, please enter a valid amount.");
                    txtCustomerID.Text = "";
                    g17Wst2024DataSet.Clear();
                    txtTotal.Text = "";
                    txtProductDescrip.Text = "";
                    this.productTableAdapter1.Fill(this.g17Wst2024DataSet.PRODUCT);
                    this.cUSTOMERTableAdapter.Fill(this.g17Wst2024DataSet.CUSTOMER);
                    comboBoxEmployeeID.Text = global.employee_id;
                }
            }






            if (!string.IsNullOrEmpty(errorProviderPaymentMethod.GetError(comboBoxPaymentMethod)) ||
                !string.IsNullOrEmpty(errorProviderCollectionMethod.GetError(comboBoxCollectionMethod)) || GlobalVariables.CurrentCartSize == 0)
            {
                MessageBox.Show("Please select a payment method, a collection method a valid Customer ID and more than 0 items in the cart before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Would you like to confirm this sale?", "Sale Confirmation", MessageBoxButtons.YesNo);

                try
                {
                    if (result == DialogResult.Yes)
                    {





                        int SalePK = Convert.ToInt32(Convert.ToDouble(saleTableAdapter1.Count()) + 5);
                        GlobalVariables.CurrentSaleID = SalePK;
                        saleTableAdapter1.InsertQuery(SalePK, Convert.ToInt32(txtCustomerID.Text), Convert.ToInt32(comboBoxEmployeeID.Text), Convert.ToDecimal(txtTotal.Text), DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), comboBoxPaymentMethod.Text, comboBoxCollectionMethod.Text, "In Store", "No");
                        saleTableAdapter1.Fill(g17Wst2024DataSet.SALE);
                        for (int i = 0; i < dgvCart.Rows.Count - 1; i++)
                        {
                            double AvailableQuantity = Convert.ToDouble(dgvCart.Rows[i].Cells[5].Value);
                            double ItemPrice = Convert.ToDouble(dgvCart.Rows[i].Cells[3].Value);
                            double PriceExclVAT = Convert.ToDouble(ItemPrice / 1.15);
                            double qty = Convert.ToDouble(dgvCart.Rows[i].Cells[4].Value);
                            decimal ItemVat = Convert.ToDecimal((ItemPrice - PriceExclVAT) * qty);

                            salE_ITEMSTableAdapter1.InsertSaleItems((int)SalePK, (int)dgvCart.Rows[i].Cells[0].Value, Convert.ToInt32(dgvCart.Rows[i].Cells[4].Value), Convert.ToDecimal(qty * ItemPrice), (decimal)ItemVat, "No");
                            productTableAdapter1.UpdateQuant((int)Convert.ToInt32(AvailableQuantity - qty), (int)dgvCart.Rows[i].Cells[0].Value, (int)dgvCart.Rows[i].Cells[0].Value);

                        }
                        btnCancel.PerformClick();

                        DialogResult receipt = MessageBox.Show("Would you like to print the receipt?", "Sale Confirmation", MessageBoxButtons.YesNo);
                        if (receipt == DialogResult.Yes)
                        {
                            Sale_Reciept receiptForm = new Sale_Reciept();
                            receiptForm.Show();
                            GlobalVariables.CurrentCartSize = 0;

                        }



                    }
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Sale not confirmed.");
                        GlobalVariables.CurrentCartSize = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please fill in all the mandatory fields before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



















































            /*

                        for (int i = 0; i < dgvCart.Rows.Count - 1; i++)
                        {
                            double AvailableQuantity = Convert.ToDouble(dgvCart.Rows[i].Cells[5].Value);
                            double qty = Convert.ToDouble(dgvCart.Rows[i].Cells[4].Value);
                            if (qty > AvailableQuantity)
                            {
                                MessageBox.Show("Too many of an item have been selected, please enter a valid amount.");
                                txtCustomerID.Text = "";
                                g17Wst2024DataSet.Clear();
                                txtTotal.Text = "";
                                txtProductDescrip.Text = "";
                                this.productTableAdapter1.Fill(this.g17Wst2024DataSet.PRODUCT);
                                this.cUSTOMERTableAdapter.Fill(this.g17Wst2024DataSet.CUSTOMER);
                                comboBoxEmployeeID.Text = global.employee_id;
                            }
                        }
                        DialogResult result = MessageBox.Show("Would you like to confirm this sale?", "Sale Confirmation", MessageBoxButtons.YesNo);

                        try
                        {



                                if (result == DialogResult.Yes)
                            {
                                int SalePK = Convert.ToInt32(Convert.ToDouble(saleTableAdapter1.Count()) + 5);
                                GlobalVariables.CurrentSaleID = SalePK;
                                saleTableAdapter1.InsertQuery(SalePK, Convert.ToInt32(txtCustomerID.Text), Convert.ToInt32(comboBoxEmployeeID.Text), Convert.ToDecimal(txtTotal.Text), DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), comboBoxPaymentMethod.Text, comboBoxCollectionMethod.Text, "In Store", "No");
                                saleTableAdapter1.Fill(g17Wst2024DataSet.SALE);
                                for (int i = 0; i < dgvCart.Rows.Count - 1; i++)
                                {
                                    double AvailableQuantity = Convert.ToDouble(dgvCart.Rows[i].Cells[5].Value);                                             
                                    double ItemPrice = Convert.ToDouble(dgvCart.Rows[i].Cells[3].Value);
                                    double PriceExclVAT = Convert.ToDouble(ItemPrice / 1.15);
                                    double qty = Convert.ToDouble(dgvCart.Rows[i].Cells[4].Value);
                                    decimal ItemVat = Convert.ToDecimal((ItemPrice - PriceExclVAT) * qty);
                                    salE_ITEMSTableAdapter1.InsertSaleItems((int)SalePK, (int)dgvCart.Rows[i].Cells[0].Value, Convert.ToInt32(dgvCart.Rows[i].Cells[4].Value), Convert.ToDecimal(qty * ItemPrice), (decimal)ItemVat, "No");
                                    productTableAdapter1.UpdateQuant((int)Convert.ToInt32(AvailableQuantity - qty), (int)dgvCart.Rows[i].Cells[0].Value, (int)dgvCart.Rows[i].Cells[0].Value);

                                }
                                btnCancel.PerformClick();
                                comboBoxEmployeeID.Text = global.employee_id;
                                DialogResult receipt = MessageBox.Show("Would you like to print the receipt?", "Sale Confirmation", MessageBoxButtons.YesNo);
                                if (receipt == DialogResult.Yes)
                                {
                                    Sale_Reciept receiptForm = new Sale_Reciept();
                                    receiptForm.Show();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Please fill in all the mandatory fields before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }



            */





            /*
                        if (result == DialogResult.No)
                        {
                            MessageBox.Show("Sale not confirmed.");
                        }



                        if (comboBoxPaymentMethod.SelectedIndex == 0)
                        {
                            errorProviderPaymentMethod.SetError(comboBoxPaymentMethod,"Please select a payment method before proceeding");
                        }
                        else
                        {

                            errorProviderPaymentMethod.SetError(comboBoxPaymentMethod, string.Empty);

                        }


            */

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to return to the main menu?", "Confirm return", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }

            // Allow only up to 4 digits
            if (txtCustomerID.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (this.dgvCart.SelectedRows.Count > 0)
            {
                dgvCart.Rows.RemoveAt(this.dgvCart.SelectedRows[0].Index);
                GlobalVariables.CurrentCartSize--;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }



    public static class GlobalVariables
    {
        // Define your global variable(s) here
        public static string GlobalMessage = "Hello from Global Variable!";
        public static int CurrentSaleID = 16;
        public static int CurrentCartSize = 0;
    }
}
