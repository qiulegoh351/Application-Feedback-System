using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationFeedbackSystem
{
    public class feedbackHandler
    {
        private String logFHdfile = "Successful Feedback Template_log.txt";
        private StreamWriter writer;

        private static feedbackHandler fH_instance;
        private static int counter = 0;

        public static feedbackHandler TH_instance
        {
            get
            {
                if (fH_instance == null)
                    fH_instance = new feedbackHandler();
                return fH_instance;
            }
        }
        private feedbackHandler()
        {
            try
            {
                writer = new StreamWriter(logFHdfile, true);
            }
            catch (IOException e) { }
        }
        public int addNewfeedback(MySqlConnection conn, FeedBackPage fb)
        {
            
            string sql = "INSERT INTO feedback (Code, Interviewee, Email, Description, FeedbackType, Interviewer) "
                            + " VALUES (" + fb.Code + ", '" + fb.Interviewee + "', '" + fb.Email + "','" + fb.Describe + "','" + fb.FeedbackType + "','" + fb.Interviewer + "')";
            counter++;
            writer.WriteLine(counter + ") Succcessful Feedback Template!" + '\n' +
                            " Code: " + fb.Code + '\n' + " Interviewee: " + fb.Interviewee + '\n' + " Email: " + fb.Email + '\n' +
                            " Comments: " + fb.Describe + '\n' + " Feedback Type: " + fb.FeedbackType + '\n' + " Interviewer: " + fb.Interviewer + '\n');

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
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