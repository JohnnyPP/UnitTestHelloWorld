using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldUnitTest
{
    [TestClass]
    public class UnitTestCalc
    {
        [TestMethod]
        public void TestMethodCalc()
        {
            var result = UnitTestHelloWorld.Calc.CalculateSum(2.0, 2.0);

            Assert.AreEqual(4.0, result);
        }
    }
}
