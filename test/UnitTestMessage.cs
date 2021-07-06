using NUnit.Framework;

namespace test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMessageContentIsCorrect()
        {
            string realMessage = Library.Message.GetMessage();
            string expectedMessage = "Hello World!";
            Assert.AreEqual(expectedMessage, realMessage);
        }
    }
}