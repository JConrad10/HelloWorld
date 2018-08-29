using NUnit.Framework;
using HelloWorld;

namespace HelloWorldTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.That(Program.ReturnMessage(), Is.EqualTo("Hello World!"));
        }
    }
}
