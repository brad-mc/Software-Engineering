using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NapierBank;
namespace NapierBankTest
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void TestURLRemoval()
        {
            string message = "Dave@dave.com Test Email          Hey how have you been www.bbc.co.uk";
            string header = "E123768594";
            string actual;
            string expected = "Dave@dave.com Test Email          Hey how have you been <URL Quarantined>";
           Email e = new Email(message,header);

           actual = e.URLRemoval(message);


            Assert.AreEqual<string>(expected, actual, "Failed to remove URL");

        

        
        }
    }
}
