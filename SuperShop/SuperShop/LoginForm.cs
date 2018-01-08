using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace SuperShop
{
    public partial class LoginForm : MetroForm
    {
        
        private DBConnection connection = new DBConnection();
        private int loginCount = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void passBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                metroButton1_Click(sender, e);
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            passBox.PasswordChar = metroCheckBox1.Checked ? '\0' : '•';
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string accountType = "";
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "SELECT * FROM [User] WHERE USERNAME = '" + userNameBox.Text.Trim() + "' AND PASSWORD = '" +
                               passBox.Text.Trim() + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            loginCount++;
                            accountType = reader["account_type"].ToString();
                        }
                    }
                }
            }

            if (loginCount == 1 && accountType == "Admin")
            {
                Hide();
                new AdminPanel(userNameBox.Text).Show();
            }
            else if (loginCount == 1 && accountType == "Employee")
            {
                Hide();
                new EmployeePanel(userNameBox.Text).Show();
            }
            else
            {
                MessageBox.Show(@"Access Denied", @"Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passBox.Text = "";
            }
        }

        private void metroButton1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
