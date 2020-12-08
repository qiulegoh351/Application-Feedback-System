using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using ApplicationFeedbackSystem;

namespace UnitTestApplicationFeedbackSystem
{
    [TestClass]
    public class unitTestEditTemplate
    {
        [TestMethod]
        public void TestEditTemplate()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Template tempB = new Template();
            tempB.Code = 3;
            tempB.Interviewee = "Qiu Le";
            tempB.Gender = "Female";
            tempB.Age = 23;
            tempB.DateOfBirth = new DateTime(1997, 5, 25, 0, 0, 0);
            tempB.Email = "mariong9919@gmail.com";
            tempB.ContactNum = "0123456789";
            tempB.City = "KL";
            tempB.State = "Cheras";
            tempB.Address = "Taman Midah";
            tempB.Type = "Technical Interview";
            tempB.Position = "Web Design";
            tempB.Interviewer = "Siong Foong";


            TemplateHandler tempHand2 = new TemplateHandler();
            int resp5 = tempHand2.editTemplate(dbC.getConn(), tempB);
            Assert.IsNotNull(resp5);
        }
    }
}
