namespace RefInOut.Test;
using NUnit;
public class Tests
{
    private Tests RefInOutTest;
    [SetUp]
    public void Setup()
    {
        RefInOutTest = new RefInOut();
    }

    [Test]
    public void TestRef()
    {
        int x = 4;
        int result = RefInOutTest.MultipleandAddbyFour(x, 4);

        Assert.AreEqual(1, RefInOutTest);
    }
}