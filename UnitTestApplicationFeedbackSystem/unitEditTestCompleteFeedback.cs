using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using ApplicationFeedbackSystem;

namespace UnitTestApplicationFeedbackSystem
{
    [TestClass]
    public class unitEditTestCompleteFeedback
    {
        [TestMethod]
        public void TestDeleteTemplate()
        {
            DbConnector dbC = DbConnector.Instance;
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            completeFeedback cfB = new completeFeedback();
            cfB.File_name = 1;
            cfB.Email = "mario9919@gmail.com";
            cfB.Status = "Successful";

            completeFeedbackHandler cfHand2 = completeFeedbackHandler.FH_instance;
            int resp7 = cfHand2.editCompleteFeedback(dbC.getConn(), cfB);
            Assert.IsNotNull(resp7);
        }
    }
}
