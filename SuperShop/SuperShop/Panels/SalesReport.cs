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
    public partial class SalesReport : UserControl
    {
        private SqlDataAdapter sda;
        private DataTable dt;
        private DBConnection connection = new DBConnection();
        public SalesReport()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            comboBoxSearchBy.SelectedIndex = 0;
            dataGridViewSalesReport.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.Text == @"Invoice Number")
            {
                sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView] where invoice_number like '%" + txtSearchText.Text + "%'", connection.constring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSalesReport.DataSource = dt;
            }
            else if (comboBoxSearchBy.Text == @"Customer Name")
            {
                sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView] where customer_name like '%" + txtSearchText.Text + "%'", connection.constring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSalesReport.DataSource = dt;
            }
            else if (comboBoxSearchBy.Text == @"Employee Name")
            {
                sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView] where employee_name like '%" + txtSearchText.Text + "%'", connection.constring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSalesReport.DataSource = dt;
            }
            else if (comboBoxSearchBy.Text == @"Product Name")
            {
                sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView] where product_name like '%" + txtSearchText.Text + "%'", connection.constring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSalesReport.DataSource = dt;
            }
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView]", connection.constring);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewSalesReport.DataSource = dt; 
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,[total_price] as Total_Price FROM [dbo].[salesReportView]", connection.constring);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewSalesReport.DataSource = dt; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Refund Product Code here
            string mainQuantity = "";
            string quantity = "";
            string productName = "";
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "select product_name, quantity from [dbo].[salesReportView] where [invoice_number] = '" +
                               dataGridViewSalesReport.CurrentRow.Cells[3].Value + "'";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            quantity = reader["quantity"].ToString();
                            productName = reader["product_name"].ToString();
                        }
                    }
                }
                conn.Close();
            }
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "select quantity from [dbo].[products] where [name] = '" + productName + "'";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mainQuantity = reader["quantity"].ToString();
                        }
                    }
                }
                conn.Close();
            }
            
            string totalQuantity = (Convert.ToInt32(mainQuantity) + Convert.ToInt32(quantity)).ToString();
            connection.InsertQuery("update products set quantity = '" + totalQuantity + "' where name = '" +
                                   productName +
                                   "'");

            // Delete Transection
            if (dataGridViewSalesReport.CurrentRow != null)
            {
                connection.InsertQuery("DELETE FROM [dbo].[sales_Report] WHERE [invoice_number] ='" +
                                       dataGridViewSalesReport.CurrentRow.Cells[3].Value + "'");
                connection.InsertQuery("DELETE FROM [dbo].[items] WHERE [invoice_number] ='" +
                                       dataGridViewSalesReport.CurrentRow.Cells[3].Value + "'");
            }

            sda = new SqlDataAdapter(@"SELECT [customer_name] as Customer_Name ,[employee_name] as Employee_Name ,[buy_date] as Buy_Date ,[invoice_number] as Invoice_Number ,[product_name] as Product_Name ,[quantity] as Quantity ,[per_unit_price] as Per_Unit_Price ,
                                        [total_price] as Total_Price FROM [dbo].[salesReportView]", connection.constring);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewSalesReport.DataSource = dt;
            MessageBox.Show(@"Transection Deleted.", @"Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
