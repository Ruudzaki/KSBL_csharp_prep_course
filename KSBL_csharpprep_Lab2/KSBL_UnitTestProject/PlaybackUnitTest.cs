using KSBL_Class_Library.Components.Speaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KSBL_UnitTestProject
{
    [TestClass]
    public class PlaybackUnitTest
    {
        [TestMethod]
        public void AppleHeadsetIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            AppleHeadset headset = new AppleHeadset(output);
            string expect = "Test sound is playing";

            //Act
            string actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SamsungHeadsetIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            SamsungHeadset headset = new SamsungHeadset(output);
            string expect = "Test sound is playing";

            //Act
            string actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void UnofficialAppleHeadsetIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            UnofficialAppleHeadset headset = new UnofficialAppleHeadset(output);
            string expect = "Test sound is playing";

            //Act
            string actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SpeakerIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            Speaker headset = new Speaker(15,15000, 4.5,2, output);
            string expect = "Test sound is playing";

            //Act
            string actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AppleHeadsetWithoutOutput()
        {
            //Arrange
            AppleHeadset headset = new AppleHeadset(null);
            string expect = "No Output!";

            //Act
            string actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SamsungHeadsetWithoutOutput()
        {
            //Arrange
            SamsungHeadset headset = new SamsungHeadset(null);
            string expect = "No Output!";

            //Act
            string actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void UnofficialAppleHeadsetWithoutOutput()
        {
            //Arrange
            UnofficialAppleHeadset headset = new UnofficialAppleHeadset(null);
            string expect = "No Output!";

            //Act
            string actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SpeakerWithoutOutput()
        {
            //Arrange
            Speaker headset = new Speaker(15, 15000, 4.5, 2, null);
            string expect = "No Output!";

            //Act
            string actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

    }
}
