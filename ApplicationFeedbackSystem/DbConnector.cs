using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationFeedbackSystem
{
    public class DbConnector
    {
        MySqlConnection conn;

        public string connect()
        {
            string connStr = "server=localhost;user=dbcli;database=se_assignment;port=3306;password=dbcli123";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                //Perform database operations
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database Connection!");
            }
            return "Done";
        }

        public MySqlConnection getConn()
        {
            return conn;
        }
    }
}
