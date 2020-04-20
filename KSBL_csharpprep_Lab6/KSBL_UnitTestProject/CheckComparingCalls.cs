using System.Threading;
using KSBL_Class_Library.Components.Battery.ChargerFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KSBL_Class_Library.Mobile;
using KSBL_Class_Library.Components.CallModule;
using System.Collections.Generic;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class CheckComparingCalls
    {
        [TestMethod]
        public void CompareCalls()
        {
            //Arrange
            var contact = new Contact("testname", new List<string> { "111" });
            var contact2 = new Contact("testname2", new List<string> { "222", "333" });

            var call1 = new Call(contact, CallType.Incoming);
            var call2 = new Call(contact, CallType.Incoming);
            var call3 = new Call(contact, CallType.Outgoing);
            var call4 = new Call(contact2, CallType.Incoming);


            //Act
            //Assert
            Assert.IsTrue(call1.Equals(call2));
            Assert.IsFalse(call1.Equals(call3));
            Assert.IsFalse(call1.Equals(call4));

            Assert.IsFalse(call2.Equals(call3));
            Assert.IsFalse(call2.Equals(call4));

            Assert.IsFalse(call3.Equals(call4));
        }
    }
}