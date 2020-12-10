using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using ApplicationFeedbackSystem;

namespace UnitTestApplicationFeedbackSystem
{
    [TestClass]
    public class unitTestDeleteCompleteFeedback
    {
        [TestMethod]
        public void TestDeleteTemplate()
        {
            DbConnector dbC = DbConnector.Instance;
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            completeFeedback fbA = new completeFeedback();
            fbA.File_name = 2;


            completeFeedbackHandler tempHand3 = completeFeedbackHandler.FH_instance;
            int resp7 = tempHand3.deleteCompleteRow(dbC.getConn(), fbA);
            Assert.IsNotNull(resp7);
        }
    }
}
