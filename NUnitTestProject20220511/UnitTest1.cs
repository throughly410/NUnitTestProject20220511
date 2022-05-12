using System.Diagnostics;
using NUnit.Framework;
using NSubstitute;
namespace NUnitTestProject20220511
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //IMyObject obj = new MyObject();
            var obj = Substitute.For<IMyObject>();
            obj.GetNum().Returns(50);
            int num = obj.GetNum();
            Assert.AreEqual(50,num);

        }
    }

    public interface IMyObject
    {
        public int GetNum();
    }

    public class MyObject : IMyObject
    {
        public int GetNum()
        {
            return 0;
        }
    }
}