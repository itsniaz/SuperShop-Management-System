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
    public partial class DatabaseBackup : UserControl
    {
        private DBConnection connection = new DBConnection();
        public DatabaseBackup()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocationBackup.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = @"Backup Files(*.bak)|*.bak|All Files(*.*)|*.*",
                FilterIndex = 0
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocationRestore.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection.constring);
                conn.Open();

                string sqlstmt = "BACKUP DATABASE SuperShopDatabase TO DISK = '" + txtLocationBackup.Text +
                                 "\\SuperShopDatabase - " + DateTime.Now.Ticks.ToString() + ".bak'";
                SqlCommand bu = new SqlCommand(sqlstmt, conn);
                bu.ExecuteNonQuery();
                MessageBox.Show(@"Successfuly database backup completed.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection.constring);
                conn.Open();

                string sqlStmt2 = "ALTER DATABASE SuperShopDatabase SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                SqlCommand bu2 = new SqlCommand(sqlStmt2, conn);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE SuperShopDatabase FROM DISK='" + txtLocationRestore.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, conn);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = "ALTER DATABASE SuperShopDatabase SET MULTI_USER";
                SqlCommand bu4 = new SqlCommand(sqlStmt4, conn);
                bu4.ExecuteNonQuery();

                MessageBox.Show(@"Successfully restored data from database");
                MessageBox.Show(@"Now the application will restart");
                conn.Close();
                //Restart Aplication
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


    }
}
