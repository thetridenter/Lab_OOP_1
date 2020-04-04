using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            int b = 6;
            int result = Inglorious_code.Program.Example(a, b);
            Assert.AreEqual(11, result);
        }
    }
}