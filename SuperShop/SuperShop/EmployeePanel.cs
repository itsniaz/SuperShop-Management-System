using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using SuperShop.Panels;

namespace SuperShop
{
    public partial class EmployeePanel : MetroForm
    {
        private string username, employeeName, employeeEmail, employeeContact, employeeJoinDate;
        private SqlDataReader reader;
        private DBConnection connection = new DBConnection();

        public EmployeePanel(string username)
        {
            this.username = username;
            reader = connection.ReadQuery("SELECT * FROM [User] where username = '" + this.username + "' and account_type = 'Employee'");
            while (reader.Read())
            {
                employeeName = reader["name"].ToString();
                employeeEmail = reader["email"].ToString();
                employeeContact = reader["contact_no"].ToString();
                employeeJoinDate = reader["join_date"].ToString();
            }

            InitializeComponent();

            lblAdminName.Text = employeeName;
            lblEmail.Text = @"Email: " + employeeEmail;
            lblContact.Text = @"Contact: " + employeeContact;
            lblJoinDate.Text = @"Joined on: " + employeeJoinDate;
        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new SellProducts(username));
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new ManageCustomer());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new Inventory());
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new SalesReport());
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new ProfileEmployee(this.username));
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new About());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info =
                new ProcessStartInfo
                {
                    Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    FileName = "cmd.exe"
                };
            Process.Start(info);
            Application.Exit();
        }
    }
}
