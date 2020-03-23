using System;
using KSBL_Class_Library.Mobile;
using KSBL_SmsWinForms_app;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class CheckFormats
    {
        [TestMethod]
        public void MessageIsPrinted()
        {   
            //Arrange
            SimCorpMobile mobile = new SimCorpMobile();
            string message = "Test message!";
            string expected = "Test message!";
            string actual = "";

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
            SimCorpMobile mobile = new SimCorpMobile();
            string message = "Test message!";
            string expected = "TEST MESSAGE!";
            string actual = "";
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
            SimCorpMobile mobile = new SimCorpMobile();
            string message = "Test message!";
            string expected = "test message!";
            string actual = "";
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
            SimCorpMobile mobile = new SimCorpMobile();
            string message = "Test message!";
            string expected = $"Test message! [{DateTime.Now}]";
            string actual = "";
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
            SimCorpMobile mobile = new SimCorpMobile();
            string message = "Test message!";
            string expected = $"[{DateTime.Now}] Test message!";
            string actual = "";
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
            SimCorpMobile mobile = new SimCorpMobile();
            string message = "Test message!";
            string expected = $"[{DateTime.Now}] TEST MESSAGE!";
            string actual = "";
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
            SimCorpMobile mobile = new SimCorpMobile();
            string message = "Test message!";
            string expected = message;
            string actual = "";
            mobile.SmsProvider.Formatter = SmsViewer.FormatNone;

            //Act
            mobile.SmsProvider.PrintMessage(message);
            actual = mobile.SmsProvider.LastText;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
