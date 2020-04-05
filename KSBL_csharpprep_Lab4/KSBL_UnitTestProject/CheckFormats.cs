using System;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;
using KSBL_SmsWinForms_app;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class CheckFormats
    {
        [TestMethod]
        public void MessageIsZeroFormatted()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now) {ReferenceNumber = 1};
            var expected = "Test message! #1";
            string actual;

            //Act
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedUpperCase()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now) {ReferenceNumber = 1};
            var expected = "TEST MESSAGE! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatUpperCase;

            //Act
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedLowerCase()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now) {ReferenceNumber = 1};
            var expected = "test message! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatLowerCase;

            //Act
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedEndWithDate()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now) {ReferenceNumber = 1};
            var expected = $"Test message! [{DateTime.Now}] #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatEndWithDate;

            //Act
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedStartWithDate()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now) {ReferenceNumber = 1};
            var expected = $"[{DateTime.Now}] Test message! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatStartWithDate;

            //Act
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedUpperStartWithDate()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now) {ReferenceNumber = 1};
            var expected = $"[{DateTime.Now}] TEST MESSAGE! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatUpperStartWithDate;

            //Act
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedNone()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now) {ReferenceNumber = 1};
            var expected = "Test message! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatNone;

            //Act
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}