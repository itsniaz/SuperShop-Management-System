using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperShop
{
    public partial class AddProd : UserControl
    {
        private DBConnection connection = new DBConnection();
        private SqlDataAdapter _sda = new SqlDataAdapter ();
        private DataTable _dt;
        public AddProd()
        {
            InitializeComponent();
            LoadProductTable(dataGridView1);
            Dock = DockStyle.Fill;
        }

        public void LoadProductTable(DataGridView dv)
        {
            dv.DataSource = connection.LoadDbTable("select * from Products");
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void metroButton1_Click(object sender, EventArgs e)
        {
                        _sda = new SqlDataAdapter(@"insert into products values (1, '" + pNameBox.Text + "', " + qBox.Text + "," + " '" + unitBox.Text + "', " + priceBox.Text + "')", connection.constring);
            //Showing Previous Items
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", connection.constring);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView1.DataSource = _dt;

            if (pNameBox.Text == "")
            {
                MessageBox.Show(@"Please fill all values", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (qBox.Text == "" || priceBox.Text == "")
            {
                MessageBox.Show(@"Please fill all values", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SqlConnection newcon = new SqlConnection(connection.constring))
                {
                    newcon.Open();
                    SqlCommand cmd = new SqlCommand("",
                    newcon);
                    cmd.CommandText =
                    "Insert into [Products](name, quantity, unit, per_unit_price) values (@nm, @qua, @unit, @pup)";
                    cmd.Parameters.AddWithValue("@nm",
                    pNameBox.Text);
                    cmd.Parameters.AddWithValue("@qua",
                    qBox.Text);
                    cmd.Parameters.AddWithValue("@unit",
                    unitBox.Text);
                    cmd.Parameters.AddWithValue("@pup",
                    priceBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Product Added",
                    @"Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }

            }

            //Update Previous Items 
            _sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", connection.constring);
            _dt = new DataTable();
            _sda.Fill(_dt);
            dataGridView1.DataSource = _dt;
        }

        private void unitBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            qBox.Text = String.Empty;
            pNameBox.Text = String.Empty;
            priceBox.Text = String.Empty;
            unitBox.SelectedIndex = 0; 
        }  

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadProductTable(dataGridView1);
        }

        private void qBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                metroButton1_Click(sender, e);
            }
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                metroButton1_Click(sender,e);
            }
        }
    }
}
