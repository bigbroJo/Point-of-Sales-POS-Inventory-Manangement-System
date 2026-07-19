using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BriteSparx_POS_System
{
    public partial class View_Sales : Form
    {
        public View_Sales()
        {
            InitializeComponent();
        }

        private void View_Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g17Wst2024DataSet.INVENTORY_PURCHASE' table. You can move, or remove it, as needed.
            this.iNVENTORY_PURCHASETableAdapter.Fill(this.g17Wst2024DataSet.INVENTORY_PURCHASE);


            // TODO: This line of code loads data into the 'g17Wst2024DataSet.SALE' table. You can move, or remove it, as needed.
            this.sALETableAdapter.Fill(this.g17Wst2024DataSet.SALE);

        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvSales_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            salE_ITEM_INNERJOINTableAdapter1.FillBy(g17Wst2024DataSet.SALE_ITEM_INNERJOIN, Convert.ToInt32(dgvSales.CurrentRow.Cells[0].Value));
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to return to the main menu?", "Confirm return", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtEmployee_ID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearchbyDate_Click(object sender, EventArgs e)
        {
            txtEmployee_ID.Clear();
            txtCustomerID.Clear();
            cmbPaymentType.SelectedIndex = -1;
            cmbSaleType.SelectedIndex = -1;
            try
            {
                sALETableAdapter.FillByDateofSale(g17Wst2024DataSet.SALE, txtDateofSale.Text);

            }
            catch
            {
                sALETableAdapter.Fill(g17Wst2024DataSet.SALE);
            }
        }

        private void btnEmpIDSearch_Click(object sender, EventArgs e)
        {
            txtDateofSale.Clear();
            txtCustomerID.Clear();
            cmbPaymentType.SelectedIndex = -1;
            cmbSaleType.SelectedIndex = -1;
            try
            {
                sALETableAdapter.FillByEmployeeID(g17Wst2024DataSet.SALE, Convert.ToInt32(txtEmployee_ID.Text));

            }
            catch
            {
                sALETableAdapter.Fill(g17Wst2024DataSet.SALE);
            }
        }

        private void btnCustIDSearch_Click(object sender, EventArgs e)
        {
            txtDateofSale.Clear();
            txtEmployee_ID.Clear();
            cmbPaymentType.SelectedIndex = -1;
            cmbSaleType.SelectedIndex = -1;
            try
            {
                sALETableAdapter.FillByCustomer_ID(g17Wst2024DataSet.SALE, Convert.ToInt32(txtCustomerID.Text));

            }
            catch
            {
                sALETableAdapter.Fill(g17Wst2024DataSet.SALE);
            }
        }

        private void btnPaymentTypeSearch_Click(object sender, EventArgs e)
        {
            txtDateofSale.Clear();
            txtEmployee_ID.Clear();
            txtCustomerID.Clear();
            cmbSaleType.SelectedIndex = -1;
            try
            {
                sALETableAdapter.FillByPaymentType(g17Wst2024DataSet.SALE, cmbPaymentType.Text);
            }
            catch
            {
                sALETableAdapter.Fill(g17Wst2024DataSet.SALE);
            }
        }

        private void btnSaleTypeSearch_Click(object sender, EventArgs e)
        {
            txtDateofSale.Clear();
            txtEmployee_ID.Clear();
            txtCustomerID.Clear();
            cmbPaymentType.SelectedIndex = -1;
            try
            {
                sALETableAdapter.FillBySaleType(g17Wst2024DataSet.SALE, cmbSaleType.Text);
            }
            catch
            {
                sALETableAdapter.Fill(g17Wst2024DataSet.SALE);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDateofSale.Clear();
            txtEmployee_ID.Clear();
            txtCustomerID.Clear();
            cmbPaymentType.SelectedIndex = -1;
            cmbSaleType.SelectedIndex = -1;
            sALETableAdapter.Fill(g17Wst2024DataSet.SALE);

        }
    }
}
