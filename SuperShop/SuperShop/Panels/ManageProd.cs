using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop
{
    public partial class ManageProd : UserControl
    {
        DBConnection connection = new DBConnection();
        public ManageProd()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            LoadProductTable(dataGridView1);
        }

       
        public void LoadProductTable(DataGridView dv)
        {
            dv.DataSource = connection.LoadDbTable("select * from Products");
        }

        public void LoadSearchTable(DataGridView dv, string sql)
        {
            dv.DataSource = connection.LoadDbTable(sql);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                string sql = string.Empty;
                if (categoryBox.SelectedIndex == 1)
                {
                    sql = "select * from Products where id = " + Convert.ToInt32(searchBox.Text);
                   
                }
                else if (categoryBox.SelectedIndex == 0)
                {
                    sql = "select * from Products where name LIKE '%" + searchBox.Text + "%'";
                    
                }

                LoadSearchTable(dataGridView1, sql);
            }
            else
            {
                LoadProductTable(dataGridView1);
            }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (columnIndex == 1 && dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString()!="")
            {
                string value = "'"+dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString()+"'";
                string columnName = dataGridView1.Columns[columnIndex].Name;

                
                string sql = "delete from Products where " + columnName + " = " + value;

                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (connection.DeleteQuery(sql))
                    {
                        MessageBox.Show("Product Deleted ", "Sucesss", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        LoadProductTable(dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Couldn't Delete Product ", "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                   
                }
            }
            else if (columnIndex == 0 && dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString() != "")
            {
                string value =  dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString() ;
                string columnName = dataGridView1.Columns[columnIndex].Name;

             


                string sql = "delete from Products where " + columnName + " = " + value;

                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (connection.DeleteQuery(sql))
                    {
                        MessageBox.Show("Product Deleted ", "Sucesss", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        LoadProductTable(dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Couldn't Delete Product ", "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            string value =  dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString() ;
            string columnName = dataGridView1.Columns[columnIndex].Name;
            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());


            if (columnIndex == 1 )
            {
                

                string sql = "update Products SET name = '" +  value + "'where  id = " + id;

                if (connection.UpdateQuery(sql))
                {
                    MessageBox.Show("Product Information Updated !", "Updated", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed !");
                }
            }
            else if (columnIndex == 2)
            {


                string sql = "update Products SET quantity = " + Convert.ToInt32(value) + "where  id = " + id;

                if (connection.UpdateQuery(sql))
                {
                    MessageBox.Show("Product Information Updated !", "Updated", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed !");
                }
            }
            else  if (columnIndex == 3)
            {


                string sql = "update Products SET unit = '" + value + "' where  id = " + id;

                if (connection.UpdateQuery(sql))
                {
                    MessageBox.Show("Product Information Updated !", "Updated", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed !");
                }
            }
            else if (columnIndex == 4)
            {


                string sql = "update Products SET Price_Per_Unit = '" +  Convert.ToInt32(value) + "'where  id = " + id;

                if (connection.UpdateQuery(sql))
                {
                    MessageBox.Show("Product Information Updated !", "Updated", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed !");
                }
            }
           
           
           

            LoadProductTable(dataGridView1);

           
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            LoadProductTable(dataGridView1);
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (categoryBox.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

               
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        

       
    }
}
