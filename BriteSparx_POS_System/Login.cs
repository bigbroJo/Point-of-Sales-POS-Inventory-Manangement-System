using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BriteSparx_POS_System
{
    static class global
    {
        public static string employee_id;
    }

    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=G17Wst2024;User ID=G17Wst2024;Password=5266w");

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Focus();
            this.AcceptButton = btnLogin;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string employee_id;
            string employee_password;
            global.employee_id = txtID.Text;
            employee_password = txtPassword.Text;


            string query = "SELECT * FROM Employee WHERE employee_id = '" + txtID.Text + "' AND employee_password = '" + txtPassword.Text + "' AND archive_status = '" + ("No") + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                employee_id = txtID.Text;
                employee_password = txtPassword.Text;


                var employeeRow = dtable.Rows[0];
                string employeePosition = employeeRow["Employee_Position"].ToString();
                MessageBox.Show("Successfully logged in as: " + employeePosition);
                MainMenu mainMenu = new MainMenu();
                mainMenu.SetMenuItemsAccessibility(employeePosition);
                mainMenu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid details");
            }

            
        }

        


        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}




