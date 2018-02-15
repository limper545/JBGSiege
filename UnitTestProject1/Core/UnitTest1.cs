using System;
using Bab_1.DB;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DBHandlerUnitTests
    {
        [TestMethod]
        public void TestDBConnection()
        {
            
           bool checkvar =  DBHandler.CreateDatabaseConnection();
            Assert.AreEqual(checkvar, true);

        }
    }
}
