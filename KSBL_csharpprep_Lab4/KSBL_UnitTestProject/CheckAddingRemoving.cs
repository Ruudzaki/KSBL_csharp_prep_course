using System;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class CheckAddingRemoving
    {
        public string Text { get; set; }

        [TestMethod]
        public void MessageIsRemoved()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", new DateTime(1,1,1));
            int actual;
            int expected = 2;

            //Act
            mobile.InternalStorage.AddMessage(message);
            mobile.InternalStorage.AddMessage(message);
            mobile.InternalStorage.AddMessage(message);
            mobile.InternalStorage.RemoveMessage(message);
            actual = mobile.InternalStorage.Messages.Count;

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
        public void MessageCantBeRemoved()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var message = new Message("KSBL", "Test message!", new DateTime(1, 1, 1));
            int actual;
            int expected = 0;

            //Act
            mobile.InternalStorage.RemoveMessage(message);
            actual = mobile.InternalStorage.Messages.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}