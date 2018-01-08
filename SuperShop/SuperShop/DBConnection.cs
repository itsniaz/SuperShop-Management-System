using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace SuperShop
{
    class DBConnection
    {
        public string constring;
        private SqlConnection con;
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader reader;
        public DBConnection()
        {
            constring = @"Data Source=(LocalDB)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
            con = new SqlConnection(constring);
            cmd.Connection = con;

            try
            {
                 con.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't Connect to Database","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        public DataTable LoadDbTable(string sql)
        {

            DataTable dt = new DataTable();
            dt.Load(this.ReadQuery(sql));
            return dt;
        }
        public SqlDataReader ReadQuery(string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            try
            {
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
              
                return null;
            }

           
        }

        public bool CreateQuery(string sql)
        {
            return true;
        }

        public bool UpdateQuery(string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        

        }

        public bool InsertQuery(string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        
          
        }

        public bool DeleteQuery(string sql)
        {

            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool ExecuteQuery(SqlCommand cmnd)
        {
            cmnd.CommandType = CommandType.Text;
            try
            {
                cmnd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        ~DBConnection()
        {
          //  con.Close();
        }

       
    }
}
