using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzClass;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void GetOutputTest3()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "fizz";
            int dividend = 6;
            string actual = fb.GetOutput(dividend);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputTest5()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "buzz";
            int dividend = 40;
            string actual = fb.GetOutput(dividend);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputTest15()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "fizzbuzz";
            int dividend = 45;
            string actual = fb.GetOutput(dividend);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputTestNumbers()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "2";
            int dividend = 2;
            string actual = fb.GetOutput(dividend);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Contains3Test()
        {
            FizzBuzz fb = new FizzBuzz();
            bool expected = true;
            int number = 143;
            bool actual = fb.Contains3(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputStringTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "1 2 lucky 4 buzz fizz";
            int start = 1;
            int end = 6;
            string actual = fb.GetOutputString(start, end);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputStringTestWithLuckyCount()
        {
            FizzBuzz fb = new FizzBuzz();
            int expected = 1;
            int start = 1;
            int end = 6;
            string output = fb.GetOutputString(start, end);
            int actual = FizzBuzz._luckyCount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputStringTestWithFizzCount()
        {
            FizzBuzz fb = new FizzBuzz();
            int expected = 1;
            int start = 1;
            int end = 6;
            string output = fb.GetOutputString(start, end);
            int actual = FizzBuzz._fizzCount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputStringTestWithBuzzCount()
        {
            FizzBuzz fb = new FizzBuzz();
            int expected = 1;
            int start = 1;
            int end = 8;
            string output = fb.GetOutputString(start, end);
            int actual = FizzBuzz._buzzCount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputStringTestWithFizzBuzzCount()
        {
            FizzBuzz fb = new FizzBuzz();
            int expected = 1;
            int start = 1;
            int end = 15;
            string output = fb.GetOutputString(start, end);
            int actual = FizzBuzz._fizzbuzzCount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputStringTestWithIntegerCount()
        {
            FizzBuzz fb = new FizzBuzz();
            int expected = 10;
            int start = 1;
            int end = 20;
            string output = fb.GetOutputString(start, end);
            int actual = FizzBuzz._integerCount;
            Assert.AreEqual(expected, actual);
        }
    }
}
