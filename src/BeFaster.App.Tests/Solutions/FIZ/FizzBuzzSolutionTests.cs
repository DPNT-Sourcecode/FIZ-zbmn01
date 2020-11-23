using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    class FizzBuzzSolutionTests
    {
        [Test]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "fizz")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase(5, ExpectedResult = "buzz")]
        [TestCase(6, ExpectedResult = "fizz")]
        [TestCase(7, ExpectedResult = "7")]
        [TestCase(8, ExpectedResult = "8")]
        [TestCase(9, ExpectedResult = "fizz")]
        [TestCase(10, ExpectedResult = "buzz")]
        [TestCase(11, ExpectedResult = "deluxe")]
        [TestCase(12, ExpectedResult = "fizz")]
        [TestCase(13, ExpectedResult = "fizz")]
        [TestCase(14, ExpectedResult = "14")]
        [TestCase(15, ExpectedResult = "fizz buzz")]
        [TestCase(22, ExpectedResult = "deluxe")]
        [TestCase(30, ExpectedResult = "fizz buzz")]
        [TestCase(31, ExpectedResult = "fizz")]
        [TestCase(32, ExpectedResult = "fizz")]
        [TestCase(33, ExpectedResult = "fizz deluxe")]
        [TestCase(34, ExpectedResult = "fizz")]
        [TestCase(35, ExpectedResult = "fizz buzz")]
        [TestCase(40, ExpectedResult = "buzz")]
        [TestCase(41, ExpectedResult = "41")]
        [TestCase(42, ExpectedResult = "fizz")]
        [TestCase(43, ExpectedResult = "fizz")]
        [TestCase(44, ExpectedResult = "deluxe")]
        [TestCase(45, ExpectedResult = "fizz buzz")]
        [TestCase(50, ExpectedResult = "buzz")]
        [TestCase(51, ExpectedResult = "fizz buzz")]
        [TestCase(52, ExpectedResult = "buzz")]
        [TestCase(53, ExpectedResult = "fizz buzz")]
        [TestCase(54, ExpectedResult = "fizz buzz")]
        [TestCase(55, ExpectedResult = "buzz deluxe")]
        [TestCase(555, ExpectedResult = "fizz buzz deluxe")]
        public string TestFizzBuzz(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }
    }
}

