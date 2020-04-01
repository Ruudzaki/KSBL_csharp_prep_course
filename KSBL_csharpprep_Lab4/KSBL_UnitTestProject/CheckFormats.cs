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
        public void MessageIsAdded()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now);
            var expected = "Test message! #1";
            string actual;

            //Act
            mobile.InternalStorage.AddMessage(message);
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsAddedTwiceWithUniqueId()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now);
            var expected1 = 1;
            var expected2 = 2;
            int actual1;
            int actual2;

            //Act
            mobile.InternalStorage.AddMessage(message);
            mobile.InternalStorage.AddMessage(message);

            actual1 = mobile.InternalStorage.Messages[0].ReferenceNumber;
            actual2 = mobile.InternalStorage.Messages[1].ReferenceNumber;

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void MessageIsFormattedUpperCase()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now);
            var expected = "TEST MESSAGE! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatUpperCase;

            //Act
            mobile.InternalStorage.AddMessage(message);
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedLowerCase()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now);
            var expected = "test message! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatLowerCase;

            //Act
            mobile.InternalStorage.AddMessage(message);
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedEndWithDate()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now);
            var expected = $"Test message! [{DateTime.Now}] #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatEndWithDate;

            //Act
            mobile.InternalStorage.AddMessage(message);
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedStartWithDate()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now);
            var expected = $"[{DateTime.Now}] Test message! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatStartWithDate;

            //Act
            mobile.InternalStorage.AddMessage(message);
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedUpperStartWithDate()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now);
            var expected = $"[{DateTime.Now}] TEST MESSAGE! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatUpperStartWithDate;

            //Act
            mobile.InternalStorage.AddMessage(message);
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageIsFormattedNone()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", DateTime.Now);
            var expected = "Test message! #1";
            string actual;
            mobile.InternalStorage.Formatter = FormatterClass.FormatNone;

            //Act
            mobile.InternalStorage.AddMessage(message);
            actual = mobile.InternalStorage.FormatText(message).FormatText;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}