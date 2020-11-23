﻿using BeFaster.App.Solutions.FIZ;
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
        [TestCase(11, ExpectedResult = "11")]
        [TestCase(12, ExpectedResult = "fizz")]
        [TestCase(13, ExpectedResult = "13")]
        [TestCase(14, ExpectedResult = "14")]
        [TestCase(15, ExpectedResult = "fizz buzz")]
        public string TestFizzBuzz(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }
    }
}


