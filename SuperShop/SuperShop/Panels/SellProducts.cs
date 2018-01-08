using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop.Panels
{
    public partial class SellProducts : UserControl
    {
        private readonly string userName;
        private readonly string fullName;
        private int amountHaveToPay;
        private double totalAmount;
        private int cellCount = -1;
        private int invoiceNumberCount;
        private int invoiceHigh;
        private int invoiceLow;
        private DBConnection connection = new DBConnection();

        public SellProducts(string userName)
        {
            this.userName = userName;
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "SELECT * FROM [User] where username = '" + userName + "'";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fullName = reader["name"].ToString();
                        }
                    }
                }
                conn.Close();
            }

            InitializeComponent();
            Dock = DockStyle.Fill;
            comboBoxCustomerList.DropDownHeight = comboBoxCustomerList.ItemHeight * 5;
            comboBoxProductList.DropDownHeight = comboBoxProductList.ItemHeight * 5;
        }

        private void SellProducts_Load(object sender, EventArgs e)
        {
            customerTableAdapter.Fill(customerDataSet.Customer);
            productsTableAdapter.Fill(productDataSet.Products);

            foreach (DataGridViewColumn dc in dataGridViewReceipt.Columns)
            {
                dc.ReadOnly = !dc.Index.Equals(1);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAddItem_Click(sender, e);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (invoiceNumberCount >= 25)
            {
                MessageBox.Show(@"You're not allowed to add more than 25 product in cart", @"Limit Exceed Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show(@"Enter quantity value", @"Quantity Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            invoiceNumberCount++;
            string quantity = "";
            string perUnitPrice = "";
            for (int i = 0; i <= cellCount; i++)
            {
                if (dataGridViewReceipt.Rows[i].Cells[0].Value.ToString() == comboBoxProductList.Text)
                {
                    MessageBox.Show(@"Product already added to list.", @"Product Exist", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                for (int i = 0; i <= cellCount; i++)
                {
                    if (dataGridViewReceipt.Rows[i].Cells[0].Value.ToString() == comboBoxProductList.Text)
                    {
                        MessageBox.Show(@"Product already added to list.", @"Product Exist", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                string query = "select quantity from [dbo].[products] where [name] = '" + comboBoxProductList.Text + "'";
                using (SqlCommand cmda = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            quantity = reader["quantity"].ToString();
                        }
                    }
                }
                conn.Close();
            }
            
            //Checking if there are enough unit available in inventory
            if (Convert.ToInt32(quantity) < Convert.ToInt32(txtQuantity.Text))
            {
                MessageBox.Show(
                    @"You do not have enough items for this product. Please check inventory for available items.",
                    @"Insufficient Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "select * from products where name = '" + comboBoxProductList.Text + "'";


                using (SqlCommand cmda = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            perUnitPrice = reader["per_unit_price"].ToString();
                        }
                    }
                }
            }


            dataGridViewReceipt.Rows.Add(comboBoxProductList.Text, txtQuantity.Text, perUnitPrice, Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(perUnitPrice));

            totalAmount += Convert.ToDouble(dataGridViewReceipt.Rows[++cellCount].Cells[3].Value);
            lblGrandTotal.Text = Convert.ToString(Math.Round(totalAmount), CultureInfo.InvariantCulture);
            txtQuantity.Text = "";
        }

        private void txtCashReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                PrintMenu();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtCustomerAddress.Text == "" || txtCustomerContact.Text == "")
            {
                MessageBox.Show(@"Please fill all values for creating a new customer", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                try
                {
                    string sql = "insert into Customer(name, address, contact_number) values('" + txtCustomerName.Text +
                                 "', '" + txtCustomerAddress.Text + "' ,'" + txtCustomerContact.Text + "')";
                    if (connection.InsertQuery(sql))
                    {
                        MessageBox.Show("New customer added !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCustomerName.Text = "";
                        txtCustomerAddress.Text = "";
                        txtCustomerContact.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Opps ! Customer couldn't be added !", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnResetCustomerForm_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerContact.Text = "";
        }

        private void btnRefreshCustomerList_Click(object sender, EventArgs e)
        {
            customerTableAdapter.Fill(customerDataSet.Customer);
        }

        private void btnRefreshProductList_Click(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(productDataSet.Products);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            invoiceNumberCount--;
            int rowIndex = dataGridViewReceipt.CurrentCell.RowIndex;
            totalAmount -= Convert.ToDouble(dataGridViewReceipt.Rows[rowIndex].Cells[3].Value);
            dataGridViewReceipt.Rows.RemoveAt(rowIndex);
            cellCount--;
            lblGrandTotal.Text = Convert.ToString(Math.Round(totalAmount), CultureInfo.InvariantCulture);
        }

        private void btnPrintAndSave_Click(object sender, EventArgs e)
        {
            PrintMenu();
        }

        private void PrintMenu()
        {
            if (cellCount == -1)
            {
                MessageBox.Show(@"Please add a product first", @"Empty product list Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (txtCashReceived.Text == "")
            {
                MessageBox.Show(@"Enter cash received amount", @"Cash received Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //Insert entry into Database && remove product from inventory
            for (int i = 0; i <= cellCount; i++)
            {
                try
                {
                    string sql = "insert into [Items](product_name, quantity, per_unit_price, total_price) values('" + dataGridViewReceipt.Rows[i].Cells[0].Value + "', '" + dataGridViewReceipt.Rows[i].Cells[1].Value + "', '" + Convert.ToDouble(dataGridViewReceipt.Rows[i].Cells[2].Value.ToString()) + "', '" +Convert.ToString(Convert.ToDouble(dataGridViewReceipt.Rows[i].Cells[1].Value.ToString()) * Convert.ToDouble(dataGridViewReceipt.Rows[i].Cells[2].Value.ToString()), CultureInfo.InvariantCulture)+ "')";
                    connection.InsertQuery(sql);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                try
                {
                    string sql = "insert into [sales_report](customer_name, employee_name, buy_date) values('" + comboBoxCustomerList.Text + "', '" + fullName + "', '" + DateTime.Now.ToString(CultureInfo.InvariantCulture) + "')";
                    connection.InsertQuery(sql);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
               
                string quantity = "";

                using (SqlConnection conn = new SqlConnection(connection.constring))
                {
                    string query = "select quantity from products where name = '" +
                                   dataGridViewReceipt.Rows[i].Cells[0].Value + "'";
                    using (SqlCommand cmda = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmda.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                quantity = reader["quantity"].ToString();
                            }
                        }
                    }
                }

                using (SqlDataReader reader = connection.ReadQuery("SELECT * FROM salesReportView"))
                {
                    while (reader.Read())
                    {
                        invoiceHigh = Convert.ToInt32(reader["invoice_number"]);
                    }
                } 
                
                invoiceLow = invoiceHigh - cellCount;
                using (SqlConnection conn = new SqlConnection(connection.constring))
                {
                    string query = "update products set quantity = '" + (Convert.ToInt32(quantity) - Convert.ToInt32(dataGridViewReceipt.Rows[i].Cells[1].Value.ToString())) + "' where name = '" + dataGridViewReceipt.Rows[i].Cells[0].Value + "'";


                    using (SqlCommand cmda = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmda.ExecuteNonQuery();
                    }
                    conn.Close();
                } 
            }

            //Print Task
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument =
                new PrintDocument { DefaultPageSettings = { PaperSize = new PaperSize("A4", 827, 1170) } };
            printDialog.Document = printDocument; //add the document to the dialog box... 
            printDocument.PrintPage += CreateReceipt;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }


            //Clearing Sell menu Datagridview
            invoiceNumberCount = 0;
            totalAmount = 0;
            cellCount = -1;
            amountHaveToPay = 0;
            txtCashReceived.Text = @"0";
            lblGrandTotal.Text = @"0";
            lblChangedAmount.Text = @"0";
            txtQuantity.Text = "";
            dataGridViewReceipt.Rows.Clear();
        }

        private void CreateReceipt(object sender, PrintPageEventArgs e)
        {
            string companyName = "";
            string companyAddress = "";
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "SELECT * FROM [Company_Info]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            companyName = reader["company_name"].ToString();
                            companyAddress = reader["address"].ToString();
                        }
                    }
                }
            }

            string totalGrandAmount = lblGrandTotal.Text;
            string cashReceived = txtCashReceived.Text;
            string changeAmount = lblChangedAmount.Text;

            string customerName = "";
            string customerId = "";
            string customerAddress = "";
            string customerContactNo = "";
            using (SqlConnection conn = new SqlConnection(connection.constring))
            {
                string query = "SELECT * FROM [Customer] WHERE name = '" + comboBoxCustomerList.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customerId = reader["id"].ToString();
                            customerName = reader["name"].ToString();
                            customerAddress = reader["address"].ToString();
                            customerContactNo = reader["contact_number"].ToString();
                        }
                    }
                }
            }

            string employeeName = fullName;
            string invoiceNumbers = invoiceLow + " to " + invoiceHigh;
            string buyDate = DateTime.Now.ToString("hh:mm tt dd-MMM-yyyy");

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 40;
            int startY = 40;
            int offset = 40;

            graphic.DrawString(companyName, new Font("Courier New", 22, FontStyle.Bold), new SolidBrush(Color.Blue), startX, startY);
            graphic.DrawString(companyAddress, new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("--------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 05; //make the spacing consistent
            graphic.DrawString("Customer Information:", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Blue), startX, startY + offset);
            graphic.DrawString("Invoice Information:", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Blue), startX + 413, startY + offset);
            offset = offset + (int)fontHeight + 10;
            graphic.DrawString("Name: " + customerName, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Served By: " + employeeName, font, new SolidBrush(Color.Black), startX + 413, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Customer ID: " + customerId, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Invoice Numbers: " + invoiceNumbers, font, new SolidBrush(Color.Black), startX + 413, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Customer Contact: " + customerContactNo, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Buy Date: " + buyDate, font, new SolidBrush(Color.Black), startX + 413, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Customer Address: " + customerAddress, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("--------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 05; //make the spacing consistent
            graphic.DrawString("Products Information:", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Blue), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            graphic.DrawString("Product Name", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Quantity", font, new SolidBrush(Color.Black), startX + 186 + 100, startY + offset);
            graphic.DrawString("Per Unit Price", font, new SolidBrush(Color.Black), startX + 186 + 186 + 100, startY + offset);
            graphic.DrawString("Total Price", font, new SolidBrush(Color.Black), startX + 186 + 186 + 186 + 100 - 5, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("--------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 05; //make the spacing consistent

            for (int i = 0; i <= cellCount; i++)
            {
                graphic.DrawString(dataGridViewReceipt.Rows[i].Cells[0].Value.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(dataGridViewReceipt.Rows[i].Cells[1].Value.ToString(), font, new SolidBrush(Color.Black), startX + 186 + 20 + 100, startY + offset);
                graphic.DrawString(dataGridViewReceipt.Rows[i].Cells[2].Value.ToString(), font, new SolidBrush(Color.Black), startX + 186 + 186 + 32 + 100, startY + offset);
                graphic.DrawString(dataGridViewReceipt.Rows[i].Cells[3].Value.ToString(), font, new SolidBrush(Color.Black), startX + 186 + 186 + 186 + 20 + 100, startY + offset);
                offset = offset + (int)fontHeight;
            }
            offset = offset + (int)fontHeight + 10;
            graphic.DrawString("Grand Total: ", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Red), startX + 186 + 186 + 186 - 110, startY + offset);
            graphic.DrawString(totalAmount.ToString("#.##"), new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Red), startX + 186 + 186 + 186 + 20 + 100 - 20 + 10, startY + offset);
            offset = offset + (int)fontHeight + 20;
            //Page End

            amountHaveToPay = (int)Math.Round(Convert.ToDouble(totalAmount));

            graphic.DrawString("--------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 05; //make the spacing consistent
            graphic.DrawString("Cash Information:", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Blue), startX, startY + offset);
            offset = offset + (int)fontHeight + 10;
            graphic.DrawString("Amount Have To Pay: " + amountHaveToPay, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;

            graphic.DrawString("In Words: " + NumWordsWrapper(Convert.ToDouble(totalAmount)) + " Taka Only", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Cash Received: " + cashReceived, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Change Amount: " + changeAmount, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 40;
            graphic.DrawString("--------------------------------------", font, new SolidBrush(Color.Black), startX + 413, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("              Checked By              ", font, new SolidBrush(Color.Black), startX + 413, startY + offset);
        }

        private void txtCashReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblChangedAmount.Text = (Double.Parse(txtCashReceived.Text.Trim()) - Math.Round(Double.Parse(lblGrandTotal.Text.Trim()))).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                lblChangedAmount.Text = @"0";
                MessageBox.Show(@"Please enter cash received amount", @"Cash Received Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String NumWordsWrapper(double n)
        {
            double intPart;
            double decPart = 0;
            if (n == 0.0)
                return "zero";
            try
            {
                string[] splitter = n.ToString().Split('.');
                intPart = double.Parse(splitter[0]);
                decPart = double.Parse(splitter[1]);
            }
            catch
            {
                intPart = n;
            }

            var words = NumWords(intPart);

            if (decPart > 0)
            {
                if (words != "")
                    words += " and ";
                int counter = decPart.ToString(CultureInfo.InvariantCulture).Length;
                switch (counter)
                {
                    case 1: words += NumWords(decPart) + " tenths"; break;
                    case 2: words += NumWords(decPart) + " hundredths"; break;
                    case 3: words += NumWords(decPart) + " thousandths"; break;
                    case 4: words += NumWords(decPart) + " ten-thousandths"; break;
                    case 5: words += NumWords(decPart) + " hundred-thousandths"; break;
                    case 6: words += NumWords(decPart) + " millionths"; break;
                    case 7: words += NumWords(decPart) + " ten-millionths"; break;
                }
            }
            return words;
        }

        private String NumWords(double n) //converts double to words
        {
            string[] numbersArr = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tensArr = new string[] { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
            string[] suffixesArr = new string[] { "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillion", "Septillion", "Octillion", "Nonillion", "Decillion", "Undecillion", "Duodecillion", "Tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septdecillion", "Octodecillion", "Novemdecillion", "Vigintillion" };
            string words = "";

            bool tens = false;

            if (n < 0)
            {
                words += "negative ";
                n *= -1;
            }

            int power = (suffixesArr.Length + 1) * 3;

            while (power > 3)
            {
                double pow = Math.Pow(10, power);
                if (n >= pow)
                {
                    if (n % pow > 0)
                    {
                        words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1] + ", ";
                    }
                    else if (n % pow == 0)
                    {
                        words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1];
                    }
                    n %= pow;
                }
                power -= 3;
            }
            if (n >= 1000)
            {
                if (n % 1000 > 0) words += NumWords(Math.Floor(n / 1000)) + " thousand, ";
                else words += NumWords(Math.Floor(n / 1000)) + " thousand";
                n %= 1000;
            }
            if (0 <= n && n <= 999)
            {
                if ((int)n / 100 > 0)
                {
                    words += NumWords(Math.Floor(n / 100)) + " hundred";
                    n %= 100;
                }
                if ((int)n / 10 > 1)
                {
                    if (words != "")
                        words += " ";
                    words += tensArr[(int)n / 10 - 2];
                    tens = true;
                    n %= 10;
                }

                if (n < 20 && n > 0)
                {
                    if (words != "" && tens == false)
                        words += " ";
                    words += (tens ? " " + numbersArr[(int)n - 1] : numbersArr[(int)n - 1]);
                    n -= Math.Floor(n);
                }
            }

            return words;

        }

        private void dataGridViewReceipt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Double price = Convert.ToDouble(dataGridViewReceipt.Rows[e.RowIndex].Cells[1].Value.ToString()) * Convert.ToDouble(dataGridViewReceipt.Rows[e.RowIndex].Cells[2].Value.ToString());
                dataGridViewReceipt.Rows[e.RowIndex].Cells[3].Value = price.ToString();
                totalAmount = 0;
                for (int i = 0; i <= cellCount; i++)
                {
                    totalAmount += Convert.ToDouble(dataGridViewReceipt.Rows[i].Cells[3].Value.ToString());
                }
                lblGrandTotal.Text = Convert.ToString(Math.Round(totalAmount));
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter quantity amount.", "Quantity Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCustomerName.Text == "" || txtCustomerAddress.Text == "" || txtCustomerContact.Text == "")
                {
                    MessageBox.Show("Please fill all values for creating a new customer", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnAddCustomer_Click(sender, e);
                }
            }
        }

    }
}
