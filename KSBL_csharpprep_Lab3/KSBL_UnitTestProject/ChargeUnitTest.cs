using KSBL_Class_Library;
using KSBL_Class_Library.Components.Speaker;
using KSBL_Class_Library.Components.Battery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class ChargeUnitTest
    {
        [TestMethod]
        public void AppleChargerIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            AppleCharger charger = new AppleCharger(110, output);
            string expect = "Test Output is running";

            //Act
            string actual = charger.Charge(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void XiaomiChargerIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            XiaomiCharger charger = new XiaomiCharger(110, output);
            string expect = "Test Output is running";

            //Act
            string actual = charger.Charge(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AppleChargerWithoutOutput()
        {
            //Arrange
            AppleCharger charger = new AppleCharger(110, null);
            string expect = "No Output!";

            //Act
            string actual = charger.Charge(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void XiaomiChargerWithoutOutput()
        {
            //Arrange
            XiaomiCharger charger = new XiaomiCharger(110, null);
            string expect = "No Output!";

            //Act
            string actual = charger.Charge(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

       

    }
}
