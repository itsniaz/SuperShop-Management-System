using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using  System.Diagnostics;
using MetroFramework.Forms;
using SuperShop.Panels;

namespace SuperShop
{
    public partial class AdminPanel : MetroForm
    {
        private string username, adminName, adminEmail, adminContact, adminJoinDate;
        private SqlDataReader reader;
        private DBConnection connection = new DBConnection();

        public AdminPanel(string username)
        {
            this.username = username;
            reader = connection.ReadQuery("SELECT * FROM [User] where username = '" + this.username + "'");
            while (reader.Read())
            {
                adminName = reader["name"].ToString();
                adminEmail = reader["email"].ToString();
                adminContact = reader["contact_no"].ToString();
                adminJoinDate = reader["join_date"].ToString();
            }
         
            InitializeComponent();

            lblAdminName.Text = adminName;
            lblEmail.Text = @"Email: " + adminEmail;
            lblContact.Text = @"Contact: " + adminContact;
            lblJoinDate.Text = @"Joined on: " + adminJoinDate;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           tempPanel.Controls.Clear(); 
           tempPanel.Controls.Add(new AddProd());
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new ManageProd()); 
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

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.tempPanel.Controls.Clear();
            this.tempPanel.Controls.Add(new ProfileAdmin(username));
        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new SellProducts(username));
        }

        private void btnDatabaseBackup_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new DatabaseBackup());
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

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new ManageEmployee());
        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new CompanyInfo());
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new SalesReport());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            tempPanel.Controls.Clear();
            tempPanel.Controls.Add(new About());
        }

        private void timerSystemTime_Tick(object sender, EventArgs e)
        {
            lblSystemTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            lblSystemDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }
    }
}
