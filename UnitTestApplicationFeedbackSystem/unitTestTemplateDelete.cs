using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using ApplicationFeedbackSystem;

namespace UnitTestApplicationFeedbackSystem
{
    [TestClass]
    public class unitTestTemplateDelete
    {
        [TestMethod]
        public void TestDeleteTemplate()
        {
            DbConnector dbC = DbConnector.Instance;
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Template tempC = new Template();
            tempC.Code = 1;


            TemplateHandler tempHand3 = TemplateHandler.TH_instance;
            int resp7 = tempHand3.deleteATemplate(dbC.getConn(), tempC);
            Assert.IsNotNull(resp7);
        }
    }
}
