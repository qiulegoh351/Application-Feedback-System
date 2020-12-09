using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using ApplicationFeedbackSystem;

namespace UnitTestApplicationFeedbackSystem
{
    [TestClass]
    public class unitTestTemplateEdit
    {
        [TestMethod]
        public void TestEditTemplate()
        {
            DbConnector dbC = DbConnector.Instance;
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Template tempB = new Template();
            tempB.Code = 1;
            tempB.Interviewee = "Qiu Le";
            tempB.Gender = "Female";
            tempB.Age = 35;
            tempB.DateOfBirth = new DateTime(1997, 5, 25, 0, 0, 0);
            tempB.Email = "mariong9919@gmail.com";
            tempB.ContactNum = "0123456789";
            tempB.City = "KL";
            tempB.State = "Pudu";
            tempB.Address = "Pudu House";
            tempB.Type = "Technical Interview";
            tempB.Position = "Web Develop";
            tempB.Interviewer = "Siong Foong";

            TemplateHandler tempHand2 = TemplateHandler.TH_instance;
            int resp6 = tempHand2.editTemplate(dbC.getConn(), tempB);
            Assert.IsNotNull(resp6);
        }
    }
}
