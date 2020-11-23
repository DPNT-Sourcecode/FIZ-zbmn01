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
        public string TestFizzBuzz(int number)
        {
            return number.ToString();
        }
    }
}
