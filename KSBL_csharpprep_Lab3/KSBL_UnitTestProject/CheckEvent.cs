﻿using KSBL_Class_Library.Mobile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class CheckEvent
    {
        public string Text { get; set; }

        [TestMethod]
        public void EventIsRaised()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = "Test message!";
            var expected = "Test message! #1 - Event Raised";
            string actual;

            //Act
            mobile.SmsProvider.SmsReceived += SmsProvider_SmsReceived;
            mobile.SmsProvider.PrintMessage(message);
            actual = Text;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private void SmsProvider_SmsReceived(string message)
        {
            Text = ReturnMessage(message + " - Event Raised");
        }

        private static string ReturnMessage(string message)
        {
            return message;
        }
    }
}