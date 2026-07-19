using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BriteSparx_POS_System
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        //When the Report Form Loads
        private void Reports_Load(object sender, EventArgs e)
        {
            // Fills all the used tables with data
            this.pRODUCTTableAdapter.Fill(this.dsReportsForm.PRODUCT);
            this.taCustomer.Fill(this.dsReportsForm.CUSTOMER);
            this.taSales.Fill(this.dsReportsForm.SALE);
            this.taSale_Items.Fill(this.dsReportsForm.SALE_ITEMS);
            this.taProduct.Fill(this.dsReportsForm.PRODUCT);
            this.taEmployee.Fill(this.dsReportsForm.EMPLOYEE);

            //Sets the Data Sources for all 4 crystal reports
            crCustomerSales1.SetDataSource(dsReportsForm);
            productsByMonth.SetDataSource(dsReportsForm);
            sales1.SetDataSource(dsReportsForm);
            employeeReport21.SetDataSource(dsReportsForm);
            summarySalesReport1.SetDataSource(dsReportsForm);
            stockReport1.SetDataSource(dsReportsForm);
            stockReportThreshold1.SetDataSource(dsReportsForm);


            //Fills all 4 of the comboBoxes that allow you to select the month
            comboBox1.DataSource = new List<string> {
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December"
            };


            MonthcomboBox.DataSource = new List<string> {
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"
                };


            EmployeeMonthComboBox.DataSource = new List<string> {
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"
                };




            comboBox2.DataSource = new List<string> {
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"
                };

        }

        //Functions for the Customer Tab
        private void Unchecked(ReportDocument report, string customerID, string month, CrystalReportViewer viewer)
        {
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;

            report.SetParameterValue("CustomerID", customerID);
            report.SetParameterValue("Month", month);
            report.SetParameterValue("Year", currentYear.ToString());

            viewer.ReportSource = report;
            viewer.Refresh();
        }

        private void Checked(ReportDocument report, string customerID, string month, string year, CrystalReportViewer viewer)
        {
            report.SetParameterValue("CustomerID", customerID);
            report.SetParameterValue("Month", month);
            report.SetParameterValue("Year", year);

            viewer.ReportSource = report;
            viewer.Refresh();
        }


        //Customer Tab
        //By Month Tab
        private void GetReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == false)
                {

                    Unchecked(crCustomerSales1, CustomerIDTextBox.Text, comboBox1.SelectedItem.ToString(), CRV1);
                }
                else
                {
                    Checked(crCustomerSales1, CustomerIDTextBox.Text, comboBox1.SelectedItem.ToString(), YearTextBox.Text, CRV1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Customer ID or Year, please try again");
            }
        }




        // Product Report Tab
        //By Month Tab
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked == false)
                {
                    DateTime currentDate = DateTime.Now;
                    int currentYear = currentDate.Year;

                    productsByMonth.SetParameterValue("ProductName", ProductNameComboBox.SelectedValue);
                    productsByMonth.SetParameterValue("Month", MonthcomboBox.SelectedItem.ToString());
                    productsByMonth.SetParameterValue("Year", currentYear.ToString());

                    CRV2.ReportSource = productsByMonth;
                    CRV2.Refresh();
                }
                else
                {
                    productsByMonth.SetParameterValue("ProductName", ProductNameComboBox.SelectedValue);
                    productsByMonth.SetParameterValue("Month", MonthcomboBox.SelectedItem.ToString());
                    productsByMonth.SetParameterValue("Year", textBox1.Text);

                    CRV2.ReportSource = productsByMonth;
                    CRV2.Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Year, please try again");
            }
        }






        //Employee Report Tab
        //By Month Tab
        private void GetEmployeeReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox3.Checked == false)
                {


                    DateTime currentDate = DateTime.Now;
                    int currentYear = currentDate.Year;

                    employeeReport21.SetParameterValue("EmployeeID", EmployeeIDTextBox.Text);
                    employeeReport21.SetParameterValue("Month", EmployeeMonthComboBox.SelectedItem.ToString());
                    employeeReport21.SetParameterValue("Year", currentYear.ToString());

                    CRV3.ReportSource = employeeReport21;
                    CRV3.Refresh();
                }
                else
                {
                    employeeReport21.SetParameterValue("EmployeeID", EmployeeIDTextBox.Text);
                    employeeReport21.SetParameterValue("Month", EmployeeMonthComboBox.SelectedItem.ToString());
                    employeeReport21.SetParameterValue("Year", EmployeeYearTextBox.Text);

                    CRV3.ReportSource = employeeReport21;
                    CRV3.Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Year, please try again");
            }
        }






        // Sale Report Tab
        //By Month Tab
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Sale_Reciept receipt_Report = new Sale_Reciept();
            //receipt_Report.Show();
            if (checkBox6.Checked == false)
            {

                try
                {
                    if (checkBox4.Checked == false)
                    {
                        DateTime currentDate = DateTime.Now;
                        int currentYear = currentDate.Year;
                        summarySalesReport1.SetParameterValue("Month", comboBox2.SelectedItem.ToString());
                        summarySalesReport1.SetParameterValue("Year", currentYear.ToString());
                        // sales1.SetParameterValue("Sale_ID", 2);
                        CRV4.ReportSource = summarySalesReport1;
                        CRV4.Refresh();
                    }
                    else
                    {
                        summarySalesReport1.SetParameterValue("Month", comboBox2.SelectedItem.ToString());
                        summarySalesReport1.SetParameterValue("Year", SaleYearTextBox.Text);

                        CRV4.ReportSource = summarySalesReport1;
                        CRV4.Refresh();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Year, please try again");
                }





            }
            else
            {


                try
                {
                    if (checkBox4.Checked == false)
                    {
                        DateTime currentDate = DateTime.Now;
                        int currentYear = currentDate.Year;
                        sales1.SetParameterValue("Month", comboBox2.SelectedItem.ToString());
                        sales1.SetParameterValue("Year", currentYear.ToString());
                        // sales1.SetParameterValue("Sale_ID", 2);
                        CRV4.ReportSource = sales1;
                        CRV4.Refresh();
                    }
                    else
                    {
                        sales1.SetParameterValue("Month", comboBox2.SelectedItem.ToString());
                        sales1.SetParameterValue("Year", SaleYearTextBox.Text);

                        CRV4.ReportSource = sales1;
                        CRV4.Refresh();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Year, please try again");
                }


            }


        }





        //Customer Report Tab Visibility Settings
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            YearTextBox.Enabled = checkBox1.Checked;
            YearTextBox.Visible = checkBox1.Checked;
            label4.Visible = checkBox1.Checked;
        }

        //Product Report Tab Visibility Settings
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox2.Checked;
            textBox1.Visible = checkBox2.Checked;
            label6.Visible = checkBox2.Checked;
        }


        //Employee Report Tab Visibility Settings
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeYearTextBox.Enabled = checkBox3.Checked;
            EmployeeYearTextBox.Visible = checkBox3.Checked;
            label7.Visible = checkBox3.Checked;
        }


        //Sale Report Tab Visibility Settings
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            SaleYearTextBox.Enabled = checkBox4.Checked;
            SaleYearTextBox.Visible = checkBox4.Checked;
            label11.Visible = checkBox4.Checked;
        }



        private void button3_Click(object sender, EventArgs e)
        {

            if (checkBox5.Checked == false)
            {

                CRV2.ReportSource = stockReport1;
                CRV2.Refresh();

            }
            else
            {

                CRV2.ReportSource = stockReportThreshold1;
                CRV2.Refresh();


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to print this report?", "Confirm Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                CRV4.PrintReport();

            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to print this report?", "Confirm Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                CRV2.PrintReport();

            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to print this report?", "Confirm Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                CRV3.PrintReport();

            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to print this report?", "Confirm Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                CRV1.PrintReport();

            }
            else
            {

            }
        }
    }
}









