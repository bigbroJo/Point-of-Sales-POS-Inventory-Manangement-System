using System;
using System.Windows.Forms;

namespace BriteSparx_POS_System
{
    public partial class Sale_Reciept : Form
    {
        public Sale_Reciept()
        {
            InitializeComponent();
        }

        private void Sale_Reciept_Load(object sender, EventArgs e)
        {


            this.WindowState = FormWindowState.Maximized;
            // Fills all the used tables with data
            this.productTableAdapter1.Fill(this.g17Wst2024DataSet1.PRODUCT);
            this.customerTableAdapter1.Fill(this.g17Wst2024DataSet1.CUSTOMER);
            this.saleTableAdapter1.Fill(this.g17Wst2024DataSet1.SALE);
            this.salE_ITEMSTableAdapter1.Fill(this.g17Wst2024DataSet1.SALE_ITEMS);
            this.productTableAdapter1.Fill(this.g17Wst2024DataSet1.PRODUCT);
            this.employeeTableAdapter1.Fill(this.g17Wst2024DataSet1.EMPLOYEE);




            //Sets the Data Sources for all 4 crystal reports
            sales_Receipt_Report.SetDataSource(g17Wst2024DataSet1);

            int currentSaleID = GlobalVariables.CurrentSaleID;

            sales_Receipt_Report.SetParameterValue("Month", DateTime.Now.ToString("MMMM"));
            sales_Receipt_Report.SetParameterValue("Year", DateTime.Now.Year.ToString());
            sales_Receipt_Report.SetParameterValue("Sale_ID", currentSaleID);


            crystalReportViewer1.ReportSource = sales_Receipt_Report;
            crystalReportViewer1.Refresh();




        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {



            DialogResult result = MessageBox.Show("Are you sure you want to print this report?", "Confirm Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                crystalReportViewer1.PrintReport();

            }
            else
            {

            }
        }
    }
}
