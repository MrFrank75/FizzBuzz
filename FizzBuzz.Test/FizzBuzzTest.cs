using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        FizzBuzzSolver _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new FizzBuzzSolver();
        }

        [TestMethod]
        public void When_Number_1_is_passed_it_returns_1()
        {
            var result = _sut.Solve(1);
            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        public void When_Number_2_is_passed_it_returns_2()
        {
            var result = _sut.Solve(2);
            Assert.AreEqual(result, "2");
        }

        [TestMethod]
        public void When_Number_3_is_passed_it_returns_Fizz()
        {
            var result = _sut.Solve(3);
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void When_Number_5_is_passed_it_returns_Buzz()
        {
            var result = _sut.Solve(5);
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void When_Number_6_is_passed_it_returns_Fizz()
        {
            var result = _sut.Solve(6);
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void When_Number_10_is_passed_it_returns_Buzz()
        {
            var result = _sut.Solve(10);
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void When_Number_15_is_passed_it_returns_FizzBuzz()
        {
            var result = _sut.Solve(15);
            Assert.AreEqual(result, "FizzBuzz");
        }

        [TestMethod]
        public void When_Number_30_is_passed_it_returns_FizzBuzz()
        {
            var result = _sut.Solve(30);
            Assert.AreEqual(result, "FizzBuzz");
        }
    }
}
