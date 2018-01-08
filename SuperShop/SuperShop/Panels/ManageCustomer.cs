using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop.Panels
{
    public partial class ManageCustomer : UserControl
    {
        private DBConnection connection = new DBConnection();
        private SqlDataAdapter sda;
        private DataTable dt;
        private SqlCommandBuilder scb;
        public ManageCustomer()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            comboBoxSearchBy.SelectedIndex = 0;
            lblCustomerId.Text = "";
            lblCustomerName.Text = "";
            lblCustomerContact.Text = "";
            lblCustomerAddress.Text = "";
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.Text == @"ID")
            {
                sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer where id like '%" + txtSearchText.Text + "%'", connection.constring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewCustomers.DataSource = dt;
            }
            else if (comboBoxSearchBy.Text == @"Name")
            {
                sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer where name like '%" + txtSearchText.Text + "%'", connection.constring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewCustomers.DataSource = dt;
            }
            else if (comboBoxSearchBy.Text == @"Contact Number")
            {
                sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer where contact_number like '%" + txtSearchText.Text + "%'", connection.constring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewCustomers.DataSource = dt;
            }
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer", connection.constring);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewCustomers.DataSource = dt;
        }

        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCustomers.CurrentRow != null)
                {
                    lblCustomerId.Text = dataGridViewCustomers.CurrentRow.Cells[0].Value.ToString();
                    lblCustomerName.Text = dataGridViewCustomers.CurrentRow.Cells[1].Value.ToString();
                    lblCustomerAddress.Text = dataGridViewCustomers.CurrentRow.Cells[2].Value.ToString();
                    lblCustomerContact.Text = dataGridViewCustomers.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error Loading Data", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT id as ID, name as Customer_Name, address as Address, contact_number as Contact_Number FROM Customer", connection.constring);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewCustomers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (dataGridViewCustomers.CurrentRow == null)
            {
                MessageBox.Show(@"Select row to delete.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "DELETE FROM Customer WHERE id='" +
                               dataGridViewCustomers.CurrentRow.Cells[0].Value +
                               "'";
                using (SqlCommand cmda = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmda.ExecuteNonQuery();
                }
                conn.Close();
            }

            btnLoad_Click(sender, e);
            MessageBox.Show(@"Customer Deleted.", @"Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show(@"Data Updated", @"Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
