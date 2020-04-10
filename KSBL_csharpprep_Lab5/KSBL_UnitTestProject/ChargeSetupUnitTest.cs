using KSBL_Class_Library;
using KSBL_Class_Library.Components.Battery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class ChargeSetupUnitTest
    {
        [TestMethod]
        public void AppleChargerIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            var charger = new AppleCharger(110, output);
            var expect = "Test Output is running";

            //Act
            var actual = charger.Charge(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void XiaomiChargerIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            var charger = new XiaomiCharger(110, output);
            var expect = "Test Output is running";

            //Act
            var actual = charger.Charge(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AppleChargerWithoutOutput()
        {
            //Arrange
            var charger = new AppleCharger(110, null);
            var expect = "No Output!";

            //Act
            var actual = charger.Charge(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void XiaomiChargerWithoutOutput()
        {
            //Arrange
            var charger = new XiaomiCharger(110, null);
            var expect = "No Output!";

            //Act
            var actual = charger.Charge(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}