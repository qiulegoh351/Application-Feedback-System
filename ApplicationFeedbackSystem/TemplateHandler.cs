using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationFeedbackSystem
{
    class TemplateHandler
    {
        public int addNewTemplate(MySqlConnection conn, Template ad)
        {           
            string sql = "INSERT INTO template (code, interviewee, gender, age, date_of_birth, email, contact_number" +
                         " , city, state, address, type, position, interviewer) "
                            + " VALUES (" + ad.Code + ", '" + ad.Interviewee + "', '" + ad.Gender
                            + "', " + ad.Age + " ,'" + ad.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss") + "' , '" + ad.Email
                            + "', '" + ad.ContactNum + "', '" + ad.City + "', '" + ad.State + "', '" + ad.Address
                            + "', '" + ad.Type + "', '" + ad.Position + "', '" + ad.Interviewer + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            
            return sqlComm.ExecuteNonQuery();
        }
        
        public int editTemplate(MySqlConnection conn, Template ad)
        {
            string sql = "UPDATE template set code=" + ad.Code + ",Interviewee='" + ad.Interviewee + "',gender='" +
                ad.Gender + "',Age='" + ad.Age + "',date_of_birth='" + ad.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss") + "',email='" + ad.Email 
                + "',contact_number='" + ad.ContactNum + "',city='" + ad.City + "',state='" + ad.State + "',address='" + ad.Address
                + "',type='" + ad.Type + "',position='" + ad.Position + "',interviewer='" + ad.Interviewer + "' where code='"+ ad.Code + "';"; 

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int deleteATemplate(MySqlConnection conn, Template ad)
        {
            string sql = "DELETE FROM template where code = " + ad.Code + ";";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            sqlComm.Parameters.AddWithValue("@code", ad.Code);

            return sqlComm.ExecuteNonQuery();
        }
        
        public List<Template> listAllTemplate(MySqlConnection conn)
        {
            List<Template> listTemp = new List<Template>();
            string sql = "SELECT * FROM template";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            
            while (myReader.Read())
            {
                Template temp = new Template();
                temp.Code = (int)myReader.GetValue(0);
                temp.Interviewee = (string)myReader.GetValue(1);
                temp.Gender = (string)myReader.GetValue(2);
                temp.Age = (int)myReader.GetValue(3);
                temp.DateOfBirth = (DateTime)myReader.GetValue(4);
                temp.Email = (string)myReader.GetValue(5);
                temp.ContactNum = (string)myReader.GetValue(6);
                temp.City = (string)myReader.GetValue(7);
                temp.State = (string)myReader.GetValue(8);
                temp.Address = (string)myReader.GetValue(9);
                temp.Type = (string)myReader.GetValue(10);
                temp.Position = (string)myReader.GetValue(11);
                temp.Interviewer = (string)myReader.GetValue(12);
                listTemp.Add(temp);
            }
            return listTemp;
        }
    }
}
