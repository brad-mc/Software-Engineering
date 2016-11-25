using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NapierBank;
namespace NapierBankTest
{
    [TestClass]
    public class SMSTest
    {
        [TestMethod]
        public void TestAbreviation()
        {
            string message = "447489773226 Be there ASAP";
            string header = "S123768594";
            string actual;
            string expected = "Be there ASAP <As soon as possible> ";
            CSV.readCSV();
            
            SMS s = new SMS(message, header);

            actual = s.MessageText;


            Assert.AreEqual<string>(expected, actual, "Failed to expand text abreviation");
        }
    }
}
