using NUnit.Framework;
using Operation;
namespace Operation.Test
{
    [TestFixture]
    public class Tests
    {
        private MyOperation myoperationTest;

        [SetUp]
        public void Setup()
        {
            myoperationTest = new MyOperation();
        }

        [Test]
        public void TestAdd()
        {
            myoperationTest.SetValues(5, 3);
            int result = myoperationTest.Add();
            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestSub()
        {
            myoperationTest.SetValues(10, 4);
            int result = myoperationTest.Sub();
            Assert.AreEqual(6, result);
        }
    }
}