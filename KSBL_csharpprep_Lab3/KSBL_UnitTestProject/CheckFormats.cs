using System;
using KSBL_Class_Library.Mobile;
using KSBL_SmsWinForms_app;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class CheckFormats
    {
        [TestMethod]
        public void MessageIsPrinted()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = "Test message!";
            var expected = "Test message!";
            string actual;

            //Act
            mobile.SmsProvider.PrintMessage(message);
            actual = mobile.SmsProvider.LastText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedUpperCase()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = "Test message!";
            var expected = "TEST MESSAGE!";
            string actual;
            mobile.SmsProvider.Formatter = SmsViewer.FormatUpperCase;

            //Act
            mobile.SmsProvider.PrintMessage(message);
            actual = mobile.SmsProvider.LastText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedLowerCase()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = "Test message!";
            var expected = "test message!";
            string actual;
            mobile.SmsProvider.Formatter = SmsViewer.FormatLowerCase;

            //Act
            mobile.SmsProvider.PrintMessage(message);
            actual = mobile.SmsProvider.LastText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedEndWithDate()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = "Test message!";
            var expected = $"Test message! [{DateTime.Now}]";
            string actual;
            mobile.SmsProvider.Formatter = SmsViewer.FormatEndWithDate;

            //Act
            mobile.SmsProvider.PrintMessage(message);
            actual = mobile.SmsProvider.LastText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedStartWithDate()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = "Test message!";
            var expected = $"[{DateTime.Now}] Test message!";
            string actual;
            mobile.SmsProvider.Formatter = SmsViewer.FormatStartWithDate;

            //Act
            mobile.SmsProvider.PrintMessage(message);
            actual = mobile.SmsProvider.LastText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedUpperStartWithDate()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = "Test message!";
            var expected = $"[{DateTime.Now}] TEST MESSAGE!";
            string actual;
            mobile.SmsProvider.Formatter = SmsViewer.FormatUpperStartWithDate;

            //Act
            mobile.SmsProvider.PrintMessage(message);
            actual = mobile.SmsProvider.LastText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedNone()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = "Test message!";
            var expected = message;
            string actual;
            mobile.SmsProvider.Formatter = SmsViewer.FormatNone;

            //Act
            mobile.SmsProvider.PrintMessage(message);
            actual = mobile.SmsProvider.LastText;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}