using System.Threading;
using KSBL_Class_Library.Components.Battery.ChargerFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class CheckCharging
    {
        [TestMethod]
        public void ChargerLevelMaxTask()
        {
            //Arrange
            ChargerCreator chargerCreator = new ChargerTaskCreator();
            var charger = chargerCreator.Create();

            //Act
            charger.ChargeLevel = 105;
            var actual = charger.ChargeLevel;
            charger.Stop();

            //Assert
            Assert.IsTrue(actual <= 100);
        }

        [TestMethod]
        public void ChargerLevelMaxThread()
        {
            //Arrange
            ChargerCreator chargerCreator = new ChargerThreadCreator();
            var charger = chargerCreator.Create();

            //Act
            charger.ChargeLevel = 105;
            var actual = charger.ChargeLevel;
            charger.Stop();

            //Assert
            Assert.IsTrue(actual <= 100);
        }

        [TestMethod]
        public void ChargerLevelMinTask()
        {
            //Arrange
            ChargerCreator chargerCreator = new ChargerTaskCreator();
            var charger = chargerCreator.Create();

            //Act
            charger.ChargeLevel = -5;
            var actual = charger.ChargeLevel;
            charger.Stop();

            //Assert
            Assert.IsTrue(actual <= 100);
        }

        [TestMethod]
        public void ChargerLevelMinThread()
        {
            //Arrange
            ChargerCreator chargerCreator = new ChargerThreadCreator();
            var charger = chargerCreator.Create();

            //Act
            charger.ChargeLevel = -5;
            var actual = charger.ChargeLevel;
            charger.Stop();

            //Assert
            Assert.IsTrue(actual >= 0);
        }

        [TestMethod]
        public void ChargerIsOnTask()
        {
            //Arrange
            ChargerCreator chargerCreator = new ChargerTaskCreator();
            var charger = chargerCreator.Create();
            charger.ChargeLevel = 50;

            //Act
            charger.Charge();
            var actual1 = charger.ChargeLevel;
            Thread.Sleep(2000);
            var actual2 = charger.ChargeLevel;
            charger.Stop();

            //Assert
            Assert.IsTrue(actual1 < actual2);
        }

        [TestMethod]
        public void ChargerIsOnThread()
        {
            //Arrange
            ChargerCreator chargerCreator = new ChargerThreadCreator();
            var charger = chargerCreator.Create();
            charger.ChargeLevel = 50;

            //Act
            charger.Charge();
            var actual1 = charger.ChargeLevel;
            Thread.Sleep(2000);
            var actual2 = charger.ChargeLevel;
            charger.Stop();

            //Assert
            Assert.IsTrue(actual1 < actual2);
        }

        [TestMethod]
        public void ChargerIsOffTask()
        {
            //Arrange
            ChargerCreator chargerCreator = new ChargerTaskCreator();
            var charger = chargerCreator.Create();
            charger.ChargeLevel = 50;

            //Act
            charger.Discharge();
            var actual1 = charger.ChargeLevel;
            Thread.Sleep(2000);
            var actual2 = charger.ChargeLevel;
            charger.Stop();

            //Assert
            Assert.IsTrue(actual1 > actual2);
        }

        [TestMethod]
        public void ChargerIsOffThread()
        {
            //Arrange
            ChargerCreator chargerCreator = new ChargerThreadCreator();
            var charger = chargerCreator.Create();
            charger.ChargeLevel = 50;

            //Act
            charger.Discharge();
            var actual1 = charger.ChargeLevel;
            Thread.Sleep(2000);
            var actual2 = charger.ChargeLevel;
            charger.Stop();

            //Assert
            Assert.IsTrue(actual1 > actual2);
        }
    }
}