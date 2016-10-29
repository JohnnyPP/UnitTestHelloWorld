using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = UnitTestHelloWorld.Program.PrintToConsole();

            Assert.AreEqual("Hello world", result);
        }
    }
}
