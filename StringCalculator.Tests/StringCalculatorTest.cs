using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        private StringCalculator sc = new StringCalculator();

        [TestMethod]
        public void EmptyStringReturnsZero()
        {
            int expected = 0;
            int actual = sc.Add("");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneReturnsOne()
        {
            int expected = 1;
            int actual = sc.Add("1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoReturnsTwo()
        {
            int expected = 2;
            int actual = sc.Add("2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RandomSingleDigit()
        {
            int expected = new Random().Next();
            int actual = sc.Add(expected.ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneAndOneReturnsTwo()
        {
            int expected = 2;
            int actual = sc.Add("1,1");
            Assert.AreEqual(expected, actual);
        }
    }
}
