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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void processSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form3 = new Process_Sale_Form();
            Form3.Show();
        }

        private void manageInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form5 = new Inventory_Management();
            Form5.Show();
        }

       

        private void adnimManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form4 = new Employee_Management();
            Form4.Show();
        }




        public void SetMenuItemsAccessibility(string employeePosition)
        {
            if (employeePosition != "Manager")
            {
                // Disable specific menu items
                manageInventoryToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
                EmployeeManagementToolStripMenuItem.Visible = false;
            }
            else
            {
                // Enable specific menu items
                manageInventoryToolStripMenuItem.Enabled = true;
                reportsToolStripMenuItem.Enabled = true;
                EmployeeManagementToolStripMenuItem.Enabled = true;
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm login = new MainForm();
            login.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dummy Comment 2
            Form Form3 = new View_Sales();
            Form3.Show();
        }
    }
}
