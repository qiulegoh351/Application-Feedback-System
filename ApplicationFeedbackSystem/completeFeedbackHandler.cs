using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ApplicationFeedbackSystem
{
    public class completeFeedbackHandler
    {
        private String logFHdfile = "Successful Sent Feedback_log.txt";
        private StreamWriter writer;

        private static completeFeedbackHandler fH_instance;
        private static int counter = 0;

        public static completeFeedbackHandler FH_instance
        {
            get
            {
                if (fH_instance == null)
                    fH_instance = new completeFeedbackHandler();
                return fH_instance;
            }
        }
        private completeFeedbackHandler()
        {
            try
            {
                writer = new StreamWriter(logFHdfile, true);
            }
            catch (IOException e) { }
        }
        public int addNewCompleteFeedback(MySqlConnection conn, completeFeedback cf)
        {
            
            string sql = "INSERT INTO complete_feedback (file_name,email,status)" + " VALUES ('" + cf.File_name + "', '" + cf.Email + "', '" + cf.Status + "')";
            
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
            
        }

        public int deleteCompleteRow(MySqlConnection conn, completeFeedback cf)
        {
            string sql = "DELETE FROM complete_feedback where file_name = " + cf.File_name + ";";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            sqlComm.Parameters.AddWithValue("@code", cf.File_name);

            counter++;
            writer.WriteLine(counter + ") Succcessful Sent Feedback!" + '\n' + " Code: " + cf.File_name + '\n');

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
                complete.Status = (string)myReader.GetValue(2);
                listComplete.Add(complete);
            }
            return listComplete;
        }
        public void Close()
        {
            writer.Close();
        }

        public void Open()
        {
            writer = new StreamWriter(logFHdfile, true);
            writer.WriteLine();
        }
    }
}
