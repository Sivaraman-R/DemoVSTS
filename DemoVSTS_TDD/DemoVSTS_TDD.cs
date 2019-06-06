using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoVSTS.Controllers;

namespace DemoVSTS_TDD
{
    [TestClass]
    public class DemoVSTS_TDD
    {
        [TestMethod]
        public void Addition()
        {
            int a = 10;
            int b = 10;
            var DemoMathOps = new DemoVSTS.Controllers.MathController();
            int result = DemoMathOps.Add(a, b);
            Assert.AreEqual(20, 20, "Both are not equal");
        }

        [TestMethod]
        public void Subtract()
        {
            int a = 10;
            int b = 10;
            var DemoMathOps = new DemoVSTS.Controllers.MathController();
            int result = DemoMathOps.Sub(a, b);
            Assert.AreEqual(0, 0, "Both are not equal");
        }

        [TestMethod]
        public void Multiply()
        {
            int a = 10;
            int b = 10;
            var DemoMathOps = new DemoVSTS.Controllers.MathController();
            int result = DemoMathOps.Mul(a, b);
            Assert.AreEqual(100, 100, "Both are not equal");
        }

        [TestMethod]
        public void Division()
        {
            int a = 10;
            int b = 10;
            var DemoMathOps = new DemoVSTS.Controllers.MathController();
            int result = DemoMathOps.Div(a, b);
            Assert.AreEqual(0, 0, "Both are not equal");
        }
    }
}
