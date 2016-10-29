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

        [TestMethod]
        public void TestMethod2()
        {
            string input = "Hello world from class";
            string result = UnitTestHelloWorld.ConsolePrint.PrintToConsoleFromClass(input);

            Assert.AreEqual(input, result);
        }
    }
}
