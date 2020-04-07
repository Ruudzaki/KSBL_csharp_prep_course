using KSBL_Class_Library;
using KSBL_Class_Library.Components.Speaker;
using KSBL_Class_Library.Mobile;
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
            var headset = new AppleHeadset(output);
            var expect = "Test Output is running";

            //Act
            var actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SamsungHeadsetIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            var headset = new SamsungHeadset(output);
            var expect = "Test Output is running";

            //Act
            var actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void UnofficialAppleHeadsetIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            var headset = new UnofficialAppleHeadset(output);
            var expect = "Test Output is running";

            //Act
            var actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SpeakerIsPlaying()
        {
            //Arrange
            IOutput output = new FakeOutput();
            var headset = new Speaker(15, 15000, 4.5, 2, output);
            var expect = "Test Output is running";

            //Act
            var actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void NoPlaybackComponent()
        {
            //Arrange
            IOutput output = new FakeOutput();
            var mobile = new SimCorpMobile {Output = output};
            var expect = "Test Output is running";

            //Act
            var actual = mobile.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AppleHeadsetWithoutOutput()
        {
            //Arrange
            var headset = new AppleHeadset(null);
            var expect = "No Output!";

            //Act
            var actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SamsungHeadsetWithoutOutput()
        {
            //Arrange
            var headset = new SamsungHeadset(null);
            var expect = "No Output!";

            //Act
            var actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void UnofficialAppleHeadsetWithoutOutput()
        {
            //Arrange
            var headset = new UnofficialAppleHeadset(null);
            var expect = "No Output!";

            //Act
            var actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SpeakerWithoutOutput()
        {
            //Arrange
            var headset = new Speaker(15, 15000, 4.5, 2, null);
            var expect = "No Output!";

            //Act
            var actual = headset.Play(new object());

            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}