using System;
using System.Collections.Generic;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class CheckFiltering
    {
        [TestMethod]
        public void MessageIsFilteredAll()
        {
            //Arrange
            var message1 = new Message("KSBL", "Tet message!", new DateTime(2020, 1, 1));
            var message2 = new Message("VZL", "Test message!", new DateTime(2020, 1, 2));
            var message3 = new Message("OKTK", "Test message!", new DateTime(2020, 1, 3));
            var message4 = new Message("KSBL", "Test message!", new DateTime(2020, 1, 4));
            var message5 = new Message("KSBL", "Tet message!", new DateTime(2020, 1, 4));
            var message6 = new Message("KSBL", "Test message!", new DateTime(2020, 1, 5));
            var mobile = new SimCorpMobile();
            IEnumerable<Message> filteredMessages;
            var actual = new List<Message>();
            var expected = new List<Message> {message4};

            //Act
            mobile.InternalStorage.AddMessage(message1);
            mobile.InternalStorage.AddMessage(message2);
            mobile.InternalStorage.AddMessage(message3);
            mobile.InternalStorage.AddMessage(message4);
            mobile.InternalStorage.AddMessage(message5);
            mobile.InternalStorage.AddMessage(message6);
            filteredMessages = mobile.InternalStorage.FilterAll(mobile.InternalStorage.Messages, "KSBL", "Test",
                new DateTime(2020, 1, 2), new DateTime(2020, 1, 4));

            foreach (var message in filteredMessages) actual.Add(message);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);

            for (var i = 0; i < actual.Count - 1; i++)
            {
                Assert.AreEqual(expected[i].Text, actual[i].Text);
                Assert.AreEqual(expected[i].User, actual[i].User);
                Assert.AreEqual(expected[i].ReceivingTime, actual[i].ReceivingTime);
            }
        }

        [TestMethod]
        public void MessageIsFilteredByUnion()
        {
            //Arrange
            var message1 = new Message("VZL", "Tet message!", new DateTime(2020, 1, 1));
            var message2 = new Message("VZL", "Test message!", new DateTime(2020, 1, 2));
            var message3 = new Message("OKTK", "Test message!", new DateTime(2020, 1, 3));
            var message4 = new Message("KSBL", "Test message!", new DateTime(2020, 1, 4));
            var message5 = new Message("KSBL", "Tet message!", new DateTime(2020, 1, 4));
            var message6 = new Message("KSBL", "Test message!", new DateTime(2020, 1, 5));
            var mobile = new SimCorpMobile();
            IEnumerable<Message> filteredMessages;
            var actual = new List<Message>();
            var expected = new List<Message> {message2, message3, message4, message5, message6};

            //Act
            mobile.InternalStorage.AddMessage(message1);
            mobile.InternalStorage.AddMessage(message2);
            mobile.InternalStorage.AddMessage(message3);
            mobile.InternalStorage.AddMessage(message4);
            mobile.InternalStorage.AddMessage(message5);
            mobile.InternalStorage.AddMessage(message6);
            filteredMessages = mobile.InternalStorage.FilterByUnion(mobile.InternalStorage.Messages, "KSBL", "Test",
                new DateTime(2020, 1, 2), new DateTime(2020, 1, 4));

            foreach (var message in filteredMessages) actual.Add(message);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);

            for (var i = 0; i < actual.Count - 1; i++)
            {
                Assert.AreEqual(expected[i].Text, actual[i].Text);
                Assert.AreEqual(expected[i].User, actual[i].User);
                Assert.AreEqual(expected[i].ReceivingTime, actual[i].ReceivingTime);
            }
        }

        [TestMethod]
        public void MessageIsFilteredByUser()
        {
            //Arrange
            var message1 = new Message("KSBL", "Tet message!", new DateTime(2020, 1, 1));
            var message2 = new Message("VZL", "Test message!", new DateTime(2020, 1, 2));
            var message3 = new Message("OKTK", "Test message!", new DateTime(2020, 1, 3));
            var message4 = new Message("KSBL", "Test message!", new DateTime(2020, 1, 4));
            var mobile = new SimCorpMobile();
            IEnumerable<Message> filteredMessages;
            var actual = new List<Message>();
            var expected = new List<Message> {message1, message4};

            //Act
            mobile.InternalStorage.AddMessage(message1);
            mobile.InternalStorage.AddMessage(message2);
            mobile.InternalStorage.AddMessage(message3);
            mobile.InternalStorage.AddMessage(message4);
            filteredMessages = mobile.InternalStorage.FilterByUser(mobile.InternalStorage.Messages, "KSBL");

            foreach (var message in filteredMessages) actual.Add(message);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);

            for (var i = 0; i < actual.Count - 1; i++)
            {
                Assert.AreEqual(expected[i].Text, actual[i].Text);
                Assert.AreEqual(expected[i].User, actual[i].User);
                Assert.AreEqual(expected[i].ReceivingTime, actual[i].ReceivingTime);
            }
        }

        [TestMethod]
        public void MessageIsFilteredBySearchText()
        {
            //Arrange
            var message1 = new Message("KSBL", "Tet message!", new DateTime(2020, 1, 1));
            var message2 = new Message("VZL", "Test message!", new DateTime(2020, 1, 2));
            var message3 = new Message("OKTK", "Test message!", new DateTime(2020, 1, 3));
            var message4 = new Message("KSBL", "Test message!", new DateTime(2020, 1, 4));
            var mobile = new SimCorpMobile();
            IEnumerable<Message> filteredMessages;
            var actual = new List<Message>();
            var expected = new List<Message> {message2, message3, message4};

            //Act
            mobile.InternalStorage.AddMessage(message1);
            mobile.InternalStorage.AddMessage(message2);
            mobile.InternalStorage.AddMessage(message3);
            mobile.InternalStorage.AddMessage(message4);
            filteredMessages = mobile.InternalStorage.FilterBySearchText(mobile.InternalStorage.Messages, "Test");

            foreach (var message in filteredMessages) actual.Add(message);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);

            for (var i = 0; i < actual.Count - 1; i++)
            {
                Assert.AreEqual(expected[i].Text, actual[i].Text);
                Assert.AreEqual(expected[i].User, actual[i].User);
                Assert.AreEqual(expected[i].ReceivingTime, actual[i].ReceivingTime);
            }
        }


        [TestMethod]
        public void MessageIsFilteredByStartDate()
        {
            //Arrange
            var message1 = new Message("KSBL", "Tet message!", new DateTime(2020, 1, 1));
            var message2 = new Message("VZL", "Test message!", new DateTime(2020, 1, 2));
            var message3 = new Message("OKTK", "Test message!", new DateTime(2020, 1, 3));
            var message4 = new Message("KSBL", "Test message!", new DateTime(2020, 1, 4));
            var mobile = new SimCorpMobile();
            IEnumerable<Message> filteredMessages;
            var actual = new List<Message>();
            var expected = new List<Message> {message3, message4};

            //Act
            mobile.InternalStorage.AddMessage(message1);
            mobile.InternalStorage.AddMessage(message2);
            mobile.InternalStorage.AddMessage(message3);
            mobile.InternalStorage.AddMessage(message4);
            filteredMessages =
                mobile.InternalStorage.FilterByStartDate(mobile.InternalStorage.Messages, new DateTime(2020, 1, 3));

            foreach (var message in filteredMessages) actual.Add(message);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);

            for (var i = 0; i < actual.Count - 1; i++)
            {
                Assert.AreEqual(expected[i].Text, actual[i].Text);
                Assert.AreEqual(expected[i].User, actual[i].User);
                Assert.AreEqual(expected[i].ReceivingTime, actual[i].ReceivingTime);
            }
        }

        [TestMethod]
        public void MessageIsFilteredByEndDate()
        {
            //Arrange
            var message1 = new Message("KSBL", "Tet message!", new DateTime(2020, 1, 1));
            var message2 = new Message("VZL", "Test message!", new DateTime(2020, 1, 2));
            var message3 = new Message("OKTK", "Test message!", new DateTime(2020, 1, 3));
            var message4 = new Message("KSBL", "Test message!", new DateTime(2020, 1, 4));
            var mobile = new SimCorpMobile();
            IEnumerable<Message> filteredMessages;
            var actual = new List<Message>();
            var expected = new List<Message> {message1, message2, message3};

            //Act
            mobile.InternalStorage.AddMessage(message1);
            mobile.InternalStorage.AddMessage(message2);
            mobile.InternalStorage.AddMessage(message3);
            mobile.InternalStorage.AddMessage(message4);
            filteredMessages =
                mobile.InternalStorage.FilterByEndDate(mobile.InternalStorage.Messages, new DateTime(2020, 1, 3));

            foreach (var message in filteredMessages) actual.Add(message);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);

            for (var i = 0; i < actual.Count - 1; i++)
            {
                Assert.AreEqual(expected[i].Text, actual[i].Text);
                Assert.AreEqual(expected[i].User, actual[i].User);
                Assert.AreEqual(expected[i].ReceivingTime, actual[i].ReceivingTime);
            }
        }
    }
}