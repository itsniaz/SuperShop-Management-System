using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop.Panels
{
    public partial class CompanyInfo : UserControl
    {
        private DBConnection connection = new DBConnection();
        private SqlDataReader reader;
        private string companyName, companyAddress = "";
        public CompanyInfo()
        {
            reader = connection.ReadQuery("SELECT * FROM [Company_Info]");
            while (reader.Read())
            {
                companyName = reader["company_name"].ToString();
                companyAddress = reader["address"].ToString();
            }
            
            InitializeComponent();
            Dock = DockStyle.Fill;
            lblCompanyName.Text = companyName;
            lblCompanyAddress.Text = companyAddress;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "" && txtCompanyAddress.Text == "")
            {
                MessageBox.Show("Empty fields", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            //Company Name
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "UPDATE [Company_Info] SET company_name = '" + ((txtCompanyName.Text == "") ? companyName : txtCompanyName.Text) + "'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

            }
            //Company Address
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "UPDATE [Company_Info] SET address = '" + ((txtCompanyAddress.Text == "") ? companyAddress : txtCompanyAddress.Text) + "'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

            }
            MessageBox.Show(@"Updated. Application will restart now.", @"Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = txtCompanyName.Text != "";
        }

        private void txtCompanyAddress_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = txtCompanyAddress.Text != "";
        }


    }
}
