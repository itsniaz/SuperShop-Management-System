using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop.Panels
{
    public partial class ProfileAdmin : UserControl
    {
        private string username;
      
        public ProfileAdmin(string username)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.username = username;
            LoadProfile(username);
            TextBoxProtection();
        }
        public void LoadProfile(string username)
        {
            var reader = new DBConnection().ReadQuery(String.Format("select * from [user] where username = '{0}' ",username));

            while (reader.Read())
            {
                
                    usernameBox.Text = reader["username"].ToString();
                    passwordBox.Text = reader["password"].ToString();
                    nameBox.Text = reader["name"].ToString();
                    emailBox.Text = reader["email"].ToString();
                    addressBox.Text = reader["address"].ToString();
                    contactBox.Text = reader["contact_no"].ToString();
                    joindateBox.Text = reader["join_date"].ToString();
                    roleBox.Text = reader["account_type"].ToString();
            }

           
        }

        public void TextBoxProtection()
        {
            usernameBox.ReadOnly = true;
            passwordBox.ReadOnly = true;
            nameBox.ReadOnly = true;
            emailBox.ReadOnly = true;
            addressBox.ReadOnly = true;
            contactBox.ReadOnly = true;
            joindateBox.ReadOnly = true;
            roleBox.ReadOnly = true;
        }

        public void RemoveProtection()
        {
            passwordBox.ReadOnly = false;
            nameBox.ReadOnly = false;
            emailBox.ReadOnly = false;
            addressBox.ReadOnly = false;
            contactBox.ReadOnly = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RemoveProtection();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            var res = new DBConnection().UpdateQuery(
                String.Format(
                    @"update [user] set password = '{0}',name = '{1}', email = '{2}', address = '{3}' , contact_no = '{4}' where username = '{5}' ",
                    passwordBox.Text, nameBox.Text, emailBox.Text, addressBox.Text, contactBox.Text, username));
          
            if (res) 
            {
                MessageBox.Show("Profile Updated !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Update failed !", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadProfile(usernameBox.Text);
            TextBoxProtection();
        }
    }
}
