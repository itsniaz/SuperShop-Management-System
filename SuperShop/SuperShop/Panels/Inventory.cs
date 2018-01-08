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
    public partial class Inventory : UserControl
    {
        private DBConnection connection = new DBConnection();
        private SqlDataAdapter sda;
        private DataTable dt;
        public Inventory()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            comboBoxSearchBy.SelectedIndex = 0;
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.Text == @"ID")
            {
                sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS where id like '%" + txtSearchText.Text + "%'", connection.constring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewProducts.DataSource = dt;
            }
            else if (comboBoxSearchBy.Text == @"Name")
            {
                sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS where name like '%" + txtSearchText.Text + "%'", connection.constring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewProducts.DataSource = dt;
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", connection.constring);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewProducts.DataSource = dt;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT id as ID, name as Product_Name, quantity as Available_Quantity, unit as Unit, per_unit_price as Per_Unit_Price FROM PRODUCTS", connection.constring);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewProducts.DataSource = dt;
        }

    }
}
