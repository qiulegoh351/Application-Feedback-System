using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using ApplicationFeedbackSystem;

namespace UnitTestApplicationFeedbackSystem
{
    [TestClass]
    public class unitTestTemplate
    {
        [TestMethod]
        public void TestAddTemplate()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Template tempA = new Template();
            tempA.Code = 00002;
            tempA.Interviewee = "Anson";
            tempA.Gender = "Male";
            tempA.Age = 35;
            tempA.DateOfBirth = new DateTime(1997, 5, 25, 0, 0, 0);
            tempA.Email = "mariong9919@gmail.com";
            tempA.ContactNum = "0123456789";
            tempA.City = "KL";
            tempA.State = "Pudu";
            tempA.Address = "Pudu House";
            tempA.Type = "Technical Interview";
            tempA.Position = "Web Develop";
            tempA.Interviewer = "Siong Foong";

            TemplateHandler tempHand = new TemplateHandler();
            int resp2 = tempHand.addNewTemplate(dbC.getConn(), tempA);
            Assert.IsNotNull(resp2);
        }
    }
}
