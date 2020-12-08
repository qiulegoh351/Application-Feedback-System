using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ApplicationFeedbackSystem
{
    class user
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=se_assignment;User Id=dbcli;password=dbcli123");

        private string log_username;
        private string log_password;
        private string log_role;

        public string Log_username
        { get => log_username; set => log_username = value; }
        public string Log_password
        { get => log_password; set => log_password = value; }
        public string Log_role
        { get => log_role; set => log_role = value; }

        //public bool User_verification()
        //{
        //    con.Open();
        //    MySqlDataReader rd;
        //    bool check = false;
        //    using (var cmd = new MySqlCommand())
        //    {
        //        cmd.CommandText = "SELECT * FROM user WHERE username=@name AND password=@pass";
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = con;

        //        cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = Log_username;
        //        cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Log_password;

        //        rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            Log_role = rd.GetString("role");
        //        }
        //        con.Close();
        //    }
        //    return check;
        //}

    }
}

