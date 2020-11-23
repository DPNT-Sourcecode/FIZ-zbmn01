using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    class HelloSolutionTests
    {
        [Test]
        [TestCase("John", ExpectedResult = "Hello, John!")]
        [TestCase("Freddy", ExpectedResult = "Hello, Freddy!")]
        [TestCase("Heinz the Baron Krauz von Espy", ExpectedResult = "Hello, Heinz the Baron Krauz von Espy!")]
        public string TestHello(string friendName)
        {
            return HelloSolution.Hello(friendName);
        }
    }
}
