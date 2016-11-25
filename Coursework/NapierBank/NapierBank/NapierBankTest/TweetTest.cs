using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NapierBank;
namespace NapierBankTest
{
    [TestClass]
    public class TweetTest
    {
        [TestMethod]
        public void TestSenderCapture()
        {
            string message = "@Dave2 Hey how have you been www.bbc.co.uk";
            string header = "T123768594";
            string actual;
            string expected = "@Dave2";
            Tweet t = new Tweet(message, header);

            actual = t.Sender;


            Assert.AreEqual<string>(expected, actual, "Failed to capture sender");
        }
    }
}
