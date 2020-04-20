using System;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using KSBL_Class_Library.Components.CallModule;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class CheckAddingRemovingCallsAndContacts
    {
        [TestMethod]
        public void CallIsAddedAndRemoved()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var contact = new Contact("testname", new List<string> { "111", "222" });
            var call = new Call(contact, CallType.Incoming);
            int actual;
            var expected = 2;

            //Act
            mobile.InternalStorage.AddCall(call);
            mobile.InternalStorage.AddCall(call);
            mobile.InternalStorage.AddCall(call);
            mobile.InternalStorage.RemoveCall(call);

            actual = mobile.InternalStorage.Calls.Count;

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void ContactIsAdded()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var contact = new Contact("testname", new List<string> { "111" });
            var contact2 = new Contact("testname", new List<string> { "111", "222" });
            var contact3 = new Contact("testname2", new List<string> { "111", "222" });
            int actual;

            var expected = 2;

            //Act
            mobile.InternalStorage.AddContact(contact);
            mobile.InternalStorage.AddContact(contact);
            mobile.InternalStorage.AddContact(contact2);
            mobile.InternalStorage.AddContact(contact3);
            actual = mobile.InternalStorage.Contacts.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContactIsAddedAndRemoved()
        {
            //Arrange
            var mobile = new SimCorpMobile();
            var contact = new Contact("testname", new List<string> { "111" });
            var contact2 = new Contact("testname", new List<string> { "111", "222" });
            var contact3 = new Contact("testname2", new List<string> { "111", "222" });
            int actual;
            Contact actual2;

            var expected = 1;
            var expected2 = contact3;

            //Act
            mobile.InternalStorage.AddContact(contact);
            mobile.InternalStorage.AddContact(contact);
            mobile.InternalStorage.AddContact(contact2);
            mobile.InternalStorage.AddContact(contact3);
            mobile.InternalStorage.RemoveContact(contact);

            actual = mobile.InternalStorage.Contacts.Count;
            actual2 = mobile.InternalStorage.Contacts[0];


            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }
    }
}