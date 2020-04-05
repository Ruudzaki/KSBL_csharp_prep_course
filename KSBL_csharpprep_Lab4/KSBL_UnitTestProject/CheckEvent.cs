using System;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;
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
            mobile.InternalStorage.SmsAdded += SmsProviderListener;
            mobile.InternalStorage.AddMessage(new Message("KSBL", message, DateTime.Now));
            actual = Text;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private void SmsProviderListener(Message message)
        {
            Text = ReturnMessage(message.Text + " #1 - Event Raised");
        }

        private static string ReturnMessage(string message)
        {
            return message;
        }
    }
}