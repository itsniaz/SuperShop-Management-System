using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop.Panels
{
    public partial class ManageEmployee : UserControl
    {
        private DBConnection connection = new DBConnection();
        private SqlDataAdapter sda;
        private SqlDataReader reader;
        public SqlCommandBuilder scb;
        private DataTable dt;
        public DataGridViewRow DgvRow;
        private int employeeCount = 0;
        public ManageEmployee()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            comboBoxSearchBy.SelectedIndex = 0;

            lblEmployeeUserName.Text = "";
            lblEmployeeContactNumber.Text = "";
            lblEmployeeName.Text = "";
            lblEmployeeAddress.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection.constring))
            {
                string query = "SELECT USERNAME FROM [User] WHERE USERNAME = '" +
                               txtUsername.Text.Trim().ToLower() + "'";
                con.Open();
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        employeeCount++;
                    }
                }
            }

            if (employeeCount == 0)
            {
                //Adding new Employee

                if (txtUsername.Text == "" || txtPassword.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtContactNo.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show(@"Please fill all values", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "Insert into [User] values ('"+txtUsername.Text+"', '"+txtPassword.Text+"', '"+txtName.Text+"', '"+txtEmail.Text+"', '"+txtAddress.Text+"', '"+txtContactNo.Text+"', '"+
                        joinDate.Value.ToString(CultureInfo.InvariantCulture)+"', 'Employee')";

                    if (connection.InsertQuery(sql))
                    {
                        MessageBox.Show(@"New employee added.", @"Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Opps ! Employee couldn't be added !", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }                  
                }
            }
            else
            {
                MessageBox.Show(@"You already have an employee with that username.", @"Employee Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            employeeCount = 0;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.Text == @"Username")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where username like '%" + txtSearchText.Text + "%' and account_type = 'Employee'", connection.constring);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewEmployees.DataSource = dt;
            }
            else if (comboBoxSearchBy.Text == @"Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where name like '%" + txtSearchText.Text + "%' and account_type = 'Employee'", connection.constring);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewEmployees.DataSource = dt;
            }
            else if (comboBoxSearchBy.Text == @"Contact Number")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where contact_no like '%" + txtSearchText.Text + "%' and account_type = 'Employee'", connection.constring);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewEmployees.DataSource = dt;
            }
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where account_type = 'Employee'", connection.constring);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewEmployees.DataSource = dt;
        }

        private void dataGridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DgvRow = new DataGridViewRow();
                if (dataGridViewEmployees.CurrentRow != null)
                {
                    lblEmployeeUserName.Text = dataGridViewEmployees.CurrentRow.Cells[0].Value.ToString();
                    lblEmployeeName.Text = dataGridViewEmployees.CurrentRow.Cells[1].Value.ToString();
                    lblEmployeeAddress.Text = dataGridViewEmployees.CurrentRow.Cells[3].Value.ToString();
                    lblEmployeeContactNumber.Text = dataGridViewEmployees.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error Loading Data", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show(@"Data Updated", @"Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT username as UserName, name as Employee_Name, email as Email,  address as Address, contact_no as Contact_Number, join_date as Joining_Date FROM [User] where account_type = 'Employee'", connection.constring);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewEmployees.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            if (dataGridViewEmployees.CurrentRow == null)
            {
                MessageBox.Show(@"Select row to delete.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "DELETE FROM [User] WHERE username='" +
                               dataGridViewEmployees.CurrentRow.Cells[0].Value + "' and account_type = 'Employee'";
                using (SqlCommand cmda = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmda.ExecuteNonQuery();
                }
                conn.Close();
            }
            btnRefresh_Click(sender, e);
            MessageBox.Show(@"Employee deleted.", @"Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
