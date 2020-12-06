using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ApplicationFeedbackSystem
{
    class completeFeedbackHandler
    {
        public int addNewCompleteFeedback(MySqlConnection conn, completeFeedback cf)
        {
            
            string sql = "INSERT INTO complete_feedback (file_name,email)" + " VALUES ('" + cf.File_name + "', '" + cf.Email + "')";
            
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
            
        }

        public List<completeFeedback> listCompleteFeedback(MySqlConnection conn)
        {
            List<completeFeedback> listComplete = new List<completeFeedback>();
            string sql = "SELECT * FROM complete_feedback";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();

            while (myReader.Read())
            {
                completeFeedback complete = new completeFeedback();
                complete.File_name = (int)myReader.GetValue(0);
                complete.Email = (string)myReader.GetValue(1);
                listComplete.Add(complete);
            }
            return listComplete;
        }
    }
}
