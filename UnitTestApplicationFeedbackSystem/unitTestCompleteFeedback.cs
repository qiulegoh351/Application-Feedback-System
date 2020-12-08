﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using ApplicationFeedbackSystem;

namespace UnitTestApplicationFeedbackSystem
{
    [TestClass]
    public class unitTestCompleteFeedback
    {
        [TestMethod]
        public void testAddNewCompleteFeedback()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            completeFeedback cfbA = new completeFeedback();
            cfbA.File_name = 0002;
            cfbA.Email = "cheewengng@gmail.com";

            completeFeedbackHandler cfbHand = new completeFeedbackHandler();
            int resp4 = cfbHand.addNewCompleteFeedback(dbC.getConn(), cfbA);
            Assert.IsNotNull(resp4);
        }
    }
}