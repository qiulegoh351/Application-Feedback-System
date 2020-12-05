using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ApplicationFeedbackSystem
{
    class comfeedHandler
    {

        private static comfeedHandler CF_instance;
        private static int counter = 0;

        public static comfeedHandler cf_instance
        {
            get
            {
                if (CF_instance == null)
                    CF_instance = new comfeedHandler();
                return CF_instance;
            }
        }

        public List<completeFeedbackList> getAllFeedback(MySqlConnection conn)
        {
            List<completeFeedbackList> listFeed = new List<completeFeedbackList>();
            string sql = "SELECT * FROM completefeedbacklist";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            // Sends the CommandText to the Connection and builds a MySqlDataReader.

            while (myReader.Read())
            {
                completeFeedbackList acomfeed = new completeFeedbackList();
                acomfeed.FileNmae = (string)myReader.GetValue(0);
                acomfeed.Email = (string)myReader.GetValue(1);
               
                listFeed.Add(acomfeed);
            }
            return listFeed;
        }
    }
}
