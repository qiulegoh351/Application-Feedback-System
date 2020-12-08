using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using ApplicationFeedbackSystem;

namespace UnitTestApplicationFeedbackSystem
{
    [TestClass]
    public class unitTestFeedback
    {
        [TestMethod]
        public void TestAddNewFeedback()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            FeedBackPage fbA = new FeedBackPage();
            fbA.Code = 0002;
            fbA.Interviewee = "HappyTech";
            fbA.Email = "mariong9919@gmail.com";
            fbA.Describe = "successful";
            fbA.FeedbackType = "testing";
            fbA.Interviewer = "weng";

            feedbackHandler fbHand = new feedbackHandler();
            int resp3 = fbHand.addNewfeedback(dbC.getConn(), fbA);
            Assert.IsNotNull(resp3);
        }
    }
}