using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcProgram;
using System;

namespace MyCalcProgramTest
{
    [TestClass]
    public class UnitTest
    {
        Calc calc = new Calc();
        [TestMethod]
        public void TestSum()
        {
            double x = 20;
            double y = 50;
            double except = 70;
            double actual = calc.Sum(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void TestSub()
        {
            double x = 50;
            double y = 20;
            double except = 30;
            double actual = calc.Sub(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void TestMul()
        {
            double x = 7;
            double y = 3;
            double except = 21;
            double actual = calc.Mul(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void TestDiv()
        {
            double x = 35;
            double y = 5;
            double except = 7;
            double actual = calc.Div(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void TestExp()
        {
            double x = 2;
            double y = 5;
            double except = 32;
            double actual = calc.Exp(x, y);
            Assert.AreEqual(except, actual);
        }
    }
    [TestClass]
    public class NegativeUnitTest
    {
        Calc calc = new Calc();
        [TestMethod]
        public void TestSum()
        {
            double x = 20;
            double y = 50;
            double except = 60;
            double actual = calc.Sum(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void TestSub()
        {
            double x = 50;
            double y = 20;
            double except = 40;
            double actual = calc.Sub(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void TestMul()
        {
            double x = 7;
            double y = 3;
            double except = 24;
            double actual = calc.Mul(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void TestDiv()
        {
            double x = 35;
            double y = 5;
            double except = 1;
            double actual = calc.Div(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void TestExp()
        {
            double x = 2;
            double y = 5;
            double except = 42;
            double actual = calc.Exp(x, y);
            Assert.AreEqual(except, actual);
        }
    }
}
