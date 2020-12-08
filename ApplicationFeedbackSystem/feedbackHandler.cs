﻿using System;
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
        public int addNewfeedback(MySqlConnection conn, FeedBackPage fb)
        {
            string sql = "INSERT INTO feedback (Code, Interviewee, Email, Description, FeedbackType, Interviewer) "
                            + " VALUES (" + fb.Code + ", '" + fb.Interviewee + "', '" + fb.Email + "','" + fb.Describe + "','" + fb.FeedbackType + "','" + fb.Interviewer + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int deleteAFeedback(MySqlConnection conn, Template fb)
        {
            string sql = "DELETE FROM feedback where Code = " + fb.Code + ";";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            sqlComm.Parameters.AddWithValue("@Code", fb.Code);

            return sqlComm.ExecuteNonQuery();
        }
    }
}